#pragma checksum "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Ticket/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "376b9bee57576c6be2a36f843d6f75df4f61964c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Index), @"mvc.1.0.view", @"/Views/Ticket/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ticket/Index.cshtml", typeof(AspNetCore.Views_Ticket_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"376b9bee57576c6be2a36f843d6f75df4f61964c", @"/Views/Ticket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa2b49b31d8f20cfdb977b0c89a4c231924fd96", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Ticket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Close", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 139, true);
            WriteLiteral("\r\n<h3>Open Ticket List</h3>\r\n\r\n<div class=\"mt-4 mb-4\">\r\n   <!-- add an action link styled as a button to navigate to Create Action -->\r\n   ");
            EndContext();
            BeginContext(161, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "376b9bee57576c6be2a36f843d6f75df4f61964c4748", async() => {
                BeginContext(215, 13, true);
                WriteLiteral("Create Ticket");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(232, 258, true);
            WriteLiteral(@"
</div>

<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Student</th>
            <th>Issue</th>
            <th>Created</th>           
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Ticket/Index.cshtml"
         foreach(var t in Model) {

#line default
#line hidden
            BeginContext(526, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(565, 4, false);
#line 23 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Ticket/Index.cshtml"
               Write(t.Id);

#line default
#line hidden
            EndContext();
            BeginContext(569, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(597, 14, false);
#line 24 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Ticket/Index.cshtml"
               Write(t.Student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(611, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(639, 7, false);
#line 25 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Ticket/Index.cshtml"
               Write(t.Issue);

#line default
#line hidden
            EndContext();
            BeginContext(646, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(674, 11, false);
#line 26 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Ticket/Index.cshtml"
               Write(t.CreatedOn);

#line default
#line hidden
            EndContext();
            BeginContext(685, 63, true);
            WriteLiteral("</td>              \r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(748, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "376b9bee57576c6be2a36f843d6f75df4f61964c8272", async() => {
                BeginContext(773, 56, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 829, "", 841, 1);
#line 29 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Ticket/Index.cshtml"
WriteAttributeValue("", 836, t.Id, 836, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(841, 108, true);
                WriteLiteral(" />\r\n                        <input type=\"submit\" value=\"Close\" class=\"btn btn-link\"/>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(956, 86, true);
            WriteLiteral("                                          \r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 34 "/Users/aiden/Documents/Archive-Code/dotNet/Practical10-SMS2-Complete/SMS.Web/Views/Ticket/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1053, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591