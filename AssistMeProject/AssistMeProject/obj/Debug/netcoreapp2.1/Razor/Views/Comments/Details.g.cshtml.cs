#pragma checksum "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Comments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ff9487fc2e8c54529823b4603c853cc5a247f06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comments_Details), @"mvc.1.0.view", @"/Views/Comments/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comments/Details.cshtml", typeof(AspNetCore.Views_Comments_Details))]
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
#line 1 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\_ViewImports.cshtml"
using AssistMeProject;

#line default
#line hidden
#line 2 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\_ViewImports.cshtml"
using AssistMeProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff9487fc2e8c54529823b4603c853cc5a247f06", @"/Views/Comments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e9000fdfbf39452f2df6e36ab8c5a2875360c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Comments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AssistMeProject.Models.Comment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Comments\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 470, true);
            WriteLiteral(@"


<ul class=""children"">
    <li class=""comment"">
        <div class=""comment-body clearfix"">
            <div class=""avatar""><img alt="""" src=""http://placehold.it/60x60/FFF/444""></div>
            <div class=""comment-text"">
                <div class=""author clearfix"">
                    <div class=""comment-author""><a href=""#"">Anom</a></div>
                    <div class=""comment-meta"">
                        <div class=""date""><i class=""icon-time""></i>");
            EndContext();
            BeginContext(555, 28, false);
#line 17 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Comments\Details.cshtml"
                                                              Write(Html.DisplayFor(m => m.Date));

#line default
#line hidden
            EndContext();
            BeginContext(583, 119, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"text\">\r\n                    <p>");
            EndContext();
            BeginContext(703, 35, false);
#line 21 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Comments\Details.cshtml"
                  Write(Html.DisplayFor(m => m.Description));

#line default
#line hidden
            EndContext();
            BeginContext(738, 41, true);
            WriteLiteral("</p>\r\n                    <p>Comment in: ");
            EndContext();
            BeginContext(780, 40, false);
#line 22 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Comments\Details.cshtml"
                              Write(Html.DisplayFor(m=>m.Answer.Description));

#line default
#line hidden
            EndContext();
            BeginContext(820, 97, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </li>\r\n</ul>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(917, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8754fb83cdf34b0ebc50e9f29017228f", async() => {
                BeginContext(963, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "D:\UNIVERSIDAD ICESI\5TO SEMESTRE\Proyecto integrador\AssistMe\AssistMe\AssistMeProject\AssistMeProject\Views\Comments\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(971, 63, true);
            WriteLiteral(" <!--|\r\n    <a asp-action=\"Index\">Back to List</a>-->\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssistMeProject.Models.Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591
