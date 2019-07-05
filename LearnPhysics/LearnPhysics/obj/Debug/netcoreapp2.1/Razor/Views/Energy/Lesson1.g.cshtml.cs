#pragma checksum "C:\Users\Giles\source\repos\giles-king-pg\Proj516\LearnPhysics\LearnPhysics\Views\Energy\Lesson1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d214e9a1b27e4dee522a8864e5c658d90729d7f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Energy_Lesson1), @"mvc.1.0.view", @"/Views/Energy/Lesson1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Energy/Lesson1.cshtml", typeof(AspNetCore.Views_Energy_Lesson1))]
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
#line 1 "C:\Users\Giles\source\repos\giles-king-pg\Proj516\LearnPhysics\LearnPhysics\Views\_ViewImports.cshtml"
using LearnPhysics;

#line default
#line hidden
#line 2 "C:\Users\Giles\source\repos\giles-king-pg\Proj516\LearnPhysics\LearnPhysics\Views\_ViewImports.cshtml"
using LearnPhysics.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d214e9a1b27e4dee522a8864e5c658d90729d7f2", @"/Views/Energy/Lesson1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"828bbca8e87de67beef73567d068a87c435efa0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Energy_Lesson1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/topics/energy/lesson1/solarenergy.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Energy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnergyIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Giles\source\repos\giles-king-pg\Proj516\LearnPhysics\LearnPhysics\Views\Energy\Lesson1.cshtml"
  
    ViewData["Title"] = "Lesson 1";

#line default
#line hidden
            BeginContext(46, 5263, true);
            WriteLiteral(@"
<br />

<h2 style=""text-align: center; margin-top:80px;""><u>Lesson 1: Energy</u></h2>

<br />

<div class=""container"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <ul class=""nav nav-tabs"">
        <li class=""nav-item"">
            <a class=""nav-link active"" data-toggle=""tab"" href=""#intro"">Intro</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#part1"">1</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#part2"">2</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#part3"">3</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#summary"">Summary</a>
        </li>
    </ul>

    <div id=""myTabContent"" class=""tab-content"">

        <!-- INTRO -->
        <div class=""tab-pane fade active show"" id=""intro"">
            <br />
            <p>
");
            WriteLiteral(@"                Energy is all around us yet (other than light) it's rare that we can see it.
                With the exception of heat and electricity, it's not really
                <a href=""#"" style=""color:black; font-weight:bold;"" data-toggle=""tooltip"" data-placement=""top""
                   title=""definition: able to touch or feel something"">
                    tangible
                </a>, so it can be quite an abstract thing to learn about.
            </p>
            <p>
                Energy comes in many different forms, and we use it in very different ways.
            </p>
            <p>
                But for now, consider the questions below;
            </p>
            <h4><strong><u>Big questions;</u></strong></h4>
            <br />
            <p><strong> - What is energy?</strong></p>
            <p><strong> - Where does energy come from?</strong></p>
            <p><strong> - What can we do with energy?</strong></p>
        </div>

        <!-- PART 1 -->
     ");
            WriteLiteral(@"   <div class=""tab-pane fade"" id=""part1"">
            <br />
            <p><strong> - What is energy?</strong></p>
            <br />
            <p>
                Energy is defined as the ‘capacity to do
                <a href=""#"" style=""color:black; font-weight:bold;"" title=""Work"" data-container=""body"" data-toggle=""popover"" data-placement=""top""
                   data-content=""A technical way to say moving something from one place to another. The real definition is when a force is applied to, and moves an object.""
                   data-original-title=""Work"" aria-describedby=""popover168466"">work</a>’.
            </p>
            <p>
                Energy is also used when discussing the
                <a href=""#"" style=""color:black; font-weight:bold;"" title=""Temperature"" data-container=""body"" data-toggle=""popover"" data-placement=""top""
                   data-content=""Temperature is actually a way of saying the amount of energy something contains."" data-original-title=""Temperature""
    ");
            WriteLiteral(@"               aria-describedby=""popover168466"">temperature</a> of an object. In general
                terms, something with a higher temperature has more energy than something with
                a lower temperature (fridges and freezers are exceptions to the rule).
            </p>
            <p>A good way to look at it would be a blacksmith with a heavy metal bar.</p>
            <p>
                - To move the metal bar means the smith would have to do work, i.e.apply a force by using energy from his body.
            </p>
            <p>
                - Once the metal bar has been placed in a fire, the metal bar would
                increase in temperature, meaning it is gaining energy.
            </p>
            <p>
                - Taking the bar out of the fire requires work from the smith, and the
                bar would start to lose its energy to the surroundings and cool down.
            </p>
        </div>

        <!-- PART 2 -->
        <div class=""tab-pane fad");
            WriteLiteral(@"e"" id=""part2"">

            <br />

            <p><strong> - Where does energy come from?</strong></p>

            <br />

            <p>
                Good question! Energy cannot be created or destroyed. It just moves from one
                form to another.
            </p>
            <p>
                For that reason, the energy we are use is not created, so it must have already existed
                from somewhere before.
            </p>
            <p>
                The overwhelming theory surrounding the ‘<b>creation</b>’ of all energy is the ‘big
                bang’ - the event that started the construction and expansion of the universe.
            </p>
            <p>
                After the big bang, all the energy that was available has been used to create
                stars, planets and other objects in the cosmos. Life on Earth started by exploiting this energy.
            </p>

            <div class=""row justify-content-center"">
                <");
            WriteLiteral("div class=\"card text-white bg-secondary mb-3\" style=\"max-width: 494px;\">\r\n                    <div class=\"card-body\">\r\n                        ");
            EndContext();
            BeginContext(5309, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0986264bde4342dbb7332cc852087e77", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5369, 5267, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <p>
                Plants photosynthesise, making use of energy from the sun to make sugars.
                Without plants exploiting the
                <a href=""#"" style=""color:black; font-weight:bold;"" title=""Sunlight"" data-container=""body"" data-toggle=""popover"" data-placement=""top""
                   data-content=""Currently we use fossil fuels as an energy source. Fossil fuels used to be life that relied on photosynthetic organisms,
                   and the sun's energy. We are therefore still using sunlight as our main energy source."" data-original-title=""Sunlight""
                   aria-describedby=""popover168466"">
                    energy from the sun
                </a>, life would not be here on Earth.
            </p>
            <p>
                On our planet, all energy can be traced back to the Sun, and the Sun’s energy can be
                traced back to the big bang.
            </p");
            WriteLiteral(@">
        </div>

        <!-- PART 3 -->
        <div class=""tab-pane fade"" id=""part3"">
            <br />
            <p><strong> - What can we do with energy?</strong></p>
            <br />
            <p>
                As we’ve already seen, a smith can use energy to make a fire, move
                metal to heat it and then be able to bend the metal bar.
            </p>
            <p>
                Energy is something we can measure, usually in
                <a href=""#"" style=""color:black; font-weight:bold;"" title=""Joule"" data-container=""body"" data-toggle=""popover"" data-placement=""top""
                   data-content=""Named after a scientist - James Prescott Joule. Remember, a Joule is
                   a unit of energy. Scientists use the capital letter J as a symbol.""
                   data-original-title=""Joules"" aria-describedby=""popover168466"">
                    Joules
                </a>. We also measure energy in food as calories. As humans, we need to
          ");
            WriteLiteral(@"      consume food to perform actions and continue to live.
            </p>
            <ul>
                <li>
                    A mosquito uses very little energy and would need to fly non-stop for 72 days
                    before it spent a joule of energy.
                </li>
                <li>
                    1 joule of energy can be expended by a human when lifting an apple 1 metre
                    in the air.
                </li>
                <li>An average LED light may use 60 joules of energy in a minute.</li>
                <li>An average apple contains 397,480 joules of energy.</li>
                <li>A 30 minute run can use 1,300,000 joules of energy.</li>
                <li>
                    An atomic bomb releases approximately 63,000,000,000,000 (63 trillion) joules
                    of energy.
                </li>
            </ul>
            <p>
                Everything requires energy but in varying amounts.
            </p>
        </d");
            WriteLiteral(@"iv>

        <!-- PART 4 - Summary -->
        <div class=""tab-pane fade"" id=""summary"">
            <br />
            <p><strong> Summary</strong></p>
            <br />
            <ul>
                <li>
                    Energy is defined by physicists as the capacity to do '
                    <a href=""#"" style=""color:black; font-weight:bold;"" title=""Work"" data-container=""body"" data-toggle=""popover"" data-placement=""top""
                       data-content=""A technical way to say moving something from one place to another."" data-original-title=""Work""
                       aria-describedby=""popover168466"">work</a>'
                </li>
                <li>
                    Energy cannot be created or destroyed, but transformed from one form to another.
                </li>
                <li>
                    Energy is measured in
                    <a href=""#"" style=""color:black; font-weight:bold;"" title=""Joule"" data-container=""body"" data-toggle=""popover"" data-placement=");
            WriteLiteral(@"""top""
                       data-content=""Named after a scientist - James Prescott Joule. Remember, a joule is
                   a unit of energy. Scientists use the capital letter J as a symbol.""
                       data-original-title=""Joules"" aria-describedby=""popover168466"">Joules</a>
                </li>
                <li>
                    1 joule of energy can be expended by a human when lifting an apple 1 metre
                    in the air.
                </li>
                <li>
                    The most widely believed theory is that the big bang created all the energy around us today.
                </li>
                <li>
                    Most of the energy available to us on the planet has come from the Sun, which showers us with energy everyday.
                </li>
                <li>
                    Life forms have exploited the energy from the sun. We rely on these organisms to give us energy as well.
                </li>
                <li>");
            WriteLiteral("\n                    We need energy to do work.\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(10636, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6177eb29e51e4716aab7fc45ce4c453a", async() => {
                BeginContext(10700, 20, true);
                WriteLiteral("Back to lessons list");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10724, 24, true);
            WriteLiteral("\r\n    <br />\r\n</div>\r\n\r\n");
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
