#pragma checksum "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebd16699b06a44775937637069be22fc603939a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Detail), @"mvc.1.0.view", @"/Views/User/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebd16699b06a44775937637069be22fc603939a9", @"/Views/User/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProgrammersBlog.Mvc.Models.UserDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded mx-auto d-block mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:500px; max-height:500px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn text-uppercase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Yazar Detay";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- start banner Area -->
<section class=""banner-area relative about-banner"" id=""home"">
    <div class=""overlay overlay-bg""></div>
    <div class=""container"">
        <div class=""row d-flex align-items-center justify-content-center"">
            <div class=""about-content col-lg-12"">
                <h1 class=""text-white"">
                    Yazar Detay
                </h1>
                <p class=""text-white link-nav"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebd16699b06a44775937637069be22fc603939a95972", async() => {
                WriteLiteral(" Yazar Detay ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                                                                                                  WriteLiteral(Model.User.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  <span class=\"lnr lnr-arrow-right\"></span> \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebd16699b06a44775937637069be22fc603939a98493", async() => {
#nullable restore
#line 17 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                                                                                          Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                                                                                                                Write(Model.User.LastName);

#line default
#line hidden
#nullable disable
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                                                                   WriteLiteral(Model.User.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>
</section>
<!-- End banner Area -->
<!-- Start course-details Area -->
<section class=""course-details-area pt-40"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 left-contents"">
                <div class=""main-image"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ebd16699b06a44775937637069be22fc603939a911872", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1273, "~/img/", 1273, 6, true);
#nullable restore
#line 29 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
AddHtmlAttributeValue("", 1279, Model.User.Picture, 1279, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
AddHtmlAttributeValue("", 1305, Model.User.UserName, 1305, 20, false);

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
            WriteLiteral(@"
                </div>
                <div class=""jq-tab-wrapper"" id=""horizontalTab"">
                    <div class=""jq-tab-menu"">
                        <div class=""jq-tab-title active"" data-tab=""1"">Hakkında</div>                      
                        <div class=""jq-tab-title"" data-tab=""3"">Yazarın Makaleleri</div>                     
                    </div>
                    <div class=""jq-tab-content-wrapper"">
                        <div class=""jq-tab-content active"" data-tab=""1"">
                            ");
#nullable restore
#line 38 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                       Write(Model.User.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"jq-tab-content\" data-tab=\"3\">\r\n                            <ul class=\"course-list\">\r\n");
#nullable restore
#line 42 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                                 foreach (var article in Model.ArticleListDto.Articles)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"justify-content-between d-flex\">\r\n                                        <p>");
#nullable restore
#line 45 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                                      Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebd16699b06a44775937637069be22fc603939a915787", async() => {
                WriteLiteral("Tümünü Gör");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-articleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                                                                                                                                    WriteLiteral(article.Id);

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
            WriteLiteral("\r\n                                    </li>\r\n");
#nullable restore
#line 48 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                   
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 right-contents"">
                <ul>
                    <li>
                        <a class=""justify-content-between d-flex"" href=""#"">
                            <p style=""font-size:19px ; font-weight:bold"">Yazar Adı</p>
                            <span class=""or"" style=""font-size: 17px"">");
#nullable restore
#line 61 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                                                                Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 61 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                                                                                      Write(Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </a>
                    </li>
                    <li>
                        <a class=""justify-content-between d-flex mb-3"" style=""font-size:19px ; font-weight:bold"" href=""#"">
                            <p class=""mt-1"">Sosyal Medya</p>

");
#nullable restore
#line 68 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                             if (Model.User.LinkedInLink != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span><a");
            BeginWriteAttribute("href", " href=\"", 3517, "\"", 3548, 1);
#nullable restore
#line 70 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
WriteAttributeValue("", 3524, Model.User.LinkedInLink, 3524, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-linkedin fa-3x mr-4\"></i></a></span>\r\n");
#nullable restore
#line 71 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                             if (Model.User.FacebookLink != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span><a");
            BeginWriteAttribute("href", " href=\"", 3776, "\"", 3807, 1);
#nullable restore
#line 75 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
WriteAttributeValue("", 3783, Model.User.FacebookLink, 3783, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook fa-3x  mr-4\"></i></a></span>\r\n");
#nullable restore
#line 76 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                             if (Model.User.InstagramLink != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span><a");
            BeginWriteAttribute("href", " href=\"", 4035, "\"", 4067, 1);
#nullable restore
#line 79 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
WriteAttributeValue("", 4042, Model.User.InstagramLink, 4042, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram-square fa-3x  mr-4\"></i></a></span>\r\n");
#nullable restore
#line 80 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                             if (Model.User.TwitterLink != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span><a");
            BeginWriteAttribute("href", " href=\"", 4301, "\"", 4331, 1);
#nullable restore
#line 83 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
WriteAttributeValue("", 4308, Model.User.TwitterLink, 4308, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter fa-3x  mr-4\"></i></a></span>\r\n");
#nullable restore
#line 84 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </a>
                    </li>
                </ul>
                <div class=""single-sidebar-widget popular-post-widget"">
                    <h4 class=""popular-title"">Yazarın en çok okunan makaleleri</h4>
                    <div class=""popular-post-list"">

");
#nullable restore
#line 92 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                         foreach (var article in Model.MostViewedArticles.Articles)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-post-list d-flex flex-row align-items-center\">\r\n                            <div class=\"thumb\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebd16699b06a44775937637069be22fc603939a924977", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ebd16699b06a44775937637069be22fc603939a925269", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5144, "~/img/", 5144, 6, true);
#nullable restore
#line 97 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
AddHtmlAttributeValue("", 5150, article.Thumbnail, 5150, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 97 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
AddHtmlAttributeValue("", 5175, article.Title, 5175, 14, false);

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
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-articleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                                                                                         WriteLiteral(article.Id);

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
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"details\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebd16699b06a44775937637069be22fc603939a929687", async() => {
                WriteLiteral("\r\n                                <h6>");
#nullable restore
#line 101 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                               Write(article.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-articleId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                                                                                         WriteLiteral(article.Id);

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
            WriteLiteral("\r\n                                <p>");
#nullable restore
#line 103 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                              Write(article.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 106 "C:\Users\Berkay Küçük\source\repos\ProgrammersBlog\ProgrammersBlog.Mvc\Views\User\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>                       \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- End course-details Area -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProgrammersBlog.Mvc.Models.UserDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
