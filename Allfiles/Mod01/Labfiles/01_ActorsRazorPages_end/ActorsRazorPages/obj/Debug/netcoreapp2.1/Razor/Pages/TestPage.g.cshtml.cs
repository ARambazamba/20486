#pragma checksum "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\TestPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31ca87e10c74ca9139e480a8caece327792e580c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ActorsRazorPages.Pages.Pages_TestPage), @"mvc.1.0.razor-page", @"/Pages/TestPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/TestPage.cshtml", typeof(ActorsRazorPages.Pages.Pages_TestPage), null)]
namespace ActorsRazorPages.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\_ViewImports.cshtml"
using ActorsRazorPages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31ca87e10c74ca9139e480a8caece327792e580c", @"/Pages/TestPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da096b675003cc25e9b1e554b1b419b77d778a40", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TestPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\TestPage.cshtml"
  
    ViewData["Title"] = "TestPage";

#line default
#line hidden
            BeginContext(91, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(97, 17, false);
#line 7 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\TestPage.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(114, 36, true);
            WriteLiteral("</h1>\n<h2>This is a Test Page</h2>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActorsRazorPages.Pages.TestPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActorsRazorPages.Pages.TestPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActorsRazorPages.Pages.TestPageModel>)PageContext?.ViewData;
        public ActorsRazorPages.Pages.TestPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
