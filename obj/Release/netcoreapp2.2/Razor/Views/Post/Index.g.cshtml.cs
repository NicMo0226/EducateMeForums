#pragma checksum "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23ce42391dd11a73cd562906def65997798d7f5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
#line 1 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\_ViewImports.cshtml"
using EducateMeForums;

#line default
#line hidden
#line 2 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\_ViewImports.cshtml"
using EducateMeForums.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ce42391dd11a73cd562906def65997798d7f5d", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7fe930f9634434c23d79d46f2c9a5d3de99df89", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EducateMeForums.ViewModels.Post.PostIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-newReply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 152, true);
            WriteLiteral("<div class=\"container content\">\r\n    <div class=\"row postHeader\">\r\n        <div class=\"col-md-12\">\r\n            <span id=\"headingBtn\">\r\n                ");
            EndContext();
            BeginContext(207, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ce42391dd11a73cd562906def65997798d7f5d5976", async() => {
                BeginContext(298, 51, true);
                WriteLiteral("\r\n                    Back to\r\n                    ");
                EndContext();
                BeginContext(350, 15, false);
#line 8 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
               Write(Model.ForumName);

#line default
#line hidden
                EndContext();
                BeginContext(365, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 6 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                                                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(387, 184, true);
            WriteLiteral("\r\n            </span>\r\n            <div class=\"row\" id=\"postIndexContent\">\r\n                <div class=\"col-md-2 postAuthorContainer\">\r\n                    <div class=\"postAuthorImage\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 571, "\"", 624, 4);
            WriteAttributeValue("", 579, "background-image:", 579, 17, true);
            WriteAttributeValue(" ", 596, "url(", 597, 5, true);
#line 13 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
WriteAttributeValue("", 601, Model.AuthorImageUrl, 601, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 622, ");", 622, 2, true);
            EndWriteAttribute();
            BeginContext(625, 164, true);
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <span class=\"postData\">\r\n                        ");
            EndContext();
            BeginContext(789, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ce42391dd11a73cd562906def65997798d7f5d10086", async() => {
                BeginContext(869, 16, false);
#line 18 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                                                                                                  Write(Model.AuthorName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                                                                          WriteLiteral(Model.AuthorId);

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
            BeginContext(889, 57, true);
            WriteLiteral("\r\n                    </span>\r\n                    site: ");
            EndContext();
#line 20 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                           if (Model.IsAuthorAdmin)
                    {

#line default
#line hidden
            BeginContext(996, 68, true);
            WriteLiteral("                        <span class=\"isAdmin smaller\">Admin</span>\r\n");
            EndContext();
#line 23 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1087, 38, true);
            WriteLiteral("                    <br /> posted on: ");
            EndContext();
            BeginContext(1126, 13, false);
#line 24 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                                 Write(Model.Created);

#line default
#line hidden
            EndContext();
            BeginContext(1139, 194, true);
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <div class=\"col-md-6 postContentContainer\">\r\n                    <div class=\"postContent\">\r\n                        Title: ");
            EndContext();
            BeginContext(1334, 11, false);
#line 29 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                          Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1345, 41, true);
            WriteLiteral(" <br />\r\n                        posted: ");
            EndContext();
            BeginContext(1387, 27, false);
#line 30 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                           Write(Html.Raw(Model.PostContent));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 155, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\" id=\"replyDivider\"></div>\r\n        <hr>\r\n");
            EndContext();
#line 37 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(1625, 75, true);
            WriteLiteral("            <div class=\"row\">\r\n                <span>\r\n                    ");
            EndContext();
            BeginContext(1700, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ce42391dd11a73cd562906def65997798d7f5d15591", async() => {
                BeginContext(1796, 58, true);
                WriteLiteral("\r\n                        Post Reply\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1858, 47, true);
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n");
            EndContext();
#line 46 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1916, 40, true);
            WriteLiteral("        <hr>\r\n        <h4>Replies</h4>\r\n");
            EndContext();
#line 49 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
         if (Model.Replies.Any())
        {
            foreach (var reply in Model.Replies)
            {

#line default
#line hidden
            BeginContext(2067, 165, true);
            WriteLiteral("                <div class=\"row replyContent\">\r\n                    <div class=\"col-md-2 replyAuthorContainer\">\r\n                        <div class=\"postAuthorImage\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2232, "\"", 2285, 4);
            WriteAttributeValue("", 2240, "background-image:", 2240, 17, true);
            WriteAttributeValue(" ", 2257, "url(", 2258, 5, true);
#line 55 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
WriteAttributeValue("", 2262, reply.AuthorImageUrl, 2262, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 2283, ");", 2283, 2, true);
            EndWriteAttribute();
            BeginContext(2286, 131, true);
            WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n                        ");
            EndContext();
            BeginContext(2417, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ce42391dd11a73cd562906def65997798d7f5d19983", async() => {
                BeginContext(2496, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2527, 16, false);
#line 60 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                       Write(reply.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(2543, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                                                                          WriteLiteral(reply.AuthorId);

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
            BeginContext(2573, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 62 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                         if (reply.IsAuthorAdmin)
                        {

#line default
#line hidden
            BeginContext(2653, 112, true);
            WriteLiteral("                            <div class=\"isAdmin smaller\"> site Admin</div>\r\n                            <br />\r\n");
            EndContext();
#line 66 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2792, 47, true);
            WriteLiteral("\r\n                        <span>   Replied on: ");
            EndContext();
            BeginContext(2840, 13, false);
#line 68 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                                        Write(reply.Created);

#line default
#line hidden
            EndContext();
            BeginContext(2853, 193, true);
            WriteLiteral("</span>\r\n                    </div>\r\n\r\n                    <div class=\"col-md-6 replyContentContainer\">\r\n                        <div class=\"postContent\">\r\n                            Replied: ");
            EndContext();
            BeginContext(3047, 28, false);
#line 73 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
                                Write(Html.Raw(reply.ReplyContent));

#line default
#line hidden
            EndContext();
            BeginContext(3075, 86, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 77 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
            }
        }
        else
        {

#line default
#line hidden
            BeginContext(3212, 155, true);
            WriteLiteral("            <div class=\"noPosts\">\r\n                <h3>\r\n                    There are no replies to this post\r\n                </h3>\r\n            </div>\r\n");
            EndContext();
#line 86 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Post\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3378, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EducateMeForums.ViewModels.Post.PostIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
