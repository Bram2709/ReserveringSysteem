#pragma checksum "C:\Users\Beheerder\Documents\Fontys\S2\Applicaties\ReserveringsApp\ReserveringsApp\Views\Home\MedewerkerPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e06617b5b909470f40a5cbf634943e9567dd298"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MedewerkerPage), @"mvc.1.0.view", @"/Views/Home/MedewerkerPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MedewerkerPage.cshtml", typeof(AspNetCore.Views_Home_MedewerkerPage))]
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
#line 1 "C:\Users\Beheerder\Documents\Fontys\S2\Applicaties\ReserveringsApp\ReserveringsApp\Views\_ViewImports.cshtml"
using ReserveringsApp;

#line default
#line hidden
#line 2 "C:\Users\Beheerder\Documents\Fontys\S2\Applicaties\ReserveringsApp\ReserveringsApp\Views\_ViewImports.cshtml"
using ReserveringsApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e06617b5b909470f40a5cbf634943e9567dd298", @"/Views/Home/MedewerkerPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c08b140c75dd3d41cb01b6b9dc0719817e21d9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MedewerkerPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Bomenpark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "bistroLouis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Bar15", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("typeof", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Beheerder\Documents\Fontys\S2\Applicaties\ReserveringsApp\ReserveringsApp\Views\Home\MedewerkerPage.cshtml"
  
    ViewData["Title"] = "Medewerker info page";


#line default
#line hidden
            BeginContext(58, 265, true);
            WriteLiteral(@"
<div class=""tab"">
    <button class=""tablinks"" onclick=""openCity(event, 'reserveringGegevens')"">Gegevens</button>
    <button class=""tablinks"" onclick=""openCity(event, 'reserveringsGegevensCompact')"">Gegevens2</button>
    <select name=""Restaurants"">
        ");
            EndContext();
            BeginContext(323, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36298d6ed6c14a548ae2ede70768d3de", async() => {
                BeginContext(349, 9, true);
                WriteLiteral("Bomenpark");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(367, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(377, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "016f55bc553c4f61b8aeaeeba366ad1b", async() => {
                BeginContext(405, 19, true);
                WriteLiteral("<B></B>Bistro Louis");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(433, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(443, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bea4fa825b5e4ccca15eca60fc836ef0", async() => {
                BeginContext(465, 5, true);
                WriteLiteral("Bar15");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(479, 4683, true);
            WriteLiteral(@"
    </select>
</div>




<script>

    function openCity(evt, cityName) {
        // Declare all variables
        var i, tabcontent, tablinks;

        // Get all elements with class=""tabcontent"" and hide them
        tabcontent = document.getElementsByClassName(""tabcontent"");
        for (i = 0; i < tabcontent.length; i++) {
            tabcontent[i].style.display = ""none"";
        }

        // Get all elements with class=""tablinks"" and remove the class ""active""
        tablinks = document.getElementsByClassName(""tablinks"");
        for (i = 0; i < tablinks.length; i++) {
            tablinks[i].className = tablinks[i].className.replace("" active"", """");
        }

        // Show the current tab, and add an ""active"" class to the button that opened the tab
        document.getElementById(cityName).style.display = ""block"";
        evt.currentTarget.className += "" active"";
    }
</script>

<div id=""reserveringGegevens"" class=""tabcontent"">
    <table>

        <thead>
       ");
            WriteLiteral(@"     <tr class=""table100-head"">
                <th class=""column1"">ID</th>
                <th class=""column2"">Naam</th>
                <th class=""column3"">TelefoonNr</th>
                <th class=""column4"">Datum</th>
                <th class=""column5"">AantalPersonen</th>
                <th class=""column6"">Opmerking</th>
            </tr>
        </thead>

        <tbody>
            <tr>
                <td class=""column1"">1</td>
                <td class=""column2"">Bram van de Wetering</td>
                <td class=""column3"">0629394959</td>
                <td class=""column4"">9/10/2019</td>
                <td class=""column5"">4</td>
                <td class=""column6"">dit is een test</td>
            </tr>
            <tr>
                <td class=""column1"">1</td>
                <td class=""column2"">Bram van de Wetering</td>
                <td class=""column3"">0629394959</td>
                <td class=""column4"">9/10/2019</td>
                <td class=""column5"">4</td>
        ");
            WriteLiteral(@"        <td class=""column6"">dit is een test</td>
            </tr>
            <tr>
                <td class=""column1"">1</td>
                <td class=""column2"">Bram van de Wetering</td>
                <td class=""column3"">0629394959</td>
                <td class=""column4"">9/10/2019</td>
                <td class=""column5"">4</td>
                <td class=""column6"">dit is een test</td>
            </tr>
            <tr>
                <td class=""column1"">1</td>
                <td class=""column2"">Bram van de Wetering</td>
                <td class=""column3"">0629394959</td>
                <td class=""column4"">9/10/2019</td>
                <td class=""column5"">4</td>
                <td class=""column6"">dit is een test</td>
            </tr>
            <tr>
                <td class=""column1"">1</td>
                <td class=""column2"">Bram van de Wetering</td>
                <td class=""column3"">0629394959</td>
                <td class=""column4"">9/10/2019</td>
                <td cla");
            WriteLiteral(@"ss=""column5"">4</td>
                <td class=""column6"">dit is een test</td>
            </tr>
            <tr>
                <td class=""column1"">1</td>
                <td class=""column2"">Bram van de Wetering</td>
                <td class=""column3"">0629394959</td>
                <td class=""column4"">9/10/2019</td>
                <td class=""column5"">4</td>
                <td class=""column6"">dit is een test</td>

            </tr>
            <tr>
                <td class=""column1"">1</td>
                <td class=""column2"">Bram van de Wetering</td>
                <td class=""column3"">0629394959</td>
                <td class=""column4"">9/10/2019</td>
                <td class=""column5"">4</td>
                <td class=""column6"">dit is een test</td>
            </tr>
            <tr>
                <td class=""column1"">1</td>
                <td class=""column2"">Bram van de Wetering</td>
                <td class=""column3"">0629394959</td>
                <td class=""column4"">9/10/201");
            WriteLiteral(@"9</td>
                <td class=""column5"">4</td>
                <td class=""column6"">dit is een test</td>
            </tr>
            <tr>
                <td class=""column1"">1</td>
                <td class=""column2"">Bram van de Wetering</td>
                <td class=""column3"">0629394959</td>
                <td class=""column4"">9/10/2019</td>
                <td class=""column5"">4</td>
                <td class=""column6"">dit is een test</td>
            </tr>

        </tbody>
    </table>
</div>

<div id=""reserveringsGegevensCompact"" class=""tabcontent"">
    ");
            EndContext();
            BeginContext(5162, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "776b5eb4a8124776a91f77864adddc47", async() => {
                BeginContext(5182, 141, true);
                WriteLiteral("\r\n        <p>\r\n            Aantal personen: <input type=\"number\" />\r\n            <input type=\"submit\" value=\"Bevestig\" />\r\n        </p>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5330, 1175, true);
            WriteLiteral(@"

    <table>
        <thead>
            <tr class=""table100-head"">
                <th class=""column1"">Tafel voor zoveel persoenen</th>
                <th class=""column2"">Hoeveelheid tafels</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td class=""column1"">1</td>
                <td class=""column2"">2</td>
            </tr>
            <tr>
                <td class=""column1"">2</td>
                <td class=""column2"">6</td>
            </tr>
            <tr>
                <td class=""column1"">3</td>
                <td class=""column2"">2</td>
            </tr>
            <tr>
                <td class=""column1"">4</td>
                <td class=""column2"">7</td>
            </tr>
            <tr>
                <td class=""column1"">5</td>
                <td class=""column2"">3</td>
            </tr>
            <tr>
                <td class=""column1"">6</td>
                <td class=""column2"">2</td>
            </tr>
            <tr");
            WriteLiteral(">\r\n                <td class=\"column1\">10</td>\r\n                <td class=\"column2\">1</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
