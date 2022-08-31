#pragma checksum "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b460c4225a42f5ca3f37604af297aad0aa637e92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
#line 1 "D:\dotnet\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotnet\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b460c4225a42f5ca3f37604af297aad0aa637e92", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Blog düzenleme sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.HiddenFor(x=>x.BlogStatus));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.HiddenFor(x=>x.WriterID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.HiddenFor(x=>x.BlogCreateDate));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.HiddenFor(x => x.BlogID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Thumbnail Url"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 31 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 35 "D:\dotnet\CoreDemo\Views\Blog\EditBlog.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
