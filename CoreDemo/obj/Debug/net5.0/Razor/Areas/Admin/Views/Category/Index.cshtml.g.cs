#pragma checksum "D:\dotnet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d718cd23927a75c2dc43c8a398d6785c7424bda4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "D:\dotnet\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotnet\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotnet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotnet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d718cd23927a75c2dc43c8a398d6785c7424bda4", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\dotnet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Kategori Listesi</h1>
<br />
<table class=""table table-bordered && table table-striped && table table-active"">
    <tr>
        <th>#</th>
        <th>Kategori Adı</th>
        <th>Pasif Yap</th>
        <th>Aktif Yap</th>
        <th>Düzenle</th>
    </tr>
");
#nullable restore
#line 20 "D:\dotnet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 23 "D:\dotnet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 24 "D:\dotnet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 620, "\"", 675, 3);
            WriteAttributeValue("", 627, "/Admin/Category/CategoryDelete/", 627, 31, true);
#nullable restore
#line 25 "D:\dotnet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 658, item.CategoryID, 658, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 674, "/", 674, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" id=""DeleteBtn"" onclick=""return confirm('Silmek istediğinize emin misiniz?');"" class=""btn btn-danger"">Pasif Yap</a></td>

            <td><a href=""#"" class=""btn btn-primary"">Aktif Yap</a></td>
            <td><a href=""#"" class=""btn btn-success"">Düzenle</a></td>
        </tr>
");
#nullable restore
#line 30 "D:\dotnet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Category/AddCategory/\" class=\"btn btn-warning\">Yeni Kategori</a>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 35 "D:\dotnet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
