#pragma checksum "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c7e66f0c77960589bbcb5de32b5ec8e61dcbd15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookingDetails_viewBookingDetails), @"mvc.1.0.view", @"/Views/BookingDetails/viewBookingDetails.cshtml")]
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
#line 1 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\_ViewImports.cshtml"
using FlightProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\_ViewImports.cshtml"
using FlightProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7e66f0c77960589bbcb5de32b5ec8e61dcbd15", @"/Views/BookingDetails/viewBookingDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd936c29c72dfc097d56664b6e0a7e842f92a20", @"/Views/_ViewImports.cshtml")]
    public class Views_BookingDetails_viewBookingDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FlightProject.Models.BookingDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
  
    ViewData["Title"] = "viewBookingDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Booking Details Are Here..</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c7e66f0c77960589bbcb5de32b5ec8e61dcbd153812", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Bookingid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Flightid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Routeid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Doj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Numberofpassengers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Totalvalue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bookingid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Flightid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Routeid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Doj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Numberofpassengers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Totalvalue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 59 "C:\Users\m.s.lmv6\Desktop\demos\FlightProject\Views\BookingDetails\viewBookingDetails.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FlightProject.Models.BookingDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
