#pragma checksum "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1d8bda73837f2d7a580a1094c2348935bd9abf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Detail), @"mvc.1.0.view", @"/Views/Profile/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Detail.cshtml", typeof(AspNetCore.Views_Profile_Detail))]
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
#line 1 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d8bda73837f2d7a580a1094c2348935bd9abf5", @"/Views/Profile/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7fe930f9634434c23d79d46f2c9a5d3de99df89", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EducateMeForums.ViewModels.ApplicationUser.ProfileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadProfileImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(177, 207, true);
            WriteLiteral("\r\n<div class=\"container content\">\r\n    <div class=\"row sectionHeader\">\r\n        <div class=\"col-md-7 borderProfile\">\r\n            <h4 class=\"sectionHeader\">\r\n                User Profile\r\n            </h4>\r\n");
            EndContext();
#line 12 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
             if (User.IsInRole("Admin"))
            {
                //<button>Deactivate User</button>
            }

#line default
#line hidden
            BeginContext(508, 113, true);
            WriteLiteral("            <hr>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-5\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 621, "\"", 649, 1);
#line 19 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
WriteAttributeValue("", 627, Model.ProfileImageUrl, 627, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(650, 38, true);
            WriteLiteral(" width=\"150\" id=\"userProfileImage\" >\r\n");
            EndContext();
#line 20 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                     if (User.Identity.Name == Model.UserName)
                    {

#line default
#line hidden
            BeginContext(775, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(799, 615, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1d8bda73837f2d7a580a1094c2348935bd9abf56586", async() => {
                BeginContext(906, 501, true);
                WriteLiteral(@"
                            <div id=""upload"">
                                <label class=""btn btn-default btn-file"">
                                    Browse <input type=""file"" name=""file"" style=""display: none"" />
                                 
                                </label>
                                <button type=""submit"" id=""btn-profile"" class=""btn btn-default"">Submit</button>
                            </div>
                           
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1414, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(1439, 106, true);
            WriteLiteral("                </div>\r\n\r\n                <div class=\"col-md-5\">\r\n                    <span id=\"userName\">");
            EndContext();
            BeginContext(1546, 14, false);
#line 36 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                   Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1560, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 37 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                     if (@Model.IsAdmin)
                    {

#line default
#line hidden
            BeginContext(1634, 60, true);
            WriteLiteral("                        <span class=\"isAdmin\">Admin</span>\r\n");
            EndContext();
#line 40 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(1717, 58, true);
            WriteLiteral("                    <span id=\"userRating\">Current Rating: ");
            EndContext();
            BeginContext(1776, 16, false);
#line 41 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                                     Write(Model.UserRating);

#line default
#line hidden
            EndContext();
            BeginContext(1792, 88, true);
            WriteLiteral("</span><br />\r\n                    <hr>\r\n                    <span id=\"userEmail\">Name: ");
            EndContext();
            BeginContext(1881, 15, false);
#line 43 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                          Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1896, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1898, 14, false);
#line 43 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                                           Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1912, 88, true);
            WriteLiteral("</span><br />\r\n                    <hr>\r\n                    <span id=\"userEmail\">Name: ");
            EndContext();
            BeginContext(2001, 35, false);
#line 45 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                          Write(Model.BirthDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2036, 96, true);
            WriteLiteral("</span><br />\r\n                    <hr>\r\n                    <span id=\"userSince\">Member Since: ");
            EndContext();
            BeginContext(2133, 17, false);
#line 47 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                                  Write(Model.MemberSince);

#line default
#line hidden
            EndContext();
            BeginContext(2150, 211, true);
            WriteLiteral("</span><br />\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 intro\">\r\n                    <hr>\r\n                    <span id=\"userIntroduction\">");
            EndContext();
            BeginContext(2362, 18, false);
#line 53 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                           Write(Model.Introduction);

#line default
#line hidden
            EndContext();
            BeginContext(2380, 275, true);
            WriteLiteral(@"</span><br /><br />
                </div>
            </div>
        </div>

        <div class=""col-md-4 borderProfile portfolio"">
            <div class=""portfolio"">
                <h4>Portfolio</h4>
                <hr>
                <span id=""profile"">Town: ");
            EndContext();
            BeginContext(2656, 10, false);
#line 62 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                    Write(Model.Town);

#line default
#line hidden
            EndContext();
            BeginContext(2666, 94, true);
            WriteLiteral("</span><br />\r\n                <hr>\r\n                <span id=\"profile\">Country of residence: ");
            EndContext();
            BeginContext(2761, 13, false);
#line 64 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                                    Write(Model.Country);

#line default
#line hidden
            EndContext();
            BeginContext(2774, 102, true);
            WriteLiteral("</span><br />\r\n                <hr>\r\n                <span id=\"profile\">Highest level of achievement: ");
            EndContext();
            BeginContext(2877, 24, false);
#line 66 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                                            Write(Model.HighestAchievement);

#line default
#line hidden
            EndContext();
            BeginContext(2901, 81, true);
            WriteLiteral("</span><br />\r\n                <hr>\r\n                <span id=\"profile\">Subject: ");
            EndContext();
            BeginContext(2983, 13, false);
#line 68 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                       Write(Model.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(2996, 93, true);
            WriteLiteral("</span><br />\r\n                <hr>\r\n                <span id=\"profile\">Date of Achievement: ");
            EndContext();
            BeginContext(3090, 38, false);
#line 70 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                                   Write(Model.AchievedWhen.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3128, 93, true);
            WriteLiteral("</span><br />\r\n                <hr>\r\n                <span id=\"profile\">Academic Insitution: ");
            EndContext();
            BeginContext(3222, 25, false);
#line 72 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                                   Write(Model.AcademicInstitution);

#line default
#line hidden
            EndContext();
            BeginContext(3247, 81, true);
            WriteLiteral("</span><br />\r\n                <hr>\r\n                <span id=\"profile\">Website: ");
            EndContext();
            BeginContext(3329, 13, false);
#line 74 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                       Write(Model.Website);

#line default
#line hidden
            EndContext();
            BeginContext(3342, 420, true);
            WriteLiteral(@"</span><br />
                <hr>
            </div>
        </div>
    </div>

    <div class=""row  aboveWallpost"">
        <div class=""col-md-12 borderProfile"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""wall"">
                        <h4>Wall Posts</h4>
                        <hr>
                        <span id=""wallPost"">Wall Post Title: ");
            EndContext();
            BeginContext(3763, 19, false);
#line 87 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                                        Write(Model.WallPostTitle);

#line default
#line hidden
            EndContext();
            BeginContext(3782, 82, true);
            WriteLiteral("</span><br /><hr>\r\n                        <span id=\"wallPost\">Wall Post Content: ");
            EndContext();
            BeginContext(3865, 25, false);
#line 88 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                                          Write(Model.WallPostBodyContent);

#line default
#line hidden
            EndContext();
            BeginContext(3890, 73, true);
            WriteLiteral("</span><br />  <hr>\r\n                        <span id=\"wallPost\">Posted: ");
            EndContext();
            BeginContext(3964, 12, false);
#line 89 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Detail.cshtml"
                                               Write(Model.Posted);

#line default
#line hidden
            EndContext();
            BeginContext(3976, 562, true);
            WriteLiteral(@"</span><br />  <hr>

                    </div>
                </div>
            </div>
            <div class=""row "">
                <div class=""col-md-10 col-md-offset-1"">
                    <div class=""container belowComments"">
                        <h6>Comments</h6>
                   

                    </div>
                </div>
            </div>
            <div class=""row "">
                <div class=""col-md-10 col-md-offset-1 belowComments"">
                </div>
            </div>
        </div>
    </div>
</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<EducateMeForums.Models.ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EducateMeForums.ViewModels.ApplicationUser.ProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
