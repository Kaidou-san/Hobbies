#pragma checksum "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\Home\OneHobby.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0231a16104cee56f8da4e23145114429ddfc1b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneHobby), @"mvc.1.0.view", @"/Views/Home/OneHobby.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\_ViewImports.cshtml"
using BeltExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\_ViewImports.cshtml"
using BeltExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0231a16104cee56f8da4e23145114429ddfc1b7", @"/Views/Home/OneHobby.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84119000702c45f5036e3e300b27d647b6aca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneHobby : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/addCatToHobby"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h1>");
#nullable restore
#line 3 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\Home\OneHobby.cshtml"
       Write(ViewBag.OneHobby.HobbyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h1>Description: ");
#nullable restore
#line 4 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\Home\OneHobby.cshtml"
                    Write(ViewBag.OneHobby.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>       \r\n\r\n        <h3>Enthusiants:</h3>\r\n        <ul>\r\n");
#nullable restore
#line 8 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\Home\OneHobby.cshtml"
             foreach(var e in @ViewBag.OneHobby.UserWhoLikes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 10 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\Home\OneHobby.cshtml"
               Write(e.UserWhoLiked.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\Home\OneHobby.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 377, "\"", 420, 2);
            WriteAttributeValue("", 384, "/editHobby/", 384, 11, true);
#nullable restore
#line 14 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\Home\OneHobby.cshtml"
WriteAttributeValue("", 395, ViewBag.OneHobby.HobbyId, 395, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit Hobby</a>\r\n\r\n        <h4>Proficiency</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0231a16104cee56f8da4e23145114429ddfc1b76049", async() => {
                WriteLiteral("\r\n            <select name=\"CategoryId\" class=\"form-control\">                \r\n");
#nullable restore
#line 19 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\Home\OneHobby.cshtml"
                 foreach(Category c in ViewBag.AllCats)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0231a16104cee56f8da4e23145114429ddfc1b76695", async() => {
#nullable restore
#line 21 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\Home\OneHobby.cshtml"
                                             Write(c.CategoryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\Home\OneHobby.cshtml"
                       WriteLiteral(c.CategoryId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\Home\OneHobby.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n            <input type=\"hidden\" name=\"HobbyId\"");
                BeginWriteAttribute("value", " value=\"", 842, "\"", 875, 1);
#nullable restore
#line 24 "C:\Users\Kaidou\Desktop\DOJO_Assignments\CSharp_June2021\BeltExam\Views\Home\OneHobby.cshtml"
WriteAttributeValue("", 850, ViewBag.OneHobby.HobbyId, 850, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"submit\" value=\"Add Category\" class=\"btn btn-primary\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
