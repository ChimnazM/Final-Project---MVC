#pragma checksum "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "611c9650261731c8261ea62c9b6baf4be0f89dc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\_ViewImports.cshtml"
using MvcFinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\_ViewImports.cshtml"
using MvcFinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\_ViewImports.cshtml"
using MvcFinalProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611c9650261731c8261ea62c9b6baf4be0f89dc0", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"768c511df1a0b9065ece156105886373a5afa612", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("about"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/img/icon/section.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		<!-- Banner Area Start -->
		<div class=""banner-area-wrapper"">
            <div class=""banner-area text-center"">	
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""banner-content-wrapper"">
                                <div class=""banner-content"">
                                    <h2>about us</h2> 
                                </div> 
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>    
		<!-- Banner Area End -->
        <!-- About Start -->
        <div class=""about-area pt-145 pb-155"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""about-content"">
                            <h2>");
#nullable restore
#line 28 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
                           Write(Model.Welcome.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>");
#nullable restore
#line 29 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
                          Write(Model.Welcome.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <p class=""hidden-sm"">I must explain to you how all this mistaken idea of denouncing pleure and prsing pain was born and I will give you a complete account of the system</p>
                            <a class=""default-btn"" href=""#"">view courses</a>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""about-img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "611c9650261731c8261ea62c9b6baf4be0f89dc06976", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1555, "~/Assets/img/about/", 1555, 19, true);
#nullable restore
#line 36 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 1574, Model.Welcome.Image, 1574, 20, false);

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
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- About End -->
        <!-- Teacher Start -->
        <div class=""teacher-area pb-150"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""section-title text-center"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "611c9650261731c8261ea62c9b6baf4be0f89dc09006", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <h2>meet our teachers</h2>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 55 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
                        foreach (var teacher in Model.Teachers)
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <div class=\"col-lg-3 col-sm-6\">\r\n                        <div class=\"single-teacher\">\r\n                            <div class=\"single-teacher-img\">\r\n                                <a href=\"teacher-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "611c9650261731c8261ea62c9b6baf4be0f89dc010849", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2608, "~/Assets/img/teacher/", 2608, 21, true);
#nullable restore
#line 60 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 2629, teacher.MainImage, 2629, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>  \r\n                            </div>\r\n                            <div class=\"single-teacher-content text-center\">\r\n                                <h2><a href=\"teacher-details.html\">");
#nullable restore
#line 63 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
                                                              Write(teacher.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                <h4>Associate Professor</h4>\r\n                                <ul>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3022, "\"", 3057, 1);
#nullable restore
#line 66 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 3029, teacher.Contact.FacebookUrl, 3029, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3146, "\"", 3183, 2);
#nullable restore
#line 67 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 3153, teacher.Contact.PinterestUrl, 3153, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3182, "/", 3182, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3273, "\"", 3309, 1);
#nullable restore
#line 68 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 3280, teacher.Contact.InstagramUrl, 3280, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3395, "\"", 3429, 1);
#nullable restore
#line 69 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
WriteAttributeValue("", 3402, teacher.Contact.TwitterUrl, 3402, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-twitter\"></i></a></li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 74 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                 \r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- Teacher End -->\r\n        <!-- Testimonial Area Start -->\r\n        ");
#nullable restore
#line 82 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
   Write(await Component.InvokeAsync("Testimonial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!-- Testimonial Area End -->\r\n        <!-- Notice Start -->\r\n       ");
#nullable restore
#line 85 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
  Write(await Component.InvokeAsync("NoticeBoard"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!-- Notice End -->\r\n        <!-- Subscribe Start -->\r\n       ");
#nullable restore
#line 88 "C:\Users\HP\Desktop\Mvcproject\MvcFinalProject\MvcFinalProject\Views\About\Index.cshtml"
  Write(await Component.InvokeAsync("Subscribe"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591