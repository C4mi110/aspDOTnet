#pragma checksum "C:\Users\Admin\source\repos\MvcEx1\MvcEx1\Views\Products\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be87f26d3739d436e7a53c5b6b3f21b223f668f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_index), @"mvc.1.0.view", @"/Views/Products/index.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\MvcEx1\MvcEx1\Views\_ViewImports.cshtml"
using MvcEx1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\MvcEx1\MvcEx1\Views\_ViewImports.cshtml"
using MvcEx1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be87f26d3739d436e7a53c5b6b3f21b223f668f3", @"/Views/Products/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0706e25b9ed271c1f4d68180f10f0888190eb34c", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\source\repos\MvcEx1\MvcEx1\Views\Products\index.cshtml"
  
	ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Products</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Admin\source\repos\MvcEx1\MvcEx1\Views\Products\index.cshtml"
 foreach (var p in @Model)
{
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\MvcEx1\MvcEx1\Views\Products\index.cshtml"
Write(p.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\source\repos\MvcEx1\MvcEx1\Views\Products\index.cshtml"
Write(p.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\source\repos\MvcEx1\MvcEx1\Views\Products\index.cshtml"
Write(p.Price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\source\repos\MvcEx1\MvcEx1\Views\Products\index.cshtml"
            
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
