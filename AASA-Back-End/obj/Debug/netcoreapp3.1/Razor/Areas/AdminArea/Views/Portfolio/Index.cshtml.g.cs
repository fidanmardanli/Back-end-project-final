#pragma checksum "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22cc166e9daee8808f7cfecbece39958b7c76fbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_Portfolio_Index), @"mvc.1.0.view", @"/Areas/AdminArea/Views/Portfolio/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22cc166e9daee8808f7cfecbece39958b7c76fbf", @"/Areas/AdminArea/Views/Portfolio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e79068a4bdbed982b286c0879c5d129c2147d47b", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_AdminArea_Views_Portfolio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portfolio>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AdminArea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Portfolio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid my-3 mx-3\">\r\n    <div class=\"table-responsive pt-3\">\r\n        <div class=\"create-btn\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22cc166e9daee8808f7cfecbece39958b7c76fbf4877", async() => {
                WriteLiteral(" <i class=\"mdi mdi-new-box\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>
                        #
                    </th>
                     <th>
                        Type
                    </th>
                    <th>
                        Image
                    </th>
                    <th>
                        Title
                    </th>
                    <th>
                        Settings
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        1
                    </td>
                    <td>
                        Nebula
                    </td>
                    <td>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22cc166e9daee8808f7cfecbece39958b7c76fbf7294", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1137, "~/assets/img/", 1137, 13, true);
#nullable restore
#line 41 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 1150, Model.ImageFirst, 1150, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                      ");
#nullable restore
#line 44 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
                 Write(Model.TitleFirst);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info"">  <i class=""mdi mdi-information""></i></button>
                        <button type=""button"" class=""btn btn-primary"">  <i class=""mdi mdi-table-edit""></i></button>
                        <button type=""button"" class=""btn btn-danger""><i class=""mdi mdi-delete""></i></button>
                    </td>
                </tr>
                <tr>
                    <td>
                        2
                    </td>
                    <td>
                        Nebula
                    </td>
                    <td>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22cc166e9daee8808f7cfecbece39958b7c76fbf9815", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1959, "~/assets/img/", 1959, 13, true);
#nullable restore
#line 60 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 1972, Model.ImageThird, 1972, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
                   Write(Model.TitleThird);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info"">  <i class=""mdi mdi-information""></i></button>
                        <button type=""button"" class=""btn btn-primary"">  <i class=""mdi mdi-table-edit""></i></button>
                        <button type=""button"" class=""btn btn-danger""><i class=""mdi mdi-delete""></i></button>
                    </td>
                </tr>
                <tr>
                    <td>
                        3
                    </td>
                    <td>
                        Nebula
                    </td>
                    <td>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22cc166e9daee8808f7cfecbece39958b7c76fbf12340", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2783, "~/assets/img/", 2783, 13, true);
#nullable restore
#line 79 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 2796, Model.ImageSixth, 2796, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
                   Write(Model.TitleSixth);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info"">  <i class=""mdi mdi-information""></i></button>
                        <button type=""button"" class=""btn btn-primary"">  <i class=""mdi mdi-table-edit""></i></button>
                        <button type=""button"" class=""btn btn-danger""><i class=""mdi mdi-delete""></i></button>
                    </td>
                </tr>
                <tr>
                    <td>
                        4
                    </td>
                    <td>
                        Moon
                    </td>
                    <td>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22cc166e9daee8808f7cfecbece39958b7c76fbf14864", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3605, "~/assets/img/", 3605, 13, true);
#nullable restore
#line 98 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 3618, Model.ImageSecond, 3618, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 101 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
                   Write(Model.TitleSecond);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info"">  <i class=""mdi mdi-information""></i></button>
                        <button type=""button"" class=""btn btn-primary"">  <i class=""mdi mdi-table-edit""></i></button>
                        <button type=""button"" class=""btn btn-danger""><i class=""mdi mdi-delete""></i></button>
                    </td>
                </tr>
                <tr>
                    <td>
                        5
                    </td>
                    <td>
                        Moon
                    </td>
                    <td>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22cc166e9daee8808f7cfecbece39958b7c76fbf17391", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4429, "~/assets/img/", 4429, 13, true);
#nullable restore
#line 117 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 4442, Model.ImageFifth, 4442, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 120 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
                   Write(Model.TitleFifth);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info"">  <i class=""mdi mdi-information""></i></button>
                        <button type=""button"" class=""btn btn-primary"">  <i class=""mdi mdi-table-edit""></i></button>
                        <button type=""button"" class=""btn btn-danger""><i class=""mdi mdi-delete""></i></button>
                    </td>
                </tr>
                <tr>
                    <td>
                        6
                    </td>
                    <td>
                        Moon
                    </td>
                    <td>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22cc166e9daee8808f7cfecbece39958b7c76fbf19917", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5251, "~/assets/img/", 5251, 13, true);
#nullable restore
#line 136 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 5264, Model.ImageNinth, 5264, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 139 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
                   Write(Model.TitleNinth);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info"">  <i class=""mdi mdi-information""></i></button>
                        <button type=""button"" class=""btn btn-primary"">  <i class=""mdi mdi-table-edit""></i></button>
                        <button type=""button"" class=""btn btn-danger""><i class=""mdi mdi-delete""></i></button>
                    </td>
                </tr>
                <tr>
                    <td>
                        7
                    </td>
                    <td>
                        Earth
                    </td>
                    <td>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22cc166e9daee8808f7cfecbece39958b7c76fbf22444", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6074, "~/assets/img/", 6074, 13, true);
#nullable restore
#line 155 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 6087, Model.ImageFourth, 6087, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 158 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
                   Write(Model.TitleFourth);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info"">  <i class=""mdi mdi-information""></i></button>
                        <button type=""button"" class=""btn btn-primary"">  <i class=""mdi mdi-table-edit""></i></button>
                        <button type=""button"" class=""btn btn-danger""><i class=""mdi mdi-delete""></i></button>
                    </td>
                </tr>
                <tr>
                    <td>
                        8
                    </td>
                    <td>
                        Earth
                    </td>
                    <td>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22cc166e9daee8808f7cfecbece39958b7c76fbf24973", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6899, "~/assets/img/", 6899, 13, true);
#nullable restore
#line 174 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 6912, Model.ImageSeventh, 6912, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 177 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
                   Write(Model.TitleSeventh);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info"">  <i class=""mdi mdi-information""></i></button>
                        <button type=""button"" class=""btn btn-primary"">  <i class=""mdi mdi-table-edit""></i></button>
                        <button type=""button"" class=""btn btn-danger""><i class=""mdi mdi-delete""></i></button>
                    </td>
                </tr>
                <tr>
                    <td>
                        9
                    </td>
                    <td>
                        Earth
                    </td>
                    <td>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22cc166e9daee8808f7cfecbece39958b7c76fbf27504", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7726, "~/assets/img/", 7726, 13, true);
#nullable restore
#line 193 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
AddHtmlAttributeValue("", 7739, Model.ImageEighth, 7739, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 196 "C:\Users\marda\Desktop\Back\AASA-Back-End\Areas\AdminArea\Views\Portfolio\Index.cshtml"
                   Write(Model.TitleEighth);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info"">  <i class=""mdi mdi-information""></i></button>
                        <button type=""button"" class=""btn btn-primary"">  <i class=""mdi mdi-table-edit""></i></button>
                        <button type=""button"" class=""btn btn-danger""><i class=""mdi mdi-delete""></i></button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
