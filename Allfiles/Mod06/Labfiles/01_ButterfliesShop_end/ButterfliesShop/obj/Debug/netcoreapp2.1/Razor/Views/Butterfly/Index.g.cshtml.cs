#pragma checksum "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4059d02a2832806cd83da9a66d346df83d73f9f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Butterfly_Index), @"mvc.1.0.view", @"/Views/Butterfly/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Butterfly/Index.cshtml", typeof(AspNetCore.Views_Butterfly_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4059d02a2832806cd83da9a66d346df83d73f9f8", @"/Views/Butterfly/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Butterfly_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ButterfliesShop.Models.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/butterflies-shop-styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(70, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(95, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c01c6e692f6344c49190db2089db3709", async() => {
                BeginContext(101, 88, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Index</title>\n    ");
                EndContext();
                BeginContext(189, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73171fa927624cb59c05f5e4e65bbef2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(271, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(279, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(280, 2524, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28857d1653f041deb1b5151f45a913b4", async() => {
                BeginContext(286, 257, true);
                WriteLiteral(@"
    <div class=""container"">
        <h1 class=""main-title"">Butterflies Shop</h1>
        <p class=""into"">Welcome to our Web Store, Enjoy a Wide Variety of Butterflies</p>
        <p class=""into"">Our Butterflies in the Shop</p>
        <button type=""button""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 543, "\"", 603, 3);
                WriteAttributeValue("", 553, "location.href=\'", 553, 15, true);
#line 20 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
WriteAttributeValue("", 568, Url.Action("Create", "Butterfly"), 568, 34, false);

#line default
#line hidden
                WriteAttributeValue("", 602, "\'", 602, 1, true);
                EndWriteAttribute();
                BeginContext(604, 61, true);
                WriteLiteral(">Add Butteflies</button>\n        <div class=\"img-container\">\n");
                EndContext();
#line 22 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
             foreach (var item in Model.Butterflies)
            {

#line default
#line hidden
                BeginContext(732, 127, true);
                WriteLiteral("                <div class=\"photo-index-card\">\n                    <h3 class=\"display-picture-title\">\n                        \"");
                EndContext();
                BeginContext(860, 45, false);
#line 26 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
                    Write(Html.DisplayFor(modelItem => item.CommonName));

#line default
#line hidden
                EndContext();
                BeginContext(905, 28, true);
                WriteLiteral("\"\n                    </h3>\n");
                EndContext();
#line 28 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
                     if (item.ImageName != null)
                    {

#line default
#line hidden
                BeginContext(1004, 110, true);
                WriteLiteral("                        <div class=\"photo-display\">\n                            <img class=\"photo-display-img\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1114, "\"", 1178, 1);
#line 31 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
WriteAttributeValue("", 1120, Url.Action("GetImage", "Butterfly", new { Id = item.Id }), 1120, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1179, 35, true);
                WriteLiteral(" />\n                        </div>\n");
                EndContext();
#line 33 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1236, 104, true);
                WriteLiteral("                    <div>\n                        <p class=\"display-label\">\n                            ");
                EndContext();
                BeginContext(1341, 50, false);
#line 36 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
                       Write(Html.DisplayNameFor(model => item.ButterflyFamily));

#line default
#line hidden
                EndContext();
                BeginContext(1391, 139, true);
                WriteLiteral("\n                        </p>\n                        <br />\n                        <p class=\"display-field\">\n                            ");
                EndContext();
                BeginContext(1531, 46, false);
#line 40 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
                       Write(Html.DisplayFor(model => item.ButterflyFamily));

#line default
#line hidden
                EndContext();
                BeginContext(1577, 182, true);
                WriteLiteral("\n                        </p>\n                    </div>\n                    <div class=\"display-info\">\n                        <p class=\"display-label\">\n                            ");
                EndContext();
                BeginContext(1760, 50, false);
#line 45 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
                       Write(Html.DisplayNameFor(model => item.Characteristics));

#line default
#line hidden
                EndContext();
                BeginContext(1810, 108, true);
                WriteLiteral("\n                        </p>\n                        <p class=\"display-field\">\n                            ");
                EndContext();
                BeginContext(1919, 46, false);
#line 48 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
                       Write(Html.DisplayFor(model => item.Characteristics));

#line default
#line hidden
                EndContext();
                BeginContext(1965, 161, true);
                WriteLiteral("\n                        </p>\n                    </div>\n                    <div>\n                        <p class=\"display-label\">\n                            ");
                EndContext();
                BeginContext(2127, 43, false);
#line 53 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
                       Write(Html.DisplayNameFor(model => item.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(2170, 108, true);
                WriteLiteral("\n                        </p>\n                        <p class=\"display-field\">\n                            ");
                EndContext();
                BeginContext(2279, 39, false);
#line 56 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
                       Write(Html.DisplayFor(model => item.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(2318, 161, true);
                WriteLiteral("\n                        </p>\n                    </div>\n                    <div>\n                        <p class=\"display-label\">\n                            ");
                EndContext();
                BeginContext(2480, 46, false);
#line 61 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
                       Write(Html.DisplayNameFor(model => item.CreatedDate));

#line default
#line hidden
                EndContext();
                BeginContext(2526, 108, true);
                WriteLiteral("\n                        </p>\n                        <p class=\"display-field\">\n                            ");
                EndContext();
                BeginContext(2635, 42, false);
#line 64 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
                       Write(Html.DisplayFor(model => item.CreatedDate));

#line default
#line hidden
                EndContext();
                BeginContext(2677, 80, true);
                WriteLiteral("\n                        </p>\n                    </div>\n                </div>\n");
                EndContext();
#line 68 "G:\Classes\20486D\Allfiles\Mod06\Labfiles\01_ButterfliesShop_end\ButterfliesShop\Views\Butterfly\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2771, 26, true);
                WriteLiteral("        </div>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2804, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ButterfliesShop.Models.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
