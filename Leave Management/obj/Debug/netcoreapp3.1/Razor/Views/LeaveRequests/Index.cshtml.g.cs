#pragma checksum "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc91b8e3aeeb374d782e37b9351902f6f510753e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveRequests_Index), @"mvc.1.0.view", @"/Views/LeaveRequests/Index.cshtml")]
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
#line 1 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\_ViewImports.cshtml"
using Leave_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\_ViewImports.cshtml"
using Leave_Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc91b8e3aeeb374d782e37b9351902f6f510753e", @"/Views/LeaveRequests/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0925c21221117491f9e905169a5d7eaa4fa01d", @"/Views/_ViewImports.cshtml")]
    public class Views_LeaveRequests_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminLeaveRequestVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-3"">
        <div class=""info-box"">
            <span class=""info-box-icon bg-info""><i class=""fas fa-tachometer-alt""></i></span>
            <div class=""info-box-content"">
                <span class=""info-box-text"">");
#nullable restore
#line 13 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                                       Write(Model.TotalRequest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <span class=\"info-box-number\">");
#nullable restore
#line 14 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                                         Write(Html.DisplayNameFor(model => model.TotalRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <!-- /.info-box-content -->
        </div>

    </div>
    <div class=""col-md-3"">
        <div class=""info-box"">
            <span class=""info-box-icon bg-warning""><i class=""fas fa-exclamation-circle""></i></span>

            <div class=""info-box-content"">
                <span class=""info-box-text"">");
#nullable restore
#line 25 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                                       Write(Model.PendingRequest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <span class=\"info-box-number\">");
#nullable restore
#line 26 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                                         Write(Html.DisplayNameFor(model => model.PendingRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <!-- /.info-box-content -->
        </div>

    </div>
    <div class=""col-md-3"">
        <div class=""info-box"">
            <span class=""info-box-icon bg-success""><i class=""far fa-check-circle""></i></span>

            <div class=""info-box-content"">
                <span class=""info-box-text"">");
#nullable restore
#line 37 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                                       Write(Model.ApprovedRequest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <span class=\"info-box-number\">");
#nullable restore
#line 38 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                                         Write(Html.DisplayNameFor(model => model.ApprovedRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <!-- /.info-box-content -->
        </div>

    </div>
    <div class=""col-md-3"">
        <div class=""info-box"">
            <span class=""info-box-icon bg-danger""><i class=""far fa-times-circle""></i></span>

            <div class=""info-box-content"">
                <span class=""info-box-text"">");
#nullable restore
#line 49 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                                       Write(Model.RejectedRequest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                <span class=\"info-box-number\">");
#nullable restore
#line 50 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                                         Write(Html.DisplayNameFor(model => model.RejectedRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
            <!-- /.info-box-content -->
        </div>

    </div>
</div>

<br />
<br />

<hr />
<h1>Leave Request Log</h1>
<hr />
<table id=""mytable"" class=""table"">
    <thead>
        <tr>
            <th>
                Employee Name
            </th>
            <th>
                Start Date
            </th>
            <th>
                End Date
            </th>
            <th>
                Leave Type
            </th>
            <th>
                Date Requested
            </th>

            <th>
                Approval Status
            </th>

            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 91 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
         foreach (var item in Model.LeaveRequest)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 95 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RequestingEmployee.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 95 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                                                                                Write(Html.DisplayFor(modelItem => item.RequestingEmployee.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 98 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 101 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 104 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LeaveType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 107 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n");
#nullable restore
#line 110 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                     if (item.Cancelled)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-secondary\">Cancelled</span>\n");
#nullable restore
#line 113 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                    }
                    else if (item.Approved == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-success\">Approved</span>\n");
#nullable restore
#line 117 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                    }
                    else if (item.Approved == false)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-danger\">Rejected</span>\n");
#nullable restore
#line 121 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-warning\">Pending Approval</span>\n");
#nullable restore
#line 125 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n                <td>\n");
#nullable restore
#line 128 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                     if (!item.Cancelled)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc91b8e3aeeb374d782e37b9351902f6f510753e15092", async() => {
                WriteLiteral("\n                            <i class=\"fa fa-file\"></i>Review\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                                                                                  WriteLiteral(item.Id);

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
            WriteLiteral("\n");
#nullable restore
#line 133 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                </td>\n            </tr>\n");
#nullable restore
#line 138 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script>\n        $(document).ready(function () {\n            $(\'#mytable\').dataTable();\n        });\n    </script>\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminLeaveRequestVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
