#pragma checksum "/Users/sefa.yilmaz/Desktop/CRUD/CRUD-.Net-Core/Crud.WebUI/Views/Home/GetNote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "216794611dc71b0fdb2483c4da35057e35179216"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetNote), @"mvc.1.0.view", @"/Views/Home/GetNote.cshtml")]
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
#line 1 "/Users/sefa.yilmaz/Desktop/CRUD/CRUD-.Net-Core/Crud.WebUI/Views/_ViewImports.cshtml"
using Crud.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sefa.yilmaz/Desktop/CRUD/CRUD-.Net-Core/Crud.WebUI/Views/_ViewImports.cshtml"
using Crud.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"216794611dc71b0fdb2483c4da35057e35179216", @"/Views/Home/GetNote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b1139d7565af1bc5b245adab0e6d74f8915fc62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetNote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Crud.Entities.Notes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/sefa.yilmaz/Desktop/CRUD/CRUD-.Net-Core/Crud.WebUI/Views/Home/GetNote.cshtml"
   Layout = "/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"col-md-10 mt-2\">\r\n    <p>Update Note</p>\r\n    <hr />\r\n    <form action=\"/Home/Update\" method=\"post\">\r\n\r\n        <div class=\"form group row\">\r\n            <div class=\"col-md-6\">\r\n                <input name=\"ID\" id=\"ID\"");
            BeginWriteAttribute("value", " value=\"", 311, "\"", 328, 1);
#nullable restore
#line 13 "/Users/sefa.yilmaz/Desktop/CRUD/CRUD-.Net-Core/Crud.WebUI/Views/Home/GetNote.cshtml"
WriteAttributeValue("", 319, Model.ID, 319, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" readonly=true class=\"form-control\" />\r\n                <input name=\"Note\" id=\"Note\" required=true");
            BeginWriteAttribute("value", " value=\"", 427, "\"", 446, 1);
#nullable restore
#line 14 "/Users/sefa.yilmaz/Desktop/CRUD/CRUD-.Net-Core/Crud.WebUI/Views/Home/GetNote.cshtml"
WriteAttributeValue("", 435, Model.Note, 435, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control mt-1\" />\r\n                ");
#nullable restore
#line 15 "/Users/sefa.yilmaz/Desktop/CRUD/CRUD-.Net-Core/Crud.WebUI/Views/Home/GetNote.cshtml"
           Write(Html.ValidationMessageFor(x => x.Note, "This field cannot be empty", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <button type=\"submit\" class=\"btn btn-primary mt-1\">Save Note</button>\r\n        </div>\r\n\r\n    </form>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Crud.Entities.Notes> Html { get; private set; }
    }
}
#pragma warning restore 1591
