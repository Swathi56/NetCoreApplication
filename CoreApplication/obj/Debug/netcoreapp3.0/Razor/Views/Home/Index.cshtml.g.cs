#pragma checksum "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85d8db2a7234fcd480852582eaa00a7c68a76e48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\_ViewImports.cshtml"
using CoreApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
using CoreApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85d8db2a7234fcd480852582eaa00a7c68a76e48", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e310b9187167501f1b65764b597aab6fdccabea1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Page>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>tinymce.init({ selector: \'textarea\' });</script>\r\n\r\n<div class=\"text-center\">\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-8\" style=\"height:350px;overflow-x:auto;width:700px;\">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
             foreach (var content in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div>\r\n                        <h1>");
#nullable restore
#line 18 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
                       Write(content.pageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1><br />\r\n                        \r\n                        <ul> \r\n                            <li>\r\n                                ");
#nullable restore
#line 22 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
                           Write(Html.Raw(System.Net.WebUtility.HtmlDecode(content.bodyText)));

#line default
#line hidden
#nullable disable
            WriteLiteral("                              \r\n                            </li>\r\n                        </ul>                         \r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 27 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
               
                foreach (var subcontent in content.subcontent)
                {
                   
                    if (subcontent.contentType == "wysiwyg")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul><li><textarea id=\"richtext\">\r\n                        <p> ");
#nullable restore
#line 34 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
                       Write(subcontent.richText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </textarea></li></ul>                        \r\n                        <br />\r\n");
#nullable restore
#line 37 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
                    }
                    else if (subcontent.contentType == "image")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <ul><li><img");
            BeginWriteAttribute("src", " src=\"", 1398, "\"", 1438, 1);
#nullable restore
#line 40 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 1404, Url.Content(subcontent.imagePath), 1404, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></li></ul> \r\n                       <br />\r\n");
#nullable restore
#line 42 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
                    }
                    else if (subcontent.contentType == "blockquote")

                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul><li>\r\n                            <blockquote>\r\n                           <p> Quote:   ");
#nullable restore
#line 48 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
                                   Write(subcontent.quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                           <p>QuoteSource:  ");
#nullable restore
#line 49 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
                                       Write(subcontent.quoteSource);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </blockquote>\r\n                        </li></ul>\r\n");
#nullable restore
#line 52 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"

                    }                    
                    else if(subcontent.contentType == "link")                   
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul>\r\n                            <li>\r\n                        \r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2169, "\"", 2209, 1);
#nullable restore
#line 59 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 2176, Url.Content(subcontent.linkHref), 2176, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 59 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
                                                                        Write(subcontent.linkTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>  \r\n                            </li>\r\n                        </ul>\r\n");
#nullable restore
#line 62 "C:\Users\sgadiparthi\Documents\CoreApplication\CoreApplication\Views\Home\Index.cshtml"
                     }                       
           

                }
            
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Page>> Html { get; private set; }
    }
}
#pragma warning restore 1591
