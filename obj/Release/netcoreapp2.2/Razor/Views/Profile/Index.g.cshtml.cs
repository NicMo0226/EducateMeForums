#pragma checksum "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6453589c34ea7a3548b67aa2eae2c6d049ff169a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Index.cshtml", typeof(AspNetCore.Views_Profile_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6453589c34ea7a3548b67aa2eae2c6d049ff169a", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7fe930f9634434c23d79d46f2c9a5d3de99df89", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EducateMeForums.ViewModels.ApplicationUser.ProfileListingModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 637, true);
            WriteLiteral(@"<div class=""container content"">
    <div class=""row sectionHeader"">
        <div class=""col-md-12"">
            <div class=""sectionHeading"">Browser Users</div>
        </div>
        <div class=""row"" id=""forumIndexContent"">
            <table class=""table table-hover"" id=""userIndexTable"">
                <thead>
                    <tr>
                        <th>Image</th>
                        <th>Username</th>
                        <th>Email</th>
                        <th>Member Since</th>
                        <th>Rating</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 19 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Index.cshtml"
                     foreach (var profile in Model.Profiles)
                    {

#line default
#line hidden
            BeginContext(793, 184, true);
            WriteLiteral("                        <tr class=\"userRow\">\r\n                            <td>\r\n                                <div class=\"userProfileImage\">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 977, "\"", 1007, 1);
#line 24 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Index.cshtml"
WriteAttributeValue("", 983, profile.ProfileImageUrl, 983, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1008, 158, true);
            WriteLiteral(" width=\"150\" />\r\n                                </div>\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1167, 16, false);
#line 28 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Index.cshtml"
                           Write(profile.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1183, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1287, 13, false);
#line 31 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Index.cshtml"
                           Write(profile.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1300, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1404, 19, false);
#line 34 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Index.cshtml"
                           Write(profile.MemberSince);

#line default
#line hidden
            EndContext();
            BeginContext(1423, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1527, 18, false);
#line 37 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Index.cshtml"
                           Write(profile.UserRating);

#line default
#line hidden
            EndContext();
            BeginContext(1545, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\Nicola\Documents\Visual Studio 2017\EducateMeForums\EducateMeForums\Views\Profile\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1636, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EducateMeForums.ViewModels.ApplicationUser.ProfileListingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
