#pragma checksum "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Student/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aecb93caf6cdb5759925bea847aaf14fd187eec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Details.cshtml", typeof(AspNetCore.Views_Student_Details))]
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
#line 1 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/_ViewImports.cshtml"
using SMS.Web;

#line default
#line hidden
#line 2 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/_ViewImports.cshtml"
using SMS.Web.Models;

#line default
#line hidden
#line 3 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/_ViewImports.cshtml"
using SMS.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aecb93caf6cdb5759925bea847aaf14fd187eec", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa2b49b31d8f20cfdb977b0c89a4c231924fd96", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTicket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Tickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 127, true);
            WriteLiteral("\r\n<h3 class=\"mt=4 mb-4\">Student Details</h3>\r\n\r\n<dl class=\"row\">\r\n    <dt class=\"col-sm-3\">Name</dt>\r\n    <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(144, 10, false);
#line 7 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Student/Details.cshtml"
                    Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(154, 76, true);
            WriteLiteral("</dd>\r\n    \r\n    <dt class=\"col-sm-3\">Course</dt>\r\n    <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(231, 12, false);
#line 10 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Student/Details.cshtml"
                    Write(Model.Course);

#line default
#line hidden
            EndContext();
            BeginContext(243, 73, true);
            WriteLiteral("</dd>\r\n    \r\n    <dt class=\"col-sm-3\">Age</dt>\r\n    <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(317, 9, false);
#line 13 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Student/Details.cshtml"
                    Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(326, 75, true);
            WriteLiteral("</dd>\r\n    \r\n    <dt class=\"col-sm-3\">Email</dt>\r\n    <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(402, 11, false);
#line 16 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Student/Details.cshtml"
                    Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(413, 159, true);
            WriteLiteral("</dd>\r\n\r\n    <!-- As our GetStudent service method Includes the Profile we can display here -->\r\n    <dt class=\"col-sm-3\">Grade</dt>\r\n    <dd class=\"col-sm-9\">");
            EndContext();
            BeginContext(573, 19, false);
#line 20 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Student/Details.cshtml"
                    Write(Model.Profile.Grade);

#line default
#line hidden
            EndContext();
            BeginContext(592, 48, true);
            WriteLiteral("</dd>\r\n\r\n</dl>\r\n\r\n<div class=\"mt-4 mb-4\"> \r\n    ");
            EndContext();
            BeginContext(640, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aecb93caf6cdb5759925bea847aaf14fd187eec7516", async() => {
                BeginContext(725, 13, true);
                WriteLiteral("Create Ticket");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Student/Details.cshtml"
                                  WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(742, 57, true);
            WriteLiteral("\r\n    <!-- add link to redirect to Index action -->\r\n    ");
            EndContext();
            BeginContext(799, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aecb93caf6cdb5759925bea847aaf14fd187eec9976", async() => {
                BeginContext(852, 20, true);
                WriteLiteral("Back to Student List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(876, 23, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(899, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2aecb93caf6cdb5759925bea847aaf14fd187eec11448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(926, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
