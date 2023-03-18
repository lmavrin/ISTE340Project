#pragma checksum "C:\Users\lukam\Desktop\Project3\Project3\Views\Home\EmploymentTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bed245b1be9ab0fe71464321f375bf6113e4841"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmploymentTable), @"mvc.1.0.view", @"/Views/Home/EmploymentTable.cshtml")]
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
#line 1 "C:\Users\lukam\Desktop\Project3\Project3\Views\_ViewImports.cshtml"
using Project3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lukam\Desktop\Project3\Project3\Views\_ViewImports.cshtml"
using Project3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bed245b1be9ab0fe71464321f375bf6113e4841", @"/Views/Home/EmploymentTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8892e2d58655ce37e7300b7883175dc3939288c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmploymentTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmploymentTableViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"">
    <h1>Welcome to the Employment Page</h1>
</div>
<div>
    <table id=""emp-table"" class=""display hidden"">
        <thead>
            <tr>
                <th>Employer</th>
                <th>Degree</th>
                <th>City</th>
                <th>Title</th>
                <th>Start Date</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "C:\Users\lukam\Desktop\Project3\Project3\Views\Home\EmploymentTable.cshtml"
             foreach (var employmentInfo in Model.employmentTable.professionalEmploymentInformation)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\lukam\Desktop\Project3\Project3\Views\Home\EmploymentTable.cshtml"
                   Write(employmentInfo.employer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\lukam\Desktop\Project3\Project3\Views\Home\EmploymentTable.cshtml"
                   Write(employmentInfo.degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\lukam\Desktop\Project3\Project3\Views\Home\EmploymentTable.cshtml"
                   Write(employmentInfo.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\lukam\Desktop\Project3\Project3\Views\Home\EmploymentTable.cshtml"
                   Write(employmentInfo.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\lukam\Desktop\Project3\Project3\Views\Home\EmploymentTable.cshtml"
                   Write(employmentInfo.startDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "C:\Users\lukam\Desktop\Project3\Project3\Views\Home\EmploymentTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#emp-table\').DataTable();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmploymentTableViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
