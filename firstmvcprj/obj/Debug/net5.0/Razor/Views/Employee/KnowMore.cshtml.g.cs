#pragma checksum "C:\Users\m.s.lmv6\Desktop\demos\firstmvcprj\Views\Employee\KnowMore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e721a3c9113074ebc375604cca4753fb84b65a9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_KnowMore), @"mvc.1.0.view", @"/Views/Employee/KnowMore.cshtml")]
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
#line 1 "C:\Users\m.s.lmv6\Desktop\demos\firstmvcprj\Views\_ViewImports.cshtml"
using firstmvcprj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\m.s.lmv6\Desktop\demos\firstmvcprj\Views\_ViewImports.cshtml"
using firstmvcprj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e721a3c9113074ebc375604cca4753fb84b65a9c", @"/Views/Employee/KnowMore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91542f104ee22d139361893aa8ddeb232fd6c9a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_KnowMore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<firstmvcprj.Models.Emp>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1> Your Data: </h1>\r\n<h1> EID: ");
#nullable restore
#line 3 "C:\Users\m.s.lmv6\Desktop\demos\firstmvcprj\Views\Employee\KnowMore.cshtml"
     Write(Model.Empid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1> Ename: ");
#nullable restore
#line 4 "C:\Users\m.s.lmv6\Desktop\demos\firstmvcprj\Views\Employee\KnowMore.cshtml"
       Write(Model.Ename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1> ESalary: ");
#nullable restore
#line 5 "C:\Users\m.s.lmv6\Desktop\demos\firstmvcprj\Views\Employee\KnowMore.cshtml"
         Write(Model.Esalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<firstmvcprj.Models.Emp> Html { get; private set; }
    }
}
#pragma warning restore 1591
