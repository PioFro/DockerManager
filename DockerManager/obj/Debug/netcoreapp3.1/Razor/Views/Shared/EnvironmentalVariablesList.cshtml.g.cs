#pragma checksum "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abf8c268cc27b4458d0a8e3000dd193bf0dd257a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EnvironmentalVariablesList), @"mvc.1.0.view", @"/Views/Shared/EnvironmentalVariablesList.cshtml")]
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
#line 1 "D:\Repos\DockerManager\DockerManager\Views\_ViewImports.cshtml"
using DockerManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repos\DockerManager\DockerManager\Views\_ViewImports.cshtml"
using DockerManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abf8c268cc27b4458d0a8e3000dd193bf0dd257a", @"/Views/Shared/EnvironmentalVariablesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e860e86ec3f4f2b0cd5fc7a17249b0ff7c30e31", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EnvironmentalVariablesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DockerWebApplication.Models.EnvironmentalVariables>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    ");
#nullable restore
#line 4 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
Write(Html.ActionLink("Create New Enviornmental Variable", "Create", "EnvironmentalVariables", null, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
           Write(Html.DisplayNameFor(model => model.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
           Write(Html.ActionLink("Edit", "Edit", "EnvironmentalVariables", new { id = item.ID },null));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 41 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
           Write(Html.ActionLink("Delete", "Delete", "EnvironmentalVariables", new { id = item.ID }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 44 "D:\Repos\DockerManager\DockerManager\Views\Shared\EnvironmentalVariablesList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DockerWebApplication.Models.EnvironmentalVariables>> Html { get; private set; }
    }
}
#pragma warning restore 1591
