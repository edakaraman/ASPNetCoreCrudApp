#pragma checksum "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72a19a1d23f389f206971edc448edc6cfd0509a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_StudentList), @"mvc.1.0.view", @"/Views/Student/StudentList.cshtml")]
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
#line 1 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72a19a1d23f389f206971edc448edc6cfd0509a4", @"/Views/Student/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml"
  
    ViewData["Title"] = "StudentList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 align=\"center\"> STUDENT LIST </h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th> </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.StudentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Classes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th> </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Classes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml"
           Write(Html.ActionLink("Update", "Create", new { item.ID, item.Name, item.StudentID, item.ClassID }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 48 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml"
           Write(Html.ActionLink("Delete", "DeleteStd", new { item.ID }, new { @class = "btn btn-danger", onclick = "return confirm('Are you sure you want to delete the recording?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\edaka\OneDrive\Masaüstü\WebBilirTask\CrudApp\Views\Student\StudentList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
