#pragma checksum "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fc4d0b800f9dfd2fd8b21240a84c7cf7a8ebf08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Teacher_Delete), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Teacher/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc4d0b800f9dfd2fd8b21240a84c7cf7a8ebf08", @"/Areas/Dashboard/Views/Teacher/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db8e4c6f77220e04b11b2f2094fb4bd195564e2", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Dashboard_Views_Teacher_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 450px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <div class=""main-panel"">        
        <div class=""content-wrapper"">
          <div class=""row"">
            <div class=""col-md-6 grid-margin stretch-card"">
              <div class=""card"">
                <div class=""card-body"">
                  <h4 class=""card-title"">");
#nullable restore
#line 12 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                                    Write(Model.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fc4d0b800f9dfd2fd8b21240a84c7cf7a8ebf086624", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 390, "~/assets/img/teacher/", 390, 21, true);
#nullable restore
#line 13 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
AddHtmlAttributeValue("", 411, Model.MainImage, 411, 16, false);

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
            WriteLiteral("\r\n                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fc4d0b800f9dfd2fd8b21240a84c7cf7a8ebf088246", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 483, "~/assets/img/teacher/", 483, 21, true);
#nullable restore
#line 14 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
AddHtmlAttributeValue("", 504, Model.DetailImage, 504, 18, false);

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
            WriteLiteral("\r\n                  <p>\r\n                     About: ");
#nullable restore
#line 16 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </p>\r\n                  <p>\r\n                   Degree: ");
#nullable restore
#line 19 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </p>\r\n                  <p>\r\n                   Hobbies: ");
#nullable restore
#line 22 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                       Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </p>\r\n                \r\n\r\n                  <p>\r\n                   Mail: ");
#nullable restore
#line 27 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                    Write(Model.Contact.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </p>\r\n                  <p>\r\n                   PhoneNumber: ");
#nullable restore
#line 30 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                           Write(Model.Contact.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </p>\r\n                  <p>\r\n                   Skype: ");
#nullable restore
#line 33 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                     Write(Model.Contact.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </p>\r\n                  <p>\r\n                   FirstURL: ");
#nullable restore
#line 36 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                        Write(Model.Contact.InstagramUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </p>\r\n                  <p>\r\n                   SecondURL: ");
#nullable restore
#line 39 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                         Write(Model.Contact.FacebookUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </p>\r\n                  <p>\r\n                   ThirdURL: ");
#nullable restore
#line 42 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                        Write(Model.Contact.TwitterUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </p>\r\n                  <p>\r\n                   FourthURL: ");
#nullable restore
#line 45 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                         Write(Model.Contact.PinterestUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </p>\r\n\r\n");
            WriteLiteral("                 <p>Skills: </p>\r\n");
#nullable restore
#line 53 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                  foreach (var item in Model.Skill)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 55 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                  Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 55 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                                Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 56 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Areas\Dashboard\Views\Teacher\Delete.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <p>Eminsinizmi ?</p>\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fc4d0b800f9dfd2fd8b21240a84c7cf7a8ebf0814662", async() => {
                WriteLiteral("<button class=\"btn btn-secondary\" type=\"submit\">Submit</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fc4d0b800f9dfd2fd8b21240a84c7cf7a8ebf0816375", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n              </div>\r\n            </div>\r\n           </div>\r\n          </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
