#pragma checksum "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "779599c9f97a8858cc842221a1de932b4c49ca0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Automaty), @"mvc.1.0.view", @"/Views/Home/Automaty.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Automaty.cshtml", typeof(AspNetCore.Views_Home_Automaty))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"779599c9f97a8858cc842221a1de932b4c49ca0f", @"/Views/Home/Automaty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae684f658f0ade45f7100de19078c1adc94d267c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Automaty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ObjectTemplateModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
  
    ViewData["Title"] = "Automaty";

#line default
#line hidden
            BeginContext(80, 44, true);
            WriteLiteral("<div class=\"row\" style=\"margin-top: 40px\">\r\n");
            EndContext();
#line 7 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
 foreach (var Automat in Model)
{

#line default
#line hidden
            BeginContext(158, 257, true);
            WriteLiteral(@"   <!--kolumna na karty-->
    <div class=""col s12 l4"">
        <div class=""card small"">
            <div class=""card-image waves-effect waves-block waves-dark"">
                <!--Zdjęcie karty-->
                <img class=""activator responsive-img""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 415, "\"", 448, 1);
#line 13 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
WriteAttributeValue("", 421, Url.Content(Automat.Photo), 421, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(449, 181, true);
            WriteLiteral(">\r\n            </div>\r\n            <!--Zawartość karty-->\r\n            <div class=\"card-content\">\r\n                <span class=\"card-title activator deep-purple-text text-accent-4\">");
            EndContext();
            BeginContext(631, 12, false);
#line 17 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
                                                                             Write(Automat.Name);

#line default
#line hidden
            EndContext();
            BeginContext(643, 153, true);
            WriteLiteral("<i class=\"material-icons right\">more_vert</i></span>\r\n                <!--Ukryty input i przycisk submit do tego-->\r\n                <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 796, "\"", 812, 1);
#line 19 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
WriteAttributeValue("", 801, Automat.ID, 801, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 813, "\"", 832, 1);
#line 19 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
WriteAttributeValue("", 821, Automat.ID, 821, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(833, 113, true);
            WriteLiteral(" />\r\n                <button class=\"btn waves-effect waves-light deep-purple accent-4 center-align\" type=\"submit\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 946, "\"", 979, 3);
            WriteAttributeValue("", 956, "proceed(\'", 956, 9, true);
#line 20 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
WriteAttributeValue("", 965, Automat.ID, 965, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 976, "\');", 976, 3, true);
            EndWriteAttribute();
            BeginContext(980, 215, true);
            WriteLiteral(">Więcej info</button>\r\n            </div>\r\n            <!--Zawartość karty po kliknięciu na zdjęcie-->\r\n            <div class=\"card-reveal\">\r\n                <span class=\"card-title deep-purple-text text-accent-4\">");
            EndContext();
            BeginContext(1196, 12, false);
#line 24 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
                                                                   Write(Automat.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1208, 83, true);
            WriteLiteral("<i class=\"material-icons right\">close</i></span>\r\n                <p><h5>Cena:</h5>");
            EndContext();
            BeginContext(1292, 13, false);
#line 25 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
                            Write(Automat.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1305, 38, true);
            WriteLiteral("</p>\r\n                <p><h5>Typ:</h5>");
            EndContext();
            BeginContext(1344, 12, false);
#line 26 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
                           Write(Automat.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1356, 39, true);
            WriteLiteral("</p>\r\n                <p><h5>Opis:</h5>");
            EndContext();
            BeginContext(1396, 19, false);
#line 27 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
                            Write(Automat.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1415, 54, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 31 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
}

#line default
#line hidden
            BeginContext(1472, 525, true);
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
            BeginContext(1998, 30, false);
#line 55 "C:\Users\Michał\Desktop\MichalDzialekLab4_ZadDom\MichalDzialek_Lab4_ZadDom\MichalDzialek_Lab4_ZadDom\Views\Home\Automaty.cshtml"
             Write(Url.Action("Automaty", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 339, true);
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
</script>



");
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
