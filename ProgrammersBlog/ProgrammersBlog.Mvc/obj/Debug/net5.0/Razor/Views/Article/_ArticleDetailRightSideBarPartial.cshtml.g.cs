#pragma checksum "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82183dcb7f8987aa9f35e8cc7b7a04cbdacb8dbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article__ArticleDetailRightSideBarPartial), @"mvc.1.0.view", @"/Views/Article/_ArticleDetailRightSideBarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82183dcb7f8987aa9f35e8cc7b7a04cbdacb8dbe", @"/Views/Article/_ArticleDetailRightSideBarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Article__ArticleDetailRightSideBarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammersBlog.Mvc.Models.ArticleDetailRightSideBarViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px;height:300px;border-radius:50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top text-center img-thumbnail mt-1 mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"widget-wrap\">\r\n\r\n    <div class=\"single-sidebar-widget user-info-widget\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82183dcb7f8987aa9f35e8cc7b7a04cbdacb8dbe5245", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 182, "~/img/", 182, 6, true);
#nullable restore
#line 7 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
AddHtmlAttributeValue("", 188, Model.User.Picture, 188, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 7 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
AddHtmlAttributeValue("", 322, Model.User.UserName, 322, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <a href=\"#\"><h4 style=\"font-size: 32px;\">");
#nullable restore
#line 8 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
                                            Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\r\n        <hr />\r\n        <p class=\"mt-3 mb-4\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
       Write(Model.User.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <ul class=\"social-links\">\r\n");
#nullable restore
#line 14 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
             if (Model.User.LinkedInLink != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 643, "\"", 674, 1);
#nullable restore
#line 16 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
WriteAttributeValue("", 650, Model.User.LinkedInLink, 650, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-linkedin fa-3x\"></i></a></li>\r\n");
#nullable restore
#line 17 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
             if (Model.User.GitHubLink != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 825, "\"", 854, 1);
#nullable restore
#line 20 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
WriteAttributeValue("", 832, Model.User.GitHubLink, 832, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-github fa-3x\"></i></a></li>\r\n");
#nullable restore
#line 21 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
             if (Model.User.FacebookLink != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 1005, "\"", 1036, 1);
#nullable restore
#line 24 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
WriteAttributeValue("", 1012, Model.User.FacebookLink, 1012, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook fa-3x\"></i></a></li>\r\n");
#nullable restore
#line 25 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
             if (Model.User.InstagramLink != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 1190, "\"", 1222, 1);
#nullable restore
#line 28 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
WriteAttributeValue("", 1197, Model.User.InstagramLink, 1197, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram-square fa-3x\"></i></a></li>\r\n");
#nullable restore
#line 29 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
             if (Model.User.TwitterLink != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 1382, "\"", 1412, 1);
#nullable restore
#line 32 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
WriteAttributeValue("", 1389, Model.User.TwitterLink, 1389, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ><i class=\"fab fa-twitter fa-3x\"></i></a></li>\r\n");
#nullable restore
#line 33 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
             if (Model.User.YoutubeLink != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 1564, "\"", 1594, 1);
#nullable restore
#line 36 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
WriteAttributeValue("", 1571, Model.User.YoutubeLink, 1571, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-youtube-square fa-3x\"></i> </a></li>\r\n");
#nullable restore
#line 37 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
             if (Model.User.WebsiteLink != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 1753, "\"", 1783, 1);
#nullable restore
#line 40 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
WriteAttributeValue("", 1760, Model.User.WebsiteLink, 1760, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-address-book fa-3x\"></i></a></li>\r\n");
#nullable restore
#line 41 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"single-sidebar-widget popular-post-widget\">\r\n        <h4 class=\"popular-title\">");
#nullable restore
#line 45 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
                             Write(Model.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <div class=\"popular-post-list\">\r\n");
#nullable restore
#line 47 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
             for (int i = 0; i < Model.ArticleListDto.Articles.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"single-post-list d-flex flex-row align-items-center\">\r\n                    <div class=\"thumb\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "82183dcb7f8987aa9f35e8cc7b7a04cbdacb8dbe16363", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2303, "~/img/", 2303, 6, true);
#nullable restore
#line 51 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
AddHtmlAttributeValue("", 2309, Model.ArticleListDto.Articles[i].Thumbnail, 2309, 43, false);

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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"details\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82183dcb7f8987aa9f35e8cc7b7a04cbdacb8dbe18186", async() => {
#nullable restore
#line 54 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
                                                                                                                              Write(Model.ArticleListDto.Articles[i].Title);

#line default
#line hidden
#nullable disable
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
#line 54 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
                                                                                 WriteLiteral(Model.ArticleListDto.Articles[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-articleId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <p>");
#nullable restore
#line 55 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
                      Write(Model.ArticleListDto.Articles[i].CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 58 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\Article\_ArticleDetailRightSideBarPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n   \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammersBlog.Mvc.Models.ArticleDetailRightSideBarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
