#pragma checksum "F:\trial\template\nazox\nazox Asp.net Core\Nazox\Nazox\Views\UiProgressbars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bee5a5163167e487dd19d11d73668d35370eded7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UiProgressbars_Index), @"mvc.1.0.view", @"/Views/UiProgressbars/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bee5a5163167e487dd19d11d73668d35370eded7", @"/Views/UiProgressbars/Index.cshtml")]
    public class Views_UiProgressbars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/metismenu/metisMenu.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/simplebar/simplebar.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/node-waves/waves.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\trial\template\nazox\nazox Asp.net Core\Nazox\Nazox\Views\UiProgressbars\Index.cshtml"
  
    ViewBag.Title = "ProgressBar";
    ViewBag.pTitle = "ProgressBar";
    ViewBag.pageTitle = "UI Elements";
    Layout = "~/Views/_Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Default Examples</h4>
                <p class=""card-title-desc"">
                    Progress components are built with two
                    HTML elements, some CSS to set the width, and a few attributes.
                </p>

                <div");
            BeginWriteAttribute("class", " class=\"", 580, "\"", 588, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""progress mb-4"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress mb-4"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress mb-4"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-xl-6"">
  ");
            WriteLiteral(@"      <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Backgrounds</h4>
                <p class=""card-title-desc"">
                    Use background utility classes to
                    change the appearance of individual progress bars.
                </p>

                <div");
            BeginWriteAttribute("class", " class=\"", 1951, "\"", 1959, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""progress mb-4"">
                        <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress mb-4"">
                        <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress mb-4"">
                        <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress"">
                        <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                </div>
            </div>
        </div>
    ");
            WriteLiteral(@"</div>
</div>

<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Labels Example</h4>
                <p class=""card-title-desc"">Add labels to your progress bars by placing text within the <code class=""highlighter-rouge"">.progress-bar</code>.</p>

                <div");
            BeginWriteAttribute("class", " class=\"", 3360, "\"", 3368, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""progress"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100"">25%</div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Multiple bars</h4>
                <p class=""card-title-desc"">Include multiple progress bars in a progress component if you need.</p>

                <div");
            BeginWriteAttribute("class", " class=\"", 3967, "\"", 3975, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""progress"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 15%"" aria-valuenow=""15"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 30%"" aria-valuenow=""30"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 20%"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Height</h4>
                <p class=""card-title-desc"">
                    We only set a <code class=""highlighter-rouge"">height</code> value on the <code class=""highlighter-rouge"">.progress-bar</code>, so if you change
             ");
            WriteLiteral("       that value the outer <code class=\"highlighter-rouge\">.progress</code>\r\n                    will automatically resize accordingly.\r\n                </p>\r\n\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 5182, "\"", 5190, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""progress mb-3"" style=""height: 3px;"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress"" style=""height: 20px;"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 25%;"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end col -->

    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Animated stripes</h4>
                <p class=""card-title-desc"">
                    The striped gradient can also be
                    animated. Add <code class=""highlighter-rouge"">.progress-bar-animated</code> to <code class=""highlighter-rouge"">.progress-bar</code> to animate the
        ");
            WriteLiteral("            stripes right to left via CSS3 animations.\r\n                </p>\r\n\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 6315, "\"", 6323, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""progress"">
                        <div class=""progress-bar progress-bar-striped progress-bar-animated"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 75%""></div>
                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end col -->
</div> <!-- end row -->


<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Striped</h4>
                <p class=""card-title-desc"">
                    Add <code class=""highlighter-rouge"">.progress-bar-striped</code>
                    to any <code class=""highlighter-rouge"">.progress-bar</code> to apply a
                    stripe via CSS gradient over the progress bar’s background color.
                </p>

                <div");
            BeginWriteAttribute("class", " class=\"", 7234, "\"", 7242, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""progress mb-4"">
                        <div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress mb-4"">
                        <div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress mb-4"">
                        <div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress mb-4"">
                        <div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
               ");
            WriteLiteral(@"     </div>
                    <div class=""progress"">
                        <div class=""progress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Animated Progress</h4>
                <p class=""card-title-desc"">Add <code class=""highlighter-rounge"">.animated-progess</code> class with <code class=""highlighter-rounge"">.progress-bar</code> for animated progressbar.</p>

                <div");
            BeginWriteAttribute("class", " class=\"", 8991, "\"", 8999, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""progress animated-progess mb-4"">
                        <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress animated-progess mb-4"">
                        <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress animated-progess mb-4"">
                        <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </div>
                    <div class=""progress animated-progess"">
                        <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                    </di");
            WriteLiteral("v>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div><!--end row-->\r\n\r\n<!-- JAVASCRIPT -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bee5a5163167e487dd19d11d73668d35370eded716897", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bee5a5163167e487dd19d11d73668d35370eded717937", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bee5a5163167e487dd19d11d73668d35370eded718977", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bee5a5163167e487dd19d11d73668d35370eded720017", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bee5a5163167e487dd19d11d73668d35370eded721057", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bee5a5163167e487dd19d11d73668d35370eded722101", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
