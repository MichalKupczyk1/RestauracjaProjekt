#pragma checksum "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e092a209e16dcf642869e598e3a49570a11d6c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Placenie_Index), @"mvc.1.0.view", @"/Views/Placenie/Index.cshtml")]
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
#line 1 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\_ViewImports.cshtml"
using ProjektTaiib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\_ViewImports.cshtml"
using ProjektTaiib.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e092a209e16dcf642869e598e3a49570a11d6c1", @"/Views/Placenie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8366fe63c486dfd84dcb90f44e4f956d8ff78c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Placenie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjektTaiib.ViewModels.PlacenieMS>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml"
 using (Html.BeginForm("Index", "Placenie", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"number\" id=\"IdStolika\" name=\"IdStolika\" placeholder=\"id stolika\">\n    <input type=\"submit\">\n");
#nullable restore
#line 8 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <thead>

        <tr>
            <th>
                Id Zamowienia
            </th>
            <th>
                nazwa dania
            </th>
            <th>
                rodzaj dania
            </th>
            <th>
                cena
            </th>
        </tr>
    </thead>


    <tbody>
");
#nullable restore
#line 31 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml"
         if (Model.Zamowienia.Count() != 0)
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml"
             foreach (var item in Model.Zamowienia)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 36 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n\n                    <td>\n                        ");
#nullable restore
#line 40 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.nazwaDania));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 43 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.rodzajDania));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 46 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.cena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n\n                </tr>\n");
#nullable restore
#line 50 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </tbody>\n</table>\n<label>Suma do zapłaty:  ");
#nullable restore
#line 55 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml"
                    Write(Model.Suma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n\n");
#nullable restore
#line 57 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml"
 using (Html.BeginForm("Index", "Placenie", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"number\" id=\"IdUsuwanie\" name=\"IdUsuwanie\" placeholder=\"id usuwania\">\n    <input type=\"submit\">\n");
#nullable restore
#line 61 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Placenie\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjektTaiib.ViewModels.PlacenieMS> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
