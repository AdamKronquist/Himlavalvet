using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Himlavalvet
{
    public class DbHandler
    {
        /// <summary>
        /// Metod som ansluter till databas.
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection getConnection()
        {
            string server = "localhost";
            string database = "himlavalvet";
            string uid = "root";
            string password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySqlConnection connection = connection = new MySqlConnection(connectionString);
            return connection;
        }


        /// <summary>
        /// Hämtar alla poster från databasen som innehållet en viss rubrik.
        /// Datan sorteras i ordningen nyast först för att man inte ska behöva bläddra nedåt för att komma till de senaste inlägget.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        public static async Task<string> readDBAllPosts(string subject)
        {
            MySqlConnection connection = getConnection();
            string output = "";
            connection.Open();
            using var command = new MySqlCommand($"SELECT * FROM posts WHERE subject = \"{subject}\" ORDER BY postDate DESC;", connection);
            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    var value = reader.GetValue(i);
                    output += value + "\t";
                }
                output += "\n";
            }
            return output;
        }


        /// <summary>
        /// Hämtar en användare från databasen om den får en match på email och lösenord.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static async Task<string> readDBUser(string email, string password)
        {
            MySqlConnection connection = getConnection();
            string output = "";
            connection.Open();
            using var command = new MySqlCommand($"SELECT username FROM users WHERE password = \"{password}\" AND email = \"{email}\";", connection);
            using var reader = await command.ExecuteReaderAsync();
            Console.WriteLine();
            while (await reader.ReadAsync())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    var value = reader.GetValue(i);
                    output += value + "\t";
                }
                output += "\n";
            }
            return output;
        }


        /// <summary>
        /// Skriver ett nytt inlägg till databasen.
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="date"></param>
        /// <param name="post"></param>
        /// <param name="subject"></param>
        public static void WriteNewPostToDb(string writer, DateTime date, string post, string subject)
        {
            MySqlConnection connection = getConnection();
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO posts (writer, postDate, post, subject) VALUES (@text1, @text2, @text3, @text4)", connection);
            command.Prepare();
            command.Parameters.AddWithValue("@text1", writer);
            command.Parameters.AddWithValue("@text2", date);
            command.Parameters.AddWithValue("@text3", post);
            command.Parameters.AddWithValue("@text4", subject);
            command.ExecuteNonQuery();
        }


        /// <summary>
        /// Skriver en ny användare till databasen.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="username"></param>
        public static void WriteUserToDb(string email, string password, string username)
        {
            MySqlConnection connection = getConnection();
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (email, password, username) VALUES (@text1, @text2, @text3)", connection);
            command.Prepare();
            command.Parameters.AddWithValue("@text1", email);
            command.Parameters.AddWithValue("@text2", password);
            command.Parameters.AddWithValue("@text3", username);
            command.ExecuteNonQuery();
        }


        /// <summary>
        /// Hämtar alla ämnen från databasen. Sorterar i ordningen med den som skapades senast är längst upp.
        /// </summary>
        /// <returns></returns>
        public static async Task<string> ReadSubjectsDb()
        {
            MySqlConnection connection = getConnection();
            string output = "";
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM subjects ORDER BY createDate DESC;", connection);
            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    var value = reader.GetValue(i);
                    output += value + "\t";
                }
                output += "\n";
            }
            return output;
        }


        /// <summary>
        /// Skriver ner ett nytt ämne till databasen.
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="date"></param>
        /// <param name="createdBy"></param>
        public static void WriteSubjectDb(string subject, DateTime date, string createdBy)
        {
            MySqlConnection connection = getConnection();
            connection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO subjects (subject, createDate, createdBy) VALUES (@text1, @text2, @text3)", connection);
            command.Prepare();
            command.Parameters.AddWithValue("@text1", subject);
            command.Parameters.AddWithValue("@text2", date);
            command.Parameters.AddWithValue("@text3", createdBy);
            command.ExecuteNonQuery();
        }


        /// <summary>
        /// Räknar hur många inlägg det finns i varje ämne.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        public static async Task<string> ReadNumberOfPosts(string subject)
        {
            MySqlConnection connection = getConnection();
            string output = "";
            connection.Open();
            using var command = new MySqlCommand($"SELECT COUNT(*) FROM posts WHERE subject = \"{subject}\";", connection);
            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    var value = reader.GetValue(i);
                    output += value + "\t";
                }
                output += "\n";
            }
            return output;
        }


        /// <summary>
        /// Tar fram det senaste inlägget i varje ämne. Informationen man får är datum när det skrevs och vem som skrev inlägget.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns></returns>
        public static async Task<string> ReadLastPosts(string subject)
        {
            MySqlConnection connection = getConnection();
            string output = "";
            connection.Open();
            using var command = new MySqlCommand($"SELECT postDate, writer FROM posts WHERE subject = \"{subject}\" ORDER BY postDate DESC LIMIT 1;", connection);

            //SELECT postDate, writer FROM `posts` WHERE subject = "Tror ni att jorden är platt?" ORDER BY postDate DESC ;
            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    var value = reader.GetValue(i);
                    output += value + "\t";
                }
                output += "\n";
            }
            return output;
        }

    }
}
