#pragma checksum "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2459316115a640b74cc388b8be00eb0e18a86e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveRequests_Details), @"mvc.1.0.view", @"/Views/LeaveRequests/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2459316115a640b74cc388b8be00eb0e18a86e5", @"/Views/LeaveRequests/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d0925c21221117491f9e905169a5d7eaa4fa01d", @"/Views/_ViewImports.cshtml")]
    public class Views_LeaveRequests_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Leave_Management.Models.LeaveRequestVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApproveRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RejectRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 8 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
 if (Model.Approved == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\">\n        <h4 class=\"alert-heading\">Pending Approval</h4>\n        <p>\n            <strong>");
#nullable restore
#line 13 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequestingEmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong>  ");
#nullable restore
#line 13 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                                                    Write(Model.RequestingEmployee.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                                                                                        Write(Model.RequestingEmployee.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \'s Leave Request <br />\n        </p>\n        <hr />\n        <p>\n            ");
#nullable restore
#line 17 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </div>\n");
#nullable restore
#line 20 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
}
else if (Model.Approved == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\n        <h4 class=\"alert-heading\">Approved by ");
#nullable restore
#line 24 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                         Write(Model.ApprovedBy.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                                     Write(Model.ApprovedBy.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <p>\n            <strong>");
#nullable restore
#line 26 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequestingEmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> ");
#nullable restore
#line 26 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                                                   Write(Model.RequestingEmployee.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                                                                                       Write(Model.RequestingEmployee.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br />\n        </p>\n        <hr />\n        <p>\n            ");
#nullable restore
#line 30 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 30 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </div>\n");
#nullable restore
#line 33 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\n        <h4 class=\"alert-heading\">Rejected by ");
#nullable restore
#line 37 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                         Write(Model.ApprovedBy.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 37 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                                     Write(Model.ApprovedBy.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <p>\n            <strong>");
#nullable restore
#line 39 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.RequestingEmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</strong> ");
#nullable restore
#line 39 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                                                   Write(Model.RequestingEmployee.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                                                                                       Write(Model.RequestingEmployee.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n        </p>\n        <hr />\n        <p>\n            ");
#nullable restore
#line 43 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 43 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                            Write(Html.DisplayFor(model => model.DateRequested));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </div>\n");
#nullable restore
#line 46 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 52 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 55 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 58 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 61 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 64 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LeaveType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 67 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.LeaveType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 70 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 73 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequestComments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n");
#nullable restore
#line 78 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
     if (Model.Approved == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2459316115a640b74cc388b8be00eb0e18a86e519010", async() => {
                WriteLiteral("\n            <i class=\"fas fa-check\"></i> Approve\n        ");
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
#line 80 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                                 WriteLiteral(Model.Id);

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
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2459316115a640b74cc388b8be00eb0e18a86e521430", async() => {
                WriteLiteral("\n            <i class=\"fas fa-remove\"></i> Reject\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
                                                               WriteLiteral(Model.Id);

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
#line 86 "C:\Users\divin\OneDrive\Desktop\Leave-management Project\Leave-Management-master\Leave-Management-master\LSD_Leave_Management\Leave Management\Views\LeaveRequests\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2459316115a640b74cc388b8be00eb0e18a86e524142", async() => {
                WriteLiteral("\n        <i class=\"fa fa-arrow-left\"></i> Back to List\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Leave_Management.Models.LeaveRequestVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
