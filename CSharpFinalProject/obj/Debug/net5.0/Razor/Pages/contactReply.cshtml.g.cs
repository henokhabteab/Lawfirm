#pragma checksum "C:\Users\hani\Desktop\Prep for github\Henok_Weldeslasie_C#\CSharpFinalProject\Pages\contactReply.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29f6a46530340572361ac198aa441d390762f69f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CSharpFinalProject.Pages.Pages_contactReply), @"mvc.1.0.razor-page", @"/Pages/contactReply.cshtml")]
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
#line 1 "C:\Users\hani\Desktop\Prep for github\Henok_Weldeslasie_C#\CSharpFinalProject\Pages\_ViewImports.cshtml"
using CSharpFinalProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29f6a46530340572361ac198aa441d390762f69f", @"/Pages/contactReply.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb958f71bd73bf47d593cc50259704fe9406f94a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_contactReply : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hani\Desktop\Prep for github\Henok_Weldeslasie_C#\CSharpFinalProject\Pages\contactReply.cshtml"
  
    ViewData["Title"] = "contactReplay";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"contact-reply\">\r\n    <h2>Thank you ");
#nullable restore
#line 8 "C:\Users\hani\Desktop\Prep for github\Henok_Weldeslasie_C#\CSharpFinalProject\Pages\contactReply.cshtml"
             Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h4>Date: ");
#nullable restore
#line 9 "C:\Users\hani\Desktop\Prep for github\Henok_Weldeslasie_C#\CSharpFinalProject\Pages\contactReply.cshtml"
         Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <p>We just recieved your email. we will contact you as soon as possible.</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSharpFinalProject.Pages.contactReplyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpFinalProject.Pages.contactReplyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CSharpFinalProject.Pages.contactReplyModel>)PageContext?.ViewData;
        public CSharpFinalProject.Pages.contactReplyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
