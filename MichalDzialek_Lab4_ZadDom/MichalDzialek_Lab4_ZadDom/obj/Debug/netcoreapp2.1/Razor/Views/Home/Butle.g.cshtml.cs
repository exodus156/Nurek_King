#pragma checksum "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf2ceb293f605e8c3d5806caeaeb631a26d28df5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Butle), @"mvc.1.0.view", @"/Views/Home/Butle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Butle.cshtml", typeof(AspNetCore.Views_Home_Butle))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf2ceb293f605e8c3d5806caeaeb631a26d28df5", @"/Views/Home/Butle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae684f658f0ade45f7100de19078c1adc94d267c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Butle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ObjectTemplateModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
  
    ViewData["Title"] = "Butle";

#line default
#line hidden
            BeginContext(77, 44, true);
            WriteLiteral("<div class=\"row\" style=\"margin-top: 40px\">\r\n");
            EndContext();
#line 7 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
     foreach (var Butle in Model)
    {

#line default
#line hidden
            BeginContext(161, 274, true);
            WriteLiteral(@"<!--kolumna na karty-->
        <div class=""col s12 l4"">
            <div class=""card small"">
                <div class=""card-image waves-effect waves-block waves-dark"">
                    <!--Zdjęcie karty-->
                    <img class=""activator responsive-img""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 435, "\"", 466, 1);
#line 13 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
WriteAttributeValue("", 441, Url.Content(Butle.Photo), 441, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(467, 197, true);
            WriteLiteral(">\r\n                </div>\r\n                <!--Zawartość karty-->\r\n                <div class=\"card-content\">\r\n                    <span class=\"card-title activator deep-purple-text text-accent-4\">");
            EndContext();
            BeginContext(665, 10, false);
#line 17 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
                                                                                 Write(Butle.Name);

#line default
#line hidden
            EndContext();
            BeginContext(675, 161, true);
            WriteLiteral("<i class=\"material-icons right\">more_vert</i></span>\r\n                    <!--Ukryty input i przycisk submit do tego-->\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 836, "\"", 850, 1);
#line 19 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
WriteAttributeValue("", 841, Butle.ID, 841, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 851, "\"", 868, 1);
#line 19 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
WriteAttributeValue("", 859, Butle.ID, 859, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(869, 117, true);
            WriteLiteral(" />\r\n                    <button class=\"btn waves-effect waves-light deep-purple accent-4 center-align\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 986, "\"", 1017, 3);
            WriteAttributeValue("", 996, "proceed(\'", 996, 9, true);
#line 20 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
WriteAttributeValue("", 1005, Butle.ID, 1005, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1014, "\');", 1014, 3, true);
            EndWriteAttribute();
            BeginContext(1018, 231, true);
            WriteLiteral(">Więcej info</button>\r\n                </div>\r\n                <!--Zawartość karty po kliknięciu na zdjęcie-->\r\n                <div class=\"card-reveal\">\r\n                    <span class=\"card-title deep-purple-text text-accent-4\">");
            EndContext();
            BeginContext(1250, 10, false);
#line 24 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
                                                                       Write(Butle.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1260, 87, true);
            WriteLiteral("<i class=\"material-icons right\">close</i></span>\r\n                    <p><h5>Cena:</h5>");
            EndContext();
            BeginContext(1348, 11, false);
#line 25 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
                                Write(Butle.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1359, 42, true);
            WriteLiteral("</p>\r\n                    <p><h5>Typ:</h5>");
            EndContext();
            BeginContext(1402, 10, false);
#line 26 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
                               Write(Butle.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1412, 43, true);
            WriteLiteral("</p>\r\n                    <p><h5>Opis:</h5>");
            EndContext();
            BeginContext(1456, 17, false);
#line 27 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
                                Write(Butle.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1473, 66, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 31 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
    }

#line default
#line hidden
            BeginContext(1546, 525, true);
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
            BeginContext(2072, 27, false);
#line 55 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Butle.cshtml"
             Write(Url.Action("Butle", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 331, true);
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
