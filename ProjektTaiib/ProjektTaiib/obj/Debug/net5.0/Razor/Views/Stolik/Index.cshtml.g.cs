#pragma checksum "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e681fe7a3b8c76fce34e7dc7fb5ef647b74fc3f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stolik_Index), @"mvc.1.0.view", @"/Views/Stolik/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e681fe7a3b8c76fce34e7dc7fb5ef647b74fc3f9", @"/Views/Stolik/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8366fe63c486dfd84dcb90f44e4f956d8ff78c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Stolik_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjektTaiib.ViewModels.StolikiMS>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \n");
#nullable restore
#line 3 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"
     using (Html.BeginForm("Index", "Stolik", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<label>Który stolik zajmujemy/zwalniamy:</label>\n        <input type=\"number\" id=\"id\" name=\"idt\" value=\"1\">\n        <input type=\"submit\">\n");
#nullable restore
#line 8 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \n");
#nullable restore
#line 11 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"
     using (Html.BeginForm("Index", "Stolik", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<label>  Ile miejsc szukamy:</label>\n        <input type=\"number\" id=\"idIleMiejsc\" name=\"idIleMiejsc\"");
            BeginWriteAttribute("value", " value=\"", 433, "\"", 465, 1);
#nullable restore
#line 14 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"
WriteAttributeValue("", 441, Model.PodanaIloscMiejsc, 441, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <input type=\"submit\">\n");
#nullable restore
#line 16 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\n        <thead>\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 22 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Stoliki.First().id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 25 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Stoliki.First().ileMiejsc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 28 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Stoliki.First().czyZajety));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 33 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"
             foreach (var item in Model.Stoliki)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 37 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n\n                    <td>\n                        ");
#nullable restore
#line 41 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ileMiejsc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 44 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.czyZajety));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n\n                </tr>\n");
#nullable restore
#line 48 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n\n    Ilość wolnych stolików: ");
#nullable restore
#line 52 "C:\Users\Michal\Desktop\Projekt\RestauracjaProjekt-main\ProjektTaiib\ProjektTaiib\Views\Stolik\Index.cshtml"
                       Write(Model.iloscWolnychStolikow);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjektTaiib.ViewModels.StolikiMS> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
