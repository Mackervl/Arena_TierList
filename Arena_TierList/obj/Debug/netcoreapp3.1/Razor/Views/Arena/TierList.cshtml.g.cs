#pragma checksum "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e667d1708e7317965031facd3bf499297938311"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Arena_TierList), @"mvc.1.0.view", @"/Views/Arena/TierList.cshtml")]
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
#line 1 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\_ViewImports.cshtml"
using Arena_TierList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
using Arena_TierList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e667d1708e7317965031facd3bf499297938311", @"/Views/Arena/TierList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"373d5b6a14e3bcc782d74cd9432d1e379e1fb13b", @"/Views/_ViewImports.cshtml")]
    public class Views_Arena_TierList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnValueHelperModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/banner5.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
  
    ViewData["Title"] = "TierList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>TierList</h1>\r\n<div class=\"container-fluid banner\">\r\n   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e667d1708e7317965031facd3bf4992979383113799", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"container-fluid\" style=\"display:flex\">\r\n    <ul class=\"list-group\">\r\n");
#nullable restore
#line 14 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
         foreach (var vgc in Model.VeryGood)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item cardItem\">\r\n                <div class=\"cardName\">\r\n                    <a");
            BeginWriteAttribute("src", " src=\"", 453, "\"", 459, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"link\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
                   Write(vgc.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <span>\r\n                        <img style=\"width:120px;height:200px\"");
            BeginWriteAttribute("src", " src=\"", 600, "\"", 665, 2);
            WriteAttributeValue("", 606, "data:image/jpeg;base64,", 606, 23, true);
#nullable restore
#line 21 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
WriteAttributeValue("", 629, Convert.ToBase64String(vgc.Image), 629, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </span>\r\n                </a>\r\n            </div>\r\n            <div class=\"cardValue\">\r\n                ");
#nullable restore
#line 26 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
           Write(vgc.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </li>\r\n");
#nullable restore
#line 30 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n    <ul class=\"list-group\">\r\n");
#nullable restore
#line 34 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
         foreach (var vgc in Model.Good)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item cardItem\">\r\n                <div class=\"cardName\">\r\n                    <a");
            BeginWriteAttribute("src", " src=\"", 1059, "\"", 1065, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"link\">\r\n                        ");
#nullable restore
#line 39 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
                   Write(vgc.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span>\r\n                            <img style=\"width:120px;height:200px\"");
            BeginWriteAttribute("src", " src=\"", 1214, "\"", 1279, 2);
            WriteAttributeValue("", 1220, "data:image/jpeg;base64,", 1220, 23, true);
#nullable restore
#line 41 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
WriteAttributeValue("", 1243, Convert.ToBase64String(vgc.Image), 1243, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </span>\r\n                    </a>\r\n                </div>\r\n                <div class=\"cardValue\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
               Write(vgc.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </li>\r\n");
#nullable restore
#line 50 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n\r\n    <ul class=\"list-group\">\r\n");
#nullable restore
#line 55 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
         foreach (var vgc in Model.VeryMiddle)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item cardItem\">\r\n                <div class=\"cardName\">\r\n                    <a");
            BeginWriteAttribute("src", " src=\"", 1713, "\"", 1719, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"link\">\r\n                        ");
#nullable restore
#line 60 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
                   Write(vgc.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span>\r\n                            <img style=\"width:120px;height:200px\"");
            BeginWriteAttribute("src", " src=\"", 1868, "\"", 1933, 2);
            WriteAttributeValue("", 1874, "data:image/jpeg;base64,", 1874, 23, true);
#nullable restore
#line 62 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
WriteAttributeValue("", 1897, Convert.ToBase64String(vgc.Image), 1897, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </span>\r\n                    </a>\r\n                </div>\r\n                <div class=\"cardValue\">\r\n                    ");
#nullable restore
#line 67 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
               Write(vgc.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </li>\r\n");
#nullable restore
#line 71 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <ul class=\"list-group\">\r\n");
#nullable restore
#line 76 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
         foreach (var vgc in Model.Middle)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item cardItem\">\r\n                <div class=\"cardName\">\r\n                    <a");
            BeginWriteAttribute("src", " src=\"", 2363, "\"", 2369, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"link\">\r\n                        ");
#nullable restore
#line 81 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
                   Write(vgc.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span>\r\n                            <img style=\"width:120px;height:200px\"");
            BeginWriteAttribute("src", " src=\"", 2518, "\"", 2583, 2);
            WriteAttributeValue("", 2524, "data:image/jpeg;base64,", 2524, 23, true);
#nullable restore
#line 83 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
WriteAttributeValue("", 2547, Convert.ToBase64String(vgc.Image), 2547, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </span>\r\n                    </a>\r\n                </div>\r\n                <div class=\"cardValue\">\r\n                    ");
#nullable restore
#line 88 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
               Write(vgc.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </li>\r\n");
#nullable restore
#line 92 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <ul class=\"list-group\">\r\n");
#nullable restore
#line 95 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
         foreach (var vgc in Model.LessMiddle)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item cardItem\">\r\n                <div class=\"cardName\">\r\n                    <a");
            BeginWriteAttribute("src", " src=\"", 3013, "\"", 3019, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"link\">\r\n                        ");
#nullable restore
#line 100 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
                   Write(vgc.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span>\r\n                            <img style=\"width:120px;height:200px\"");
            BeginWriteAttribute("src", " src=\"", 3168, "\"", 3233, 2);
            WriteAttributeValue("", 3174, "data:image/jpeg;base64,", 3174, 23, true);
#nullable restore
#line 102 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
WriteAttributeValue("", 3197, Convert.ToBase64String(vgc.Image), 3197, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </span>\r\n                    </a>\r\n                </div>\r\n                <div class=\"cardValue\">\r\n                    ");
#nullable restore
#line 107 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
               Write(vgc.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </li>\r\n");
#nullable restore
#line 111 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <ul class=\"list-group\">\r\n");
#nullable restore
#line 115 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
         foreach (var vgc in Model.Bad)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item cardItem\">\r\n                <div class=\"cardName\">\r\n                    <a");
            BeginWriteAttribute("src", " src=\"", 3658, "\"", 3664, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"link\">\r\n                        ");
#nullable restore
#line 120 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
                   Write(vgc.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span>\r\n                            <img style=\"width:120px;height:200px\"");
            BeginWriteAttribute("src", " src=\"", 3813, "\"", 3878, 2);
            WriteAttributeValue("", 3819, "data:image/jpeg;base64,", 3819, 23, true);
#nullable restore
#line 122 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
WriteAttributeValue("", 3842, Convert.ToBase64String(vgc.Image), 3842, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </span>\r\n                    </a>\r\n                </div>\r\n                <div class=\"cardValue\">\r\n                    ");
#nullable restore
#line 127 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
               Write(vgc.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </li>\r\n");
#nullable restore
#line 131 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <ul class=\"list-group\">\r\n");
#nullable restore
#line 134 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
         foreach (var vgc in Model.LessBad)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item cardItem\">\r\n                <div class=\"cardName\">\r\n                    <a");
            BeginWriteAttribute("src", " src=\"", 4305, "\"", 4311, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"link\">\r\n                        ");
#nullable restore
#line 139 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
                   Write(vgc.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span>\r\n                            <img style=\"width:120px;height:200px\"");
            BeginWriteAttribute("src", " src=\"", 4460, "\"", 4525, 2);
            WriteAttributeValue("", 4466, "data:image/jpeg;base64,", 4466, 23, true);
#nullable restore
#line 141 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
WriteAttributeValue("", 4489, Convert.ToBase64String(vgc.Image), 4489, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </span>\r\n                    </a>\r\n                </div>\r\n                <div class=\"cardValue\">\r\n                    ");
#nullable restore
#line 146 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
               Write(vgc.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </li>\r\n");
#nullable restore
#line 150 "C:\Users\Артем\source\repos\Arena_TierList\Arena_TierList\Views\Arena\TierList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        <sript>\r\n\r\n            \r\n        </sript>\r\n\r\n    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnValueHelperModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
