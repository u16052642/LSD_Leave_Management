#pragma checksum "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b29ce68670515d455056965c35a7a72fcc9250ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveRequests_MyLeave), @"mvc.1.0.view", @"/Views/LeaveRequests/MyLeave.cshtml")]
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
#line 1 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\_ViewImports.cshtml"
using Leave_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\_ViewImports.cshtml"
using Leave_Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29ce68670515d455056965c35a7a72fcc9250ab", @"/Views/LeaveRequests/MyLeave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0925c21221117491f9e905169a5d7eaa4fa01d", @"/Views/_ViewImports.cshtml")]
    public class Views_LeaveRequests_MyLeave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeLeaveRequestVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to Cancel?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
  
    ViewData["Title"] = "MyLeave";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>My Leave Allocation</h1>\n\n<div class=\"jumbotron\">\n    <div class=\"card\">\n        <ul class=\"list-group list-group-flush\">\n");
#nullable restore
#line 12 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
             foreach (var item in Model.LeaveAllocations)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\">\n                    <h6>");
#nullable restore
#line 15 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
                   Write(item.LeaveType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-secondary\">");
#nullable restore
#line 15 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
                                                                            Write(item.NumberOfDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\n                </li>\n");
#nullable restore
#line 17 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>
</div>
<h1>My Leave Record</h1>
<table class=""table"" id=""tbldata"">
    <thead>
        <tr>
            <th>
                Leave Type
            </th>
            <th>
                Start Date
            </th>
            <th>
                End Date
            </th>
            <th>
                Date Requested
            </th>
            <th>
                Approval Status
            </th>
            <th>
                Cancel Request
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 46 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
         foreach (var item in Model.LeaveRequests)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 50 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
               Write(Html.DisplayFor(modelItem => item.LeaveType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 53 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 56 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
               Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 59 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 62 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
                     if (item.Cancelled)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-secondary\">Cancelled</span>\n");
#nullable restore
#line 65 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
                    }
                    else if (item.Approved == false)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-danger\">Rejected</span>\n");
#nullable restore
#line 69 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
                    }
                    else if (item.Approved == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-warning\">Pending</span>\n");
#nullable restore
#line 73 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-success\">Approved</span>\n");
#nullable restore
#line 78 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n                <td>\n");
#nullable restore
#line 81 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
                     if (!item.Cancelled && item.StartDate > DateTime.Now)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b29ce68670515d455056965c35a7a72fcc9250ab11285", async() => {
                WriteLiteral("\n                            <i class=\"fas fa-trash-alt\"></i>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 86 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n            </tr>\n");
#nullable restore
#line 89 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\Leave Management\Views\LeaveRequests\MyLeave.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n<br />\n<br />\n<br />\n<br />\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script>\n        $(document).ready(function () {\n            $(\'#tbldata\').DataTable();\n        });\n    </script>\n");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeLeaveRequestVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
