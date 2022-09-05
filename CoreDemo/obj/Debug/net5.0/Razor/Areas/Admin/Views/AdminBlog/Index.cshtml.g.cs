#pragma checksum "D:\dotnet\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aed9991b0e8bee8b96e877f9441fe51d4f107d1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminBlog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminBlog/Index.cshtml")]
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
#line 1 "D:\dotnet\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aed9991b0e8bee8b96e877f9441fe51d4f107d1a", @"/Areas/Admin/Views/AdminBlog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminBlog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\dotnet\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aed9991b0e8bee8b96e877f9441fe51d4f107d1a3535", async() => {
                WriteLiteral("\r\n            <div class=\"wrapper wrapper-content animated fadeInRight\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 13 "D:\dotnet\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                     foreach (var item in Model)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-md-3\">\r\n                        <div class=\"ibox\">\r\n                            <div class=\"ibox-content product-box\">\r\n\r\n                                <div>\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 594, "\"", 615, 1);
#nullable restore
#line 21 "D:\dotnet\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 600, item.BlogImage, 600, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" height=""225"" width=""359"" />
                                </div>
                                
                                <div class=""product-desc"">
                                    <span class=""product-price"">
                                        ");
#nullable restore
#line 26 "D:\dotnet\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                    Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </span>\r\n                                    <small class=\"text-muted\">");
#nullable restore
#line 28 "D:\dotnet\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                         Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                    <a href=\"#\" class=\"product-name\"> ");
#nullable restore
#line 29 "D:\dotnet\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                                 Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                    <div class=\"small m-t-xs\">\r\n                                        ");
#nullable restore
#line 31 "D:\dotnet\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                   Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 100).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
                WriteLiteral("...\r\n                                    </div>\r\n                                    <div class=\"m-t text-righ\">\r\n\r\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 1526, "\"", 1563, 2);
                WriteAttributeValue("", 1533, "/Blog/BlogReadAll/", 1533, 18, true);
#nullable restore
#line 35 "D:\dotnet\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 1551, item.BlogID, 1551, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-xs btn-outline btn-primary"">Detaylar <i class=""fa fa-long-arrow-right""></i> </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 41 "D:\dotnet\CoreDemo\Areas\Admin\Views\AdminBlog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591