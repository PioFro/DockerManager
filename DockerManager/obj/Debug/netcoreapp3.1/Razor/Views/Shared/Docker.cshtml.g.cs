#pragma checksum "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf1e0b31fd5c0376c8739e5bf4f9f9b5a5ead95e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Docker), @"mvc.1.0.view", @"/Views/Shared/Docker.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf1e0b31fd5c0376c8739e5bf4f9f9b5a5ead95e", @"/Views/Shared/Docker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e860e86ec3f4f2b0cd5fc7a17249b0ff7c30e31", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Docker : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DockerWebApplication.Models.Docker>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 6 "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-12\">\r\n            ");
#nullable restore
#line 9 "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 12 "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml"
       Write(Html.DisplayNameFor(model => model.LastUsedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-12\">\r\n            ");
#nullable restore
#line 15 "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml"
       Write(Html.DisplayFor(model => model.LastUsedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 18 "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml"
       Write(Html.DisplayNameFor(model => model.PullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-12\">\r\n            ");
#nullable restore
#line 21 "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml"
       Write(Html.DisplayFor(model => model.PullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 24 "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml"
       Write(Html.DisplayNameFor(model => model.Variables));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-12\">\r\n");
#nullable restore
#line 27 "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml"
               Html.RenderPartial("EnvironmentalVariablesList", Model.v);

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 30 "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml"
       Write(Html.DisplayNameFor(model => model.Resoures));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-12\">\r\n");
#nullable restore
#line 33 "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml"
              Html.RenderPartial("Resource", Model.resources);

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-7\">\r\n            ");
#nullable restore
#line 36 "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-12\">\r\n            ");
#nullable restore
#line 39 "D:\Repos\DockerManager\DockerManager\Views\Shared\Docker.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DockerWebApplication.Models.Docker> Html { get; private set; }
    }
}
#pragma warning restore 1591