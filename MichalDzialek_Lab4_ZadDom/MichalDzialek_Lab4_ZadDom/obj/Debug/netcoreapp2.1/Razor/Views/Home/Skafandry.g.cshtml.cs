#pragma checksum "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbeb642337f685f89caf8fdaa98ede6c7b6f264a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Skafandry), @"mvc.1.0.view", @"/Views/Home/Skafandry.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Skafandry.cshtml", typeof(AspNetCore.Views_Home_Skafandry))]
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
#line 1 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\_ViewImports.cshtml"
using MichalDzialek_Lab4_ZadDom;

#line default
#line hidden
#line 2 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\_ViewImports.cshtml"
using MichalDzialek_Lab4_ZadDom.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbeb642337f685f89caf8fdaa98ede6c7b6f264a", @"/Views/Home/Skafandry.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae684f658f0ade45f7100de19078c1adc94d267c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Skafandry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ObjectTemplateModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
  
    ViewData["Title"] = "Skafandry";

#line default
#line hidden
            BeginContext(81, 44, true);
            WriteLiteral("<div class=\"row\" style=\"margin-top: 40px\">\r\n");
            EndContext();
#line 7 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
     foreach (var Skafandry in Model)
    {

#line default
#line hidden
            BeginContext(169, 274, true);
            WriteLiteral(@"<!--kolumna na karty-->
        <div class=""col s12 l4"">
            <div class=""card small"">
                <div class=""card-image waves-effect waves-block waves-dark"">
                    <!--Zdjęcie karty-->
                    <img class=""activator responsive-img""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 443, "\"", 478, 1);
#line 13 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
WriteAttributeValue("", 449, Url.Content(Skafandry.Photo), 449, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(479, 197, true);
            WriteLiteral(">\r\n                </div>\r\n                <!--Zawartość karty-->\r\n                <div class=\"card-content\">\r\n                    <span class=\"card-title activator deep-purple-text text-accent-4\">");
            EndContext();
            BeginContext(677, 14, false);
#line 17 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
                                                                                 Write(Skafandry.Name);

#line default
#line hidden
            EndContext();
            BeginContext(691, 161, true);
            WriteLiteral("<i class=\"material-icons right\">more_vert</i></span>\r\n                    <!--Ukryty input i przycisk submit do tego-->\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 852, "\"", 870, 1);
#line 19 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
WriteAttributeValue("", 857, Skafandry.ID, 857, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 871, "\"", 892, 1);
#line 19 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
WriteAttributeValue("", 879, Skafandry.ID, 879, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(893, 117, true);
            WriteLiteral(" />\r\n                    <button class=\"btn waves-effect waves-light deep-purple accent-4 center-align\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1010, "\"", 1045, 3);
            WriteAttributeValue("", 1020, "proceed(\'", 1020, 9, true);
#line 20 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
WriteAttributeValue("", 1029, Skafandry.ID, 1029, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1042, "\');", 1042, 3, true);
            EndWriteAttribute();
            BeginContext(1046, 231, true);
            WriteLiteral(">Więcej info</button>\r\n                </div>\r\n                <!--Zawartość karty po kliknięciu na zdjęcie-->\r\n                <div class=\"card-reveal\">\r\n                    <span class=\"card-title deep-purple-text text-accent-4\">");
            EndContext();
            BeginContext(1278, 14, false);
#line 24 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
                                                                       Write(Skafandry.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1292, 87, true);
            WriteLiteral("<i class=\"material-icons right\">close</i></span>\r\n                    <p><h5>Cena:</h5>");
            EndContext();
            BeginContext(1380, 15, false);
#line 25 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
                                Write(Skafandry.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1395, 42, true);
            WriteLiteral("</p>\r\n                    <p><h5>Typ:</h5>");
            EndContext();
            BeginContext(1438, 14, false);
#line 26 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
                               Write(Skafandry.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1452, 43, true);
            WriteLiteral("</p>\r\n                    <p><h5>Opis:</h5>");
            EndContext();
            BeginContext(1496, 21, false);
#line 27 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
                                Write(Skafandry.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1517, 66, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 31 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
    }

#line default
#line hidden
            BeginContext(1590, 525, true);
            WriteLiteral(@"</div>

<script>
    //Włączenie przesyłu danych używając AJAX
    function proceed(id) {
        var target = ""#"" + id

        //Targetuje id przycisku, które jest dynamiczne
        var ID = $(target).val();

        //Zmienia go na format jaki znajduje się w IdModel.cs
        var obj = {
            IdPrzycisku: ID
        }

        //aktywuje funkcję Submit
        Submit(obj);
    }

    //Sam AJAX
    function Submit(obj) {
        $.ajax({
            //Namierza stronę
            url: '");
            EndContext();
            BeginContext(2116, 31, false);
#line 55 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Skafandry.cshtml"
             Write(Url.Action("Skafandry", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(2147, 331, true);
            WriteLiteral(@"',
            //Typ zapytania
            type: 'POST',
            //Dane przesłane
            data: obj,
            //Bierze odpowiedź z serwera, która jest kodem z ViewModel i wkleja ją do dokumentu
            success: function (res) {
                document.write(res);
            }
        })
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ObjectTemplateModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
