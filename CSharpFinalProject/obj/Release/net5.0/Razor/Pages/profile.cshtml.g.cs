#pragma checksum "C:\Users\hani\Desktop\C# final project\CSharpFinalProject\Pages\profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452d679e05161ba3935f28e8584e72c167044c2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CSharpFinalProject.Pages.Pages_profile), @"mvc.1.0.razor-page", @"/Pages/profile.cshtml")]
namespace CSharpFinalProject.Pages
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
#line 1 "C:\Users\hani\Desktop\C# final project\CSharpFinalProject\Pages\_ViewImports.cshtml"
using CSharpFinalProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452d679e05161ba3935f28e8584e72c167044c2a", @"/Pages/profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb958f71bd73bf47d593cc50259704fe9406f94a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hani\Desktop\C# final project\CSharpFinalProject\Pages\profile.cshtml"
  
    Layout = "_UserLogoutLayout";
    ViewData["Title"] = "profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""container-fluid profile-container"">
    <div class=""row d-flex justify-content-center"">
        <div class=""col-md-10 mt-5 pt-5"">
            <div class=""row z-depth-3"">
                <div class=""col-sm-4 bg-info rounded-left"">
                    <div class=""card-block text-center text-white"">
                        <i class=""fas fa-user-tie fa-7x mt-5""></i>
                        <h2 class=""font-weight-bold mt-4"">Welcome ");
#nullable restore
#line 18 "C:\Users\hani\Desktop\C# final project\CSharpFinalProject\Pages\profile.cshtml"
                                                             Write(Model.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

                    </div>
                </div>
                <div class=""col-sm-8 rounded-right"">
                    <h3 class=""mt-3 text-center"">Information</h3>
                    <hr class=""badge-primary mt-0 w-25"" />
                    <h4>Date: ");
#nullable restore
#line 25 "C:\Users\hani\Desktop\C# final project\CSharpFinalProject\Pages\profile.cshtml"
                         Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-sm-6\">\r\n\r\n                            <p class=\"font-weight-bold\">Email:</p>\r\n                            <h5>");
#nullable restore
#line 30 "C:\Users\hani\Desktop\C# final project\CSharpFinalProject\Pages\profile.cshtml"
                           Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                        <div class=\"col-sm-6\">\r\n                            <p class=\"font-weight-bold\">Phone:</p>\r\n                            <h5>");
#nullable restore
#line 34 "C:\Users\hani\Desktop\C# final project\CSharpFinalProject\Pages\profile.cshtml"
                           Write(Model.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSharpFinalProject.Pages.profileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpFinalProject.Pages.profileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpFinalProject.Pages.profileModel>)PageContext?.ViewData;
        public CSharpFinalProject.Pages.profileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
