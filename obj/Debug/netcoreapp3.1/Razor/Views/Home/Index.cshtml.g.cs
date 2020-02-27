#pragma checksum "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f08e450060fc5683957e5842af43c6eb430c7d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Develop\SchoolDataBaseApp\Views\_ViewImports.cshtml"
using SchoolDataBaseApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Develop\SchoolDataBaseApp\Views\_ViewImports.cshtml"
using SchoolDataBaseApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f08e450060fc5683957e5842af43c6eb430c7d1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0409cee35605ac08ff66eba7504e93e59b94c1d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SchoolDataBaseApp.ViewModels.StaffViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-3 text-center""> <a href=""/Home/AddStaffRecord"" class=""btn btn-success"" style=""margin-bottom:50px;"">Добавить сотрудника</a></div>
        <div class=""col-3  text-center""><a href=""/Home/LookSpecialization"" class=""btn btn-success"" style=""margin-bottom:50px; margin-left:50px;"">Посмотреть информацию о специализациях</a></div>
        <div class=""col-3  text-center""><a href=""/Home/LookDepartamentsData"" class=""btn btn-success"" style=""margin-bottom:50px; margin-left:50px;"">Посмотреть информацию о отделах</a></div>
        <div class=""col-3  text-center""><a href=""/Home/SearchStaff"" class=""btn btn-success"" style=""margin-bottom:50px; margin-left:50px;"">Поиск сотрудника</a></div>
    </div>
    <table class=""text-center table table-bordered"">
        <tr>
            <td>Имя</td>
            <td>Фамилия</td>
            <td>Возраст</td>
            <td>Пол</td>
            <td>Стаж работы</td>
            <td>Отдел</td>
           ");
            WriteLiteral(" <td>Специализация</td>\r\n            <td>Действия</td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n            <td>");
#nullable restore
#line 26 "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml"
           Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml"
           Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml"
           Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml"
           Write(item.ExperienceWork);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml"
           Write(item.DepartamentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml"
           Write(item.Specialization);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 1535, "\"", 1572, 2);
            WriteAttributeValue("", 1542, "/Home/StaffRecordEdit/", 1542, 22, true);
#nullable restore
#line 34 "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1564, item.Id, 1564, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\" style=\"margin:10px;\">Изменить</a><a");
            BeginWriteAttribute("href", " href=\"", 1641, "\"", 1680, 2);
            WriteAttributeValue("", 1648, "/Home/StaffRecordRemove/", 1648, 24, true);
#nullable restore
#line 34 "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1672, item.Id, 1672, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Удалить</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 36 "D:\Develop\SchoolDataBaseApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<footer>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-3"">
                <a href=""/Home/GetExperiencePeople"" class=""btn btn-outline-success"" style=""margin:10px;"">Показать самых опытных сотрудников</a>
            </div>
        </div>
    </div>
</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SchoolDataBaseApp.ViewModels.StaffViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
