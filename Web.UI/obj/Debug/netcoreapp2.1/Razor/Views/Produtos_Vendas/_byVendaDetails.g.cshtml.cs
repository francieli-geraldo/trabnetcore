#pragma checksum "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ecf08eb9ea04406568ae40a164f7ab670ccf33b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Vendas__byVendaDetails), @"mvc.1.0.view", @"/Views/Produtos_Vendas/_byVendaDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos_Vendas/_byVendaDetails.cshtml", typeof(AspNetCore.Views_Produtos_Vendas__byVendaDetails))]
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
#line 1 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Web.UI;

#line default
#line hidden
#line 3 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Web.UI.Models;

#line default
#line hidden
#line 4 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Web.UI.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Web.UI.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ecf08eb9ea04406568ae40a164f7ab670ccf33b", @"/Views/Produtos_Vendas/_byVendaDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916cdad7c8602f1298d29c870924a9ecbec6da80", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Vendas__byVendaDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Produto_VendaVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 61, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(99, 48, false);
#line 6 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Produto.Name));

#line default
#line hidden
            EndContext();
            BeginContext(147, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(191, 53, false);
#line 9 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantidadeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(244, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(288, 49, false);
#line 12 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorUnitario));

#line default
#line hidden
            EndContext();
            BeginContext(337, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(381, 41, false);
#line 15 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(422, 30, true);
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 19 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaDetails.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(493, 36, true);
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(530, 47, false);
#line 23 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaDetails.cshtml"
       Write(Html.DisplayFor(modelItem => item.Produto.Name));

#line default
#line hidden
            EndContext();
            BeginContext(577, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(621, 52, false);
#line 26 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaDetails.cshtml"
       Write(Html.DisplayFor(modelItem => item.QuantidadeProduto));

#line default
#line hidden
            EndContext();
            BeginContext(673, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(717, 48, false);
#line 29 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaDetails.cshtml"
       Write(Html.DisplayFor(modelItem => item.ValorUnitario));

#line default
#line hidden
            EndContext();
            BeginContext(765, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(809, 40, false);
#line 32 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaDetails.cshtml"
       Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(849, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Produtos_Vendas\_byVendaDetails.cshtml"
    }

#line default
#line hidden
            BeginContext(884, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Produto_VendaVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
