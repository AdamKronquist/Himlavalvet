#pragma checksum "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\AddSubject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "512a2048a395655a10d3d5573caa426144fe5a1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Himlavalvet.Pages.Pages_AddSubject), @"mvc.1.0.razor-page", @"/Pages/AddSubject.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512a2048a395655a10d3d5573caa426144fe5a1c", @"/Pages/AddSubject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ea9e27c7e79e04dd07afc57f188294acbf43e5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AddSubject : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Subjects"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    .myContainer {
        display: flex;
        justify-content: center;
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
        justify-content: center;
    }

    h1, label, a, th, td, a:hover, .myLink:hover, h3 {
        color: white;
    }

    input, textarea, .myLink {
        font-weight: bold;
    }

    .myLink {
        font-size: x-large;
    }

    .myContainer2 {
        display: flex;
        flex-direction: column;
        align-items: center;
        margin-top: 100px;
    }

    h3 {
        margin-top: 50px;
    }
</style>

");
#nullable restore
#line 58 "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\AddSubject.cshtml"
   if (Program.signedIn)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"text-center\">Skapa ett nytt ämne.</h3>\r\n        <div class=\"myContainer\">\r\n            <div class=\"signInForm\">\r\n                <div class=\"mySignInContainer\">\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "512a2048a395655a10d3d5573caa426144fe5a1c5359", async() => {
                WriteLiteral(@"
                        <div class=""myInputContainer"">
                            <label for=""subject""><b>Ämne:</b></label>
                            <input type=""text"" placeholder=""Ange ämne"" name=""subject"" required maxlength=""50"" />
                        </div>
                        <div class=""myInputContainer"">
                            <label for=""post""><b>Ditt inlägg:</b></label>
                            <textarea rows=""5"" name=""post"" placeholder=""Skriv det du vill här"" required maxlength=""200""></textarea>
                        </div>
                        <div class=""myButtonContainer"">
                            <button type=""submit"" class=""btn btn-primary""><b>Skapa och lägg upp</b></button>
                        </div>
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 85 "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\AddSubject.cshtml"

    }
    //Är man inte inloggad får man denna text istället för formuläret.
    //Detta för att man måste vara inloggad för att komma åt något innehåll på sidan.
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"myContainer2\">\r\n            <h1>För att komma åt den här sidan behöver du vara inloggad!</h1>\r\n            <a class=\"myLink\" href=\"index\">Till startsidan</a>\r\n        </div>\r\n");
#nullable restore
#line 95 "C:\Adam\Systemutvecklare .NET\1. Webbapplikationer och mobil utveckling\Inlämning_3\Himlavalvet\Himlavalvet\Pages\AddSubject.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Himlavalvet.Pages.AddSubjectModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Himlavalvet.Pages.AddSubjectModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Himlavalvet.Pages.AddSubjectModel>)PageContext?.ViewData;
        public Himlavalvet.Pages.AddSubjectModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
