#pragma checksum "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d34fa72fb04fcc9706c07631eaac881747abb82d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ActorsRazorPages.Pages.Actors.Pages_Actors_Details), @"mvc.1.0.razor-page", @"/Pages/Actors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Actors/Details.cshtml", typeof(ActorsRazorPages.Pages.Actors.Pages_Actors_Details), null)]
namespace ActorsRazorPages.Pages.Actors
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d34fa72fb04fcc9706c07631eaac881747abb82d", @"/Pages/Actors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da096b675003cc25e9b1e554b1b419b77d778a40", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Actors_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Sample Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(96, 111, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Actor</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(208, 51, false);
#line 14 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Actor.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(259, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(300, 47, false);
#line 17 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Actor.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(347, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(388, 50, false);
#line 20 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Actor.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(438, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(479, 46, false);
#line 23 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Actor.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(525, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(566, 50, false);
#line 26 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Actor.KnownFor));

#line default
#line hidden
            EndContext();
            BeginContext(616, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(657, 46, false);
#line 29 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Actor.KnownFor));

#line default
#line hidden
            EndContext();
            BeginContext(703, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(744, 53, false);
#line 32 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Actor.OscarWinner));

#line default
#line hidden
            EndContext();
            BeginContext(797, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(838, 49, false);
#line 35 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Actor.OscarWinner));

#line default
#line hidden
            EndContext();
            BeginContext(887, 57, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    <div style=\"padding:10px;\">\n");
            EndContext();
#line 39 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml"
         if (Model.Actor.ImageName != "")
        {

#line default
#line hidden
            BeginContext(996, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1008, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "869b406910674d78bd21f2cc88b9b37a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1018, "~/images/", 1018, 9, true);
#line 41 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml"
AddHtmlAttributeValue("", 1027, Model.Actor.ImageName, 1027, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1085, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 42 "G:\Classes\20486D\Allfiles\Mod01\Labfiles\01_ActorsRazorPages_end\ActorsRazorPages\Pages\Actors\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1096, 28, true);
            WriteLiteral("    </div>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1124, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05521ae01be04cc98dd8893eea2f45d5", async() => {
                BeginContext(1146, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1162, 9, true);
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActorsRazorPages.Pages.Actors.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActorsRazorPages.Pages.Actors.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ActorsRazorPages.Pages.Actors.DetailsModel>)PageContext?.ViewData;
        public ActorsRazorPages.Pages.Actors.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
