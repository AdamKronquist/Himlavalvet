#pragma checksum "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b72db4cb2aee48a44ffe834bf7b13466b5a8296"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Himlavalvet.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Himlavalvet.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\_ViewImports.cshtml"
using Himlavalvet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b72db4cb2aee48a44ffe834bf7b13466b5a8296", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ea9e27c7e79e04dd07afc57f188294acbf43e5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    .myContainer {
        display: flex;
        flex-direction: column;
        align-items: center;
        padding: 10px;
    }

    .signInForm {
        width: 40%;
        background-color: rgba(20, 75, 120, 0.5);
        border: 5px solid black;
        border-radius: 20px;
        padding: 20px 0px;
        margin-top: 50px;
    }

    .mySignInContainer, .myInputContainer {
        display: flex;
        flex-direction: column;
        margin-bottom: 20px;
        padding: 10px;
    }

    .myButtonContainer {
        display: flex;
        flex-direction: row;
        height: 50px;
        align-items: baseline;
        justify-content: space-evenly;
    }

    .btn {
        margin-left: 10px;
    }

    .buttonStyle {
        color: blue;
        border: 0px;
        background: rgba(0, 0, 0, 0);
    }

    .buttonStyle:hover {
        text-decoration: underline;
    }

    .userContainer {
        display: flex;
        flex-direction: colu");
            WriteLiteral(@"mn;
        margin-top: 20px;
        background-color: rgba(20, 45, 85, 0.5);
        padding: 20px;
        border-radius: 15px;
        border: 5px solid black;
    }

    h1, h2, h3, h4, label, a, th, td, a:hover {
        color: white;
    }

    input {
        font-weight: bold;
    }
</style>

");
#nullable restore
#line 73 "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\Index.cshtml"
  
    //Om man kommer till den här sidan via ett POST-formulär ska nödvändiga variablar sparas ner.
    if (ViewContext.HttpContext.Request.Method == "POST")
    {
        string email = Request.Form["email"];
        string password = Request.Form["password"];
        string username = Request.Form["username"];
        //Variabeln status har jag skapat för att veta vilka olika formulär det är som skickas data.
        //Beroende på dess text så är det olika saker som skickas med.
        string status = Request.Form["status"];

        //Om det man försöker göra är att logga in.
        if (status == "SignIn")
        {
            //För att logga in använder man email och lösenord.
            //Då skickas ett POST-formuler med enbart email och lösenord i informationen. För att det inte ska synas i addressfältet.
            //Det betyder att den ska försöka läsa från databasen och se om den hittar någon träff på den angivna emailen och lösenordet.
            var dbUser = DbHandler.readDBUser(email, password).Result;
            string test = dbUser;
            //Om dbUser inte är en tom sträng betyder det att det fanns en träff i databasen och inloggningen lyckades.
            //Användarnamnet sätts till dbUser för att kunna komma åts på alla sidor. Tar bort de två sista tecknena då dessa blev \t\n och förstörde databasen.
            //signedIn ändras till true för att hemsidan ska veta att man är inloggad.
            if (dbUser != "")
            {
                Program.username = dbUser.Substring(0, dbUser.Length - 2);
                Program.signedIn = true;
            }
            else
            {
                Program.signedIn = false;
            }
        }
        //Om statusen är CreateAccount så har man precis skapat ett konto.
        else if (status == "CreateAccount")
        {
            //Man ska bli automatiskt inloggad med de uppgifter man precis angett.
            //Och uppgifterna läggs till i databasen.
            DbHandler.WriteUserToDb(email, password, username);
            Program.username = username;
            Program.signedIn = true;
        }
        //Om statusen är SignOut vill man logga ut.
        else if (status == "SignOut")
        {
            //Då vill man bara loggas ut och variabeln för username ska tömmas.
            Program.username = "";
            Program.signedIn = false;
        }
        else if(status == "FakeSignIn")
        {
            Program.username = "Fejkare";
            Program.signedIn = true;
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"myContainer\">\r\n    <h1>Välkommen till himlavalvet</h1>\r\n\r\n");
#nullable restore
#line 132 "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\Index.cshtml"
     if (Program.signedIn)
    {
        //Om man är inloggad står ens användarnamn på startsidan

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>");
#nullable restore
#line 135 "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\Index.cshtml"
       Write(Program.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 136 "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\Index.cshtml"
    }
    //Är man inte inloggad finns det ett formulär med inloggningsuppgifter.
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>- Allt mellan himmel och sol -</h2><br />\r\n        <h3>För att använda forumet måste du vara inloggad.</h3>\r\n        <div class=\"signInForm\">\r\n            <div class=\"mySignInContainer\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b72db4cb2aee48a44ffe834bf7b13466b5a82969528", async() => {
                WriteLiteral(@"
                    <div class=""myInputContainer"">
                        <label for=""email""><b>Email:</b></label>
                        <input type=""text"" placeholder=""Ange email"" name=""email"" maxlength=""50"" required />
                    </div>
                    <div class=""myInputContainer"">
                        <label for=""password""><b>Lösenord:</b></label>
                        <input type=""password"" placeholder=""Ange lösenord"" name=""password"" maxlength=""15"" required />
                    </div>
                    <div class=""myButtonContainer"">
                        <button type=""submit"" class=""btn btn-primary""><b>Logga in</b></button>
                        <a href=""CreateAccount""><b>Skapa ett konto</b></a>
                    </div>
                    <input type=""hidden"" name=""status"" value=""SignIn"" />
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b72db4cb2aee48a44ffe834bf7b13466b5a829611995", async() => {
                WriteLiteral(@"
                    <div class=""myButtonContainer"">
                        <button type=""submit"" class=""btn btn-danger""><b>Fuskinloggning</b></button>
                    </div>
                    <input type=""hidden"" name=""status"" value=""FakeSignIn"" />
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 168 "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\Index.cshtml"
        //En tabell med tre användare som finns skapade i databasen för att man ska kunna logga in, lägga till och skriva i poster.

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""userContainer"">
            <h4>Skapa ett eget konto eller använd något av de förvalda</h4>
            <table class=""table"">
                <tr>
                    <th>Email</th>
                    <th>Lösenord</th>
                    <th>Användarnamn</th>
                </tr>
                <tr>
                    <td>erik@hotmail.com</td>
                    <td>Pluto9</td>
                    <td>Astrologen</td>
                </tr>
                <tr>
                    <td>jens@passagen.se</td>
                    <td>Vintergatan</td>
                    <td>Stjärnfallet</td>
                </tr>
                <tr>
                    <td>hugo@gmail.com</td>
                    <td>rymdraket</td>
                    <td>Tellus66</td>
                </tr>
            </table>
        </div>
");
#nullable restore
#line 194 "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
