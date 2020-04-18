#pragma checksum "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f01033f49e2feb2471c84fd770ccdd5a8693a2b5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f01033f49e2feb2471c84fd770ccdd5a8693a2b5", @"/Views/Series/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04e4ef5dc386889744bd18b711593dcd57e5c5cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Series_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieMark.Models.SeriesViewModels.SeriesDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
Write(Model.Serie.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"accordion\"");
            BeginWriteAttribute("id", " id=\"", 211, "\"", 243, 2);
            WriteAttributeValue("", 216, "accordion-", 216, 10, true);
#nullable restore
#line 10 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
WriteAttributeValue("", 226, Model.Serie.Id, 226, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 11 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
     foreach (var temporada in Model.Serie.ListaTemporada)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\"", 378, "\"", 406, 2);
            WriteAttributeValue("", 383, "heading-", 383, 8, true);
#nullable restore
#line 14 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
WriteAttributeValue("", 391, temporada.Id, 391, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h2 class=\"mb-0\">\r\n                    <button class=\"btn btn-link collapsed\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse-");
#nullable restore
#line 16 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
                                                                                                                   Write(temporada.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 602, "\"", 642, 2);
            WriteAttributeValue("", 618, "collapse-", 618, 9, true);
#nullable restore
#line 16 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
WriteAttributeValue("", 627, temporada.Id, 627, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 17 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
                   Write(temporada.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </button>\r\n                </h2>\r\n            </div>\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 777, "\"", 806, 2);
            WriteAttributeValue("", 782, "collapse-", 782, 9, true);
#nullable restore
#line 21 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
WriteAttributeValue("", 791, temporada.Id, 791, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 824, "\"", 865, 2);
            WriteAttributeValue("", 842, "heading-", 842, 8, true);
#nullable restore
#line 21 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
WriteAttributeValue("", 850, temporada.Id, 850, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordion-");
#nullable restore
#line 21 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
                                                                                                                              Write(Model.Serie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <div class=\"card-body\">\r\n");
#nullable restore
#line 23 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
                     for (int i = 0; i < temporada.ListaEpisodio.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Episódio ");
#nullable restore
#line 25 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
                                Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 25 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
                                          Write(temporada.ListaEpisodio[i].Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 26 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\www\movie-mark\src\MovieMark\Views\Series\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieMark.Models.SeriesViewModels.SeriesDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
