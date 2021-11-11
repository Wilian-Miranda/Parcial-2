#pragma checksum "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Enrollment\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef8285602e3162e1966d83f1afe796177aa2aa17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enrollment_Details), @"mvc.1.0.view", @"/Views/Enrollment/Details.cshtml")]
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
#line 1 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\_ViewImports.cshtml"
using Escuela.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef8285602e3162e1966d83f1afe796177aa2aa17", @"/Views/Enrollment/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad1daf75ad34d7efa7ede8e232fbd89a93ea7bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Enrollment_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Escuela.Dominio.Tbl_Enrollment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Enrollment\Details.cshtml"
  
    ViewData["Title"] = "Enrollment";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style type=""text/css"">
    .contenedor {
        margin-top: 3em;
        padding: 1.5em 1em;
        border: 1px solid gainsboro;
        border-radius: 15px;
        margin-left: auto;
        margin-right: auto;
        top: 3em;
        bottom: 3em;
        margin-bottom:3em;
        flex-direction: column;

    }

    .btn-success {
        width: max-content !important;
        float: right;
    }

    h3 {
        position: initial;
        text-align: center;
    }

    button a {
        color: white;
        height: 30px !important;
    }
</style>
<div class=""container contenedor"">
    <h3>Control de Matriculas</h3>
    <div>
        <button class=""btn btn-success"" type=""button"" style=""float:right;"">
            ");
#nullable restore
#line 39 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Enrollment\Details.cshtml"
       Write(Html.ActionLink("Agregar", "ControlEnrollment", "Enrollment", new { interruptor = 0 }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </button>
    </div>
    <table id=""TableEnrollment"" class=""table table-striped"">
        <thead class=""thead-dark"">
            <tr>
                <th>ID</th>
                <th>NAME</th>
                <th>LAST NAME</th>
                <th>TITLE</th>
                <th>GRADE</th>
                <th style=""text-align:center;"">ACTION</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 54 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Enrollment\Details.cshtml"
             foreach (var i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 57 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Enrollment\Details.cshtml"
               Write(i.enrollmentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 58 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Enrollment\Details.cshtml"
               Write(i.Student.firstMidName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 59 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Enrollment\Details.cshtml"
               Write(i.Student.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 60 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Enrollment\Details.cshtml"
               Write(i.Course.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 61 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Enrollment\Details.cshtml"
               Write(i.grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th style=\"text-align:center;\">\r\n                    <button class=\"btn btn-warning\" type=\"button\">");
#nullable restore
#line 63 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Enrollment\Details.cshtml"
                                                             Write(Html.ActionLink("Actualizar", "ControlEnrollment", "Enrollment", new { id = i.enrollmentId, interruptor = 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    <button class=\"btn btn-danger\" type=\"button\">");
#nullable restore
#line 64 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Enrollment\Details.cshtml"
                                                            Write(Html.ActionLink("Eliminar", "DeleteEnrollment", "Enrollment", new { id = i.enrollmentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </th>\r\n            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\Jose\Desktop\ProgramacionII_RepoGeneral\Escuela\Escuela\Views\Enrollment\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.datatables.net/1.11.3/js/jquery.dataTables.min.js\"></script>\r\n    <script>\r\n        $(document).ready(function () {\r\n            var tabla = $(\'#TableEnrollment\').DataTable();\r\n        })\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Escuela.Dominio.Tbl_Enrollment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
