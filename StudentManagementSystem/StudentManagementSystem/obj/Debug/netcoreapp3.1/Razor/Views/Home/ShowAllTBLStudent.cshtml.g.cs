#pragma checksum "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bde0f2de53670d5298ed253988c5f810a4edbdc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowAllTBLStudent), @"mvc.1.0.view", @"/Views/Home/ShowAllTBLStudent.cshtml")]
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
#line 1 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\_ViewImports.cshtml"
using StudentManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\_ViewImports.cshtml"
using StudentManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde0f2de53670d5298ed253988c5f810a4edbdc2", @"/Views/Home/ShowAllTBLStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95827d18dd7c5be86a5638426966191d11063449", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ShowAllTBLStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentManagementSystem.Models.Tblstudent>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTBLStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrintTBLClassRoom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
  
    ViewData["Title"] = "ShowAllTBLStudent";
    Layout = "~/Views/Layout/UsingLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List of All Student</h1>\r\n\r\n<p>\r\n");
#nullable restore
#line 11 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
     using (Html.BeginForm("SearchByName", "Home", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"float-left mr-2\">\r\n            <label>Search By Name</label>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"float-left mr-2 mb-3\">\r\n            ");
#nullable restore
#line 18 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
       Write(Html.TextBox("SearchValue", "", htmlAttributes: new { @class = "form-control", @placeholder = "Enter key Search"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"float-left\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Search</button>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.IdSt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.NameSt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthdatSt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.AddressSt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.CreateDateSt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdSt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
           Write(Html.DisplayFor(modelItem => item.NameSt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
           Write(Html.DisplayFor(modelItem => item.BirthdatSt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
           Write(Html.DisplayFor(modelItem => item.AddressSt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreateDateSt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bde0f2de53670d5298ed253988c5f810a4edbdc210909", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
                                                   WriteLiteral(item.IdSt);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\ruchi\Desktop\DDU\SEM 5\WAD\Student Management System\StudentManagementSystem\StudentManagementSystem\Views\Home\ShowAllTBLStudent.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"mb-2 p-3\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bde0f2de53670d5298ed253988c5f810a4edbdc213504", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentManagementSystem.Models.Tblstudent>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
