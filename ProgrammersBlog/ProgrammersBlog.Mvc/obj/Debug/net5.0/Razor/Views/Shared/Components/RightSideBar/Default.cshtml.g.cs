#pragma checksum "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25f44fc3df6a047ddbfc92dc917e579562d3f87a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RightSideBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RightSideBar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25f44fc3df6a047ddbfc92dc917e579562d3f87a", @"/Views/Shared/Components/RightSideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RightSideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammersBlog.Mvc.Models.RightSiteBarViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("details-btn d-flex justify-content-center align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- Start popular-course Area -->
<section class=""popular-course-area section-gap"">
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            <div class=""menu-content pb-70 col-lg-8"">
                <div class=""title text-center"">
                    <h1 class=""mb-10"">Kategoriler</h1>
                    <p>Kategoriler</p>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""active-popular-carusel"">
                <div class=""single-popular-carusel"">

                    <div class=""details"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25f44fc3df6a047ddbfc92dc917e579562d3f87a6001", async() => {
                WriteLiteral("\r\n                            <h4>\r\n                               Hepsi\r\n                            </h4>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                 foreach (var category in Model.Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-popular-carusel\">\r\n\r\n                        <div class=\"details\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25f44fc3df6a047ddbfc92dc917e579562d3f87a8013", async() => {
                WriteLiteral("\r\n                                <h4>\r\n                                    ");
#nullable restore
#line 33 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                               Write(category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </h4>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                                                                                  WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 38 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>
<!-- Start blog Area -->
<section class=""blog-area section-gap"" id=""blog"">
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            <div class=""menu-content pb-70 col-lg-8"">
                <div class=""title text-center"">
                    <h1 class=""mb-10"">En Çok Okunan Makaleler</h1>
                    <p>En Çok Okunan Makaleler</p>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 56 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
             foreach (var article in Model.Articles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-6 single-blog\">\r\n                    <div class=\"thumb\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25f44fc3df6a047ddbfc92dc917e579562d3f87a12239", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2226, "~/img/", 2226, 6, true);
#nullable restore
#line 60 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
AddHtmlAttributeValue("", 2232, article.Thumbnail, 2232, 18, false);

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
            WriteLiteral("\r\n                    </div>\r\n                    <p class=\"meta\">");
#nullable restore
#line 62 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                               Write(article.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 62 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                                                                         Write(article.CreatedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a href=\"blog-single.html\">\r\n                        <h5>");
#nullable restore
#line 64 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                       Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </a>\r\n                    <p>\r\n");
#nullable restore
#line 67 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                         if (article.Content.Length > 50)
                        {
                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                        Write(article.Content.Substring(0, 50));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                                                               
                        }
                        else
                        {
                             

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                        Write(article.Content);

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25f44fc3df6a047ddbfc92dc917e579562d3f87a16676", async() => {
                WriteLiteral("<span class=\"details\">Tümünü Gör </span><span class=\"fas fa-greater-than mr-2\"></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-articleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                                                                             WriteLiteral(article.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-articleId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 78 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n<!-- End blog Area -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammersBlog.Mvc.Models.RightSiteBarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
