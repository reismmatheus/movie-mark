#pragma checksum "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d32c9a70fd694d95be11818430cfb5e2c796801b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Series_Details), @"mvc.1.0.view", @"/Views/Series/Details.cshtml")]
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
#nullable restore
#line 1 "C:\www\movie-mark\src\MovieMark\Views\_ViewImports.cshtml"
using MovieMark;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\www\movie-mark\src\MovieMark\Views\_ViewImports.cshtml"
using MovieMark.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d32c9a70fd694d95be11818430cfb5e2c796801b", @"/Views/Series/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04e4ef5dc386889744bd18b711593dcd57e5c5cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Series_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Título da Série</h1>

<div class=""accordion"" id=""accordionExample"">
    <div class=""card"">
        <div class=""card-header"" id=""headingOne"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""false"" aria-controls=""collapseOne"">
                    1ª Temporada - Um belo título
                </button>
            </h2>
        </div>

        <div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
            <div class=""card-body"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 807, "\"", 815, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""defaultCheck1"">
                    <label class=""form-check-label"" for=""defaultCheck1"">
                        Episódio 1
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 1111, "\"", 1119, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""defaultCheck1"">
                    <label class=""form-check-label"" for=""defaultCheck1"">
                        Episódio 2
                    </label>
                </div>
            </div>
        </div>
    </div>
    <div class=""card"">
        <div class=""card-header"" id=""headingTwo"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                    2ª Temporada - Um belo título ataca novamente
                </button>
            </h2>
        </div>
        <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
            <div class=""card-body"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 2016, "\"", 2024, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""defaultCheck1"">
                    <label class=""form-check-label"" for=""defaultCheck1"">
                        Episódio 1
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 2320, "\"", 2328, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""defaultCheck1"">
                    <label class=""form-check-label"" for=""defaultCheck1"">
                        Episódio 2
                    </label>
                </div>
            </div>
        </div>
    </div>
    <div class=""card"">
        <div class=""card-header"" id=""headingThree"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                    3ª Temporada - O título Final
                </button>
            </h2>
        </div>
        <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordionExample"">
            <div class=""card-body"">
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 3219, "\"", 3227, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""defaultCheck1"">
                    <label class=""form-check-label"" for=""defaultCheck1"">
                        Episódio 1
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 3523, "\"", 3531, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"defaultCheck1\">\r\n                    <label class=\"form-check-label\" for=\"defaultCheck1\">\r\n                        Episódio 2\r\n                    </label>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
