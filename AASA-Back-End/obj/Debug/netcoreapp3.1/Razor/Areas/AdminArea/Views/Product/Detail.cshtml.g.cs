#pragma checksum "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f21edaf27c9b37130b613b035a86ab53df4f0616"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Product_Detail), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\_ViewImports.cshtml"
using AASA_Back_End;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\_ViewImports.cshtml"
using AASA_Back_End.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\_ViewImports.cshtml"
using AASA_Back_End.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\_ViewImports.cshtml"
using AASA_Back_End.ViewModel.ProductViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f21edaf27c9b37130b613b035a86ab53df4f0616", @"/Areas/AdminArea/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84f269b8fec19838685b3c432555cd645e1d9c8", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminArea_Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/AdminArea/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid my-3 mx-3"">
    <div class=""table-responsive pt-3"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>
                       Image
                    </th>
                    <th>
                       Title
                    </th>
                    <th>
                        Price
                    </th>

                </tr>
            </thead>
            <tbody>

                <tr>
                    <td>
                        ");
#nullable restore
#line 29 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Product\Detail.cshtml"
                   Write(Model.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Product\Detail.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        350$\r\n                    </td>\r\n\r\n\r\n\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
