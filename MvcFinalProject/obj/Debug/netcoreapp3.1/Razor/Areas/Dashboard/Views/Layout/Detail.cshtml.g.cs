#pragma checksum "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Layout\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d994a8d392142bc85a857bcc457ebc1bdfbb85c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Layout_Detail), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Layout/Detail.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\_ViewImports.cshtml"
using MvcFinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\_ViewImports.cshtml"
using MvcFinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\_ViewImports.cshtml"
using MvcFinalProject.Areas.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\_ViewImports.cshtml"
using MvcFinalProject.Areas.Dashboard.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d994a8d392142bc85a857bcc457ebc1bdfbb85c", @"/Areas/Dashboard/Views/Layout/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db8e4c6f77220e04b11b2f2094fb4bd195564e2", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Dashboard_Views_Layout_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Layout>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 200px; border-radius: 0%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Layout\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-panel"">        
        <div class=""content-wrapper"">
          <div class=""row"">
            <div class=""col-md-6 grid-margin stretch-card"">
              <div class=""card"">
                <div class=""card-body"" style=""background-color: #B2BABB"">
                  <ul>
                      <li>
                      Navbar Logo:<br>
                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d994a8d392142bc85a857bcc457ebc1bdfbb85c5557", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 455, "~/Assets/img/logo/", 455, 18, true);
#nullable restore
#line 15 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Layout\Detail.cshtml"
AddHtmlAttributeValue("", 473, Model.NavLogo, 473, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </li><br><br>\r\n                  <li>\r\n                      Footer Logo:<br>\r\n                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d994a8d392142bc85a857bcc457ebc1bdfbb85c7279", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 663, "~/Assets/img/logo/", 663, 18, true);
#nullable restore
#line 19 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Layout\Detail.cshtml"
AddHtmlAttributeValue("", 681, Model.FooterLogo, 681, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </li><br><br>\r\n                  <li>\r\n                      First Social Media Logo: ");
#nullable restore
#line 22 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Layout\Detail.cshtml"
                                          Write(Html.Raw(@Model.FirstSocialMediaLogo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                   <li>\r\n                      Second Social Media Logo: ");
#nullable restore
#line 25 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Layout\Detail.cshtml"
                                           Write(Html.Raw(@Model.SecondSocialMediaLogo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                   <li>\r\n                      Third Social Media Logo: ");
#nullable restore
#line 28 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Layout\Detail.cshtml"
                                          Write(Html.Raw(@Model.ThirdSocialMediaLogo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                   <li>\r\n                      Fourth Social Media Logo: ");
#nullable restore
#line 31 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Layout\Detail.cshtml"
                                           Write(Html.Raw(@Model.FourthSocialMediaLogo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                   <li>\r\n                      First URL: ");
#nullable restore
#line 34 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Layout\Detail.cshtml"
                            Write(Model.FirstURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                   <li>\r\n                      Second URL: ");
#nullable restore
#line 37 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Layout\Detail.cshtml"
                             Write(Model.SecondURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                   <li>\r\n                      Third URL: ");
#nullable restore
#line 40 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Layout\Detail.cshtml"
                            Write(Model.ThirdURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                   <li>\r\n                      Fourth URL: ");
#nullable restore
#line 43 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Layout\Detail.cshtml"
                             Write(Model.FourthURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </li>\r\n                  </ul>\r\n                  \r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d994a8d392142bc85a857bcc457ebc1bdfbb85c12084", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n              </div>\r\n            </div>\r\n             </div>\r\n              </div>\r\n            </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Layout> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
