#pragma checksum "C:\Users\Giles\Source\Repos\giles-king-pg\Proj516\LearnPhysics\LearnPhysics\Views\Calculator\Calculator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1270eb92c84eb0a78bed4ad0c6adcd42fa551b39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Calculator), @"mvc.1.0.view", @"/Views/Calculator/Calculator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Calculator.cshtml", typeof(AspNetCore.Views_Calculator_Calculator))]
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
#line 1 "C:\Users\Giles\Source\Repos\giles-king-pg\Proj516\LearnPhysics\LearnPhysics\Views\_ViewImports.cshtml"
using LearnPhysics;

#line default
#line hidden
#line 2 "C:\Users\Giles\Source\Repos\giles-king-pg\Proj516\LearnPhysics\LearnPhysics\Views\_ViewImports.cshtml"
using LearnPhysics.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1270eb92c84eb0a78bed4ad0c6adcd42fa551b39", @"/Views/Calculator/Calculator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"828bbca8e87de67beef73567d068a87c435efa0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Calculator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("NAME", new global::Microsoft.AspNetCore.Html.HtmlString("Calc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Giles\Source\Repos\giles-king-pg\Proj516\LearnPhysics\LearnPhysics\Views\Calculator\Calculator.cshtml"
  
    ViewData["Title"] = "Calculator";

#line default
#line hidden
            BeginContext(48, 25, true);
            WriteLiteral("\r\n<h2>Calculator</h2>\r\n\r\n");
            EndContext();
            BeginContext(73, 2346, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("FORM", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62784dcf6c1446338df71b9c7942ae6c", async() => {
                BeginContext(91, 2321, true);
                WriteLiteral(@"
    <TABLE BORDER=4>
        <TR>
            <TD>
                <INPUT TYPE=""text"" NAME=""Input"" Size=""16"">
                <br>
            </TD>
        </TR>
        <TR>
            <TD>
                <INPUT TYPE=""button"" class=""btn btn-primary"" NAME=""one"" VALUE=""  1  "" OnClick=""Calc.Input.value += '1'"">
                <INPUT TYPE=""button"" class=""btn btn-primary"" NAME=""two"" VALUE=""  2  "" OnCLick=""Calc.Input.value += '2'"">
                <INPUT TYPE=""button"" class=""btn btn-primary"" NAME=""three"" VALUE=""  3  "" OnClick=""Calc.Input.value += '3'"">
                <INPUT TYPE=""button"" class=""btn btn-info"" NAME=""plus"" VALUE=""  +  "" OnClick=""Calc.Input.value += ' + '"">
                <br>
                <INPUT TYPE=""button"" class=""btn btn-primary"" NAME=""four"" VALUE=""  4  "" OnClick=""Calc.Input.value += '4'"">
                <INPUT TYPE=""button"" class=""btn btn-primary"" NAME=""five"" VALUE=""  5  "" OnCLick=""Calc.Input.value += '5'"">
                <INPUT TYPE=""button"" class=""btn btn-primary"" N");
                WriteLiteral(@"AME=""six"" VALUE=""  6  "" OnClick=""Calc.Input.value += '6'"">
                <INPUT TYPE=""button"" class=""btn btn-info"" NAME=""minus"" VALUE=""  -  "" OnClick=""Calc.Input.value += ' - '"">
                <br>
                <INPUT TYPE=""button"" class=""btn btn-primary"" NAME=""seven"" VALUE=""  7  "" OnClick=""Calc.Input.value += '7'"">
                <INPUT TYPE=""button"" class=""btn btn-primary"" NAME=""eight"" VALUE=""  8  "" OnCLick=""Calc.Input.value += '8'"">
                <INPUT TYPE=""button"" class=""btn btn-primary"" NAME=""nine"" VALUE=""  9  "" OnClick=""Calc.Input.value += '9'"">
                <INPUT TYPE=""button"" class=""btn btn-danger"" NAME=""clear"" VALUE=""  c  "" OnClick=""Calc.Input.value = ''"">
                <br>
                <INPUT TYPE=""button"" class=""btn btn-info"" NAME=""times"" VALUE=""  x  "" OnClick=""Calc.Input.value += ' * '"">
                <INPUT TYPE=""button"" class=""btn btn-primary"" NAME=""zero"" VALUE=""  0  "" OnClick=""Calc.Input.value += '0'"">
                <INPUT TYPE=""button"" class=""btn btn-info"" N");
                WriteLiteral(@"AME=""div"" VALUE=""  /  "" OnClick=""Calc.Input.value += ' / '"">
                <INPUT TYPE=""button"" class=""btn btn-success"" NAME=""DoIt"" VALUE=""  =  "" OnClick=""Calc.Input.value = eval(Calc.Input.value)"">
                <br>
            </TD>
        </TR>
    </TABLE>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
