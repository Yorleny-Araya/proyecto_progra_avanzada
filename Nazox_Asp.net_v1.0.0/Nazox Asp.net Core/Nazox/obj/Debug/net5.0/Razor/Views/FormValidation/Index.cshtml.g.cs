#pragma checksum "F:\trial\template\nazox\nazox Asp.net Core\Nazox\Nazox\Views\FormValidation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e4416fb9d86d61d1c1f54385814b8c5e72d5d6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FormValidation_Index), @"mvc.1.0.view", @"/Views/FormValidation/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e4416fb9d86d61d1c1f54385814b8c5e72d5d6e", @"/Views/FormValidation/Index.cshtml")]
    public class Views_FormValidation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/metismenu/metisMenu.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/simplebar/simplebar.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/node-waves/waves.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/parsleyjs/parsley.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/pages/form-validation.init.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "F:\trial\template\nazox\nazox Asp.net Core\Nazox\Nazox\Views\FormValidation\Index.cshtml"
  
    ViewBag.Title = "Form Validation";
    ViewBag.pTitle = "Form Validation";
    ViewBag.pageTitle = "Forms";
    Layout = "~/Views/_Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Bootstrap Validation - Normal</h4>
                <p class=""card-title-desc"">
                    Provide valuable, actionable feedback to your users with
                    HTML5 form validation–available in all our supported browsers.
                </p>
                <form class=""needs-validation"" novalidate>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""mb-3"">
                                <label for=""validationCustom01"" class=""form-label"">First name</label>
                                <input type=""text"" class=""form-control"" id=""validationCustom01""
                                       placeholder=""First name"" value=""Mark"" required>
                                <div class=""valid-feedback"">
                                    Looks good!
            ");
            WriteLiteral(@"                    </div>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""mb-3"">
                                <label for=""validationCustom02"" class=""form-label"">Last name</label>
                                <input type=""text"" class=""form-control"" id=""validationCustom02""
                                       placeholder=""Last name"" value=""Otto"" required>
                                <div class=""valid-feedback"">
                                    Looks good!
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""mb-3"">
                                <label for=""validationCustom03"" class=""form-label"">State</label>
                                <select class=""form-select"" id=""va");
            WriteLiteral("lidationCustom03\" required>\r\n                                    <option selected disabled");
            BeginWriteAttribute("value", " value=\"", 2308, "\"", 2316, 0);
            EndWriteAttribute();
            WriteLiteral(@">Choose...</option>
                                    <option>...</option>
                                </select>
                                <div class=""invalid-feedback"">
                                    Please select a valid state.
                                </div>

                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""mb-3"">
                                <label for=""validationCustom04"" class=""form-label"">City</label>
                                <input type=""text"" class=""form-control"" id=""validationCustom04""
                                       placeholder=""City"" required>
                                <div class=""invalid-feedback"">
                                    Please provide a valid city.
                                </div>
                            </div>
                        </div>

                        <div class=""col-md-4"">
               ");
            WriteLiteral(@"             <div class=""mb-3"">
                                <label for=""validationCustom05"" class=""form-label"">Zip</label>
                                <input type=""text"" class=""form-control"" id=""validationCustom05""
                                       placeholder=""Zip"" required>
                                <div class=""invalid-feedback"">
                                    Please provide a valid zip.
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""form-check mb-3"">
                        <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 4022, "\"", 4030, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""invalidCheck""
                               required>
                        <label class=""form-check-label"" for=""invalidCheck"">
                            Agree to terms and conditions
                        </label>
                        <div class=""invalid-feedback"">
                            You must agree before submitting.
                        </div>
                    </div>
                    <div>
                        <button class=""btn btn-primary"" type=""submit"">Submit form</button>
                    </div>
                </form>
            </div>
        </div>
        <!-- end card -->
    </div> <!-- end col -->

    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Bootstrap Validation (Tooltips)</h4>
                <p class=""card-title-desc"">
                    If your form layout allows it, you can swap the
                    <code>.{valid|invalid}-feedback</code> clas");
            WriteLiteral(@"ses for
                    <code>.{valid|invalid}-tooltip</code> classes to display validation feedback in a
                    styled tooltip.
                </p>
                <form class=""needs-validation"" novalidate>
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""mb-3 position-relative"">
                                <label for=""validationTooltip01"" class=""form-label"">First name</label>
                                <input type=""text"" class=""form-control"" id=""validationTooltip01""
                                       placeholder=""First name"" value=""Mark"" required>
                                <div class=""valid-tooltip"">
                                    Looks good!
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""mb-3 position-relative"">
                  ");
            WriteLiteral(@"              <label for=""validationTooltip02"" class=""form-label"">Last name</label>
                                <input type=""text"" class=""form-control"" id=""validationTooltip02""
                                       placeholder=""Last name"" value=""Otto"" required>
                                <div class=""valid-tooltip"">
                                    Looks good!
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""mb-3 position-relative"">
                                <label for=""validationTooltipUsername"" class=""form-label"">Username</label>
                                <div class=""input-group"">
                                    <div class=""input-group-prepend"">
                                        <span class=""input-group-text""
                                              id=""validationTooltipUsernamePrepend"">");
            WriteLiteral(@"@</span>
                                    </div>
                                    <input type=""text"" class=""form-control"" id=""validationTooltipUsername""
                                           placeholder=""Username""
                                           aria-describedby=""validationTooltipUsernamePrepend"" required>
                                    <div class=""invalid-tooltip"">
                                        Please choose a unique and valid username.
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""mb-3 position-relative"">
                                <label for=""validationTooltip04"" class=""form-label"">State</label>
                                <input type=""text"" class=""form-control"" id=""validationTooltip04""
        ");
            WriteLiteral(@"                               placeholder=""State"" required>
                                <div class=""invalid-tooltip"">
                                    Please provide a valid state.
                                </div>
                            </div>
                        </div>

                        <div class=""col-md-6"">
                            <div class=""mb-3 position-relative"">
                                <label for=""validationTooltip03"" class=""form-label"">City</label>
                                <input type=""text"" class=""form-control"" id=""validationTooltip03""
                                       placeholder=""City"" required>
                                <div class=""invalid-tooltip"">
                                    Please provide a valid city.
                                </div>
                            </div>
                        </div>

                    </div>
                    <div>

                        <button class=""btn btn-");
            WriteLiteral(@"primary"" type=""submit"">Submit form</button>
                    </div>
                </form>
            </div>
        </div>
        <!-- end card -->
    </div> <!-- end col -->
</div>
<!-- end row -->

<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Validation type</h4>
                <p class=""card-title-desc"">
                    Parsley is a javascript form validation
                    library. It helps you provide your users with feedback on their form
                    submission before sending it to your server.
                </p>

                <form class=""custom-validation"" action=""#"">
                    <div class=""mb-3"">
                        <label>Required</label>
                        <input type=""text"" class=""form-control"" required placeholder=""Type something"" />
                    </div>

                    <div class=""mb-3"">
                     ");
            WriteLiteral(@"   <label>Equal To</label>
                        <div>
                            <input type=""password"" id=""pass2"" class=""form-control"" required
                                   placeholder=""Password"" />
                        </div>
                        <div class=""mt-2"">
                            <input type=""password"" class=""form-control"" required
                                   data-parsley-equalto=""#pass2""
                                   placeholder=""Re-Type Password"" />
                        </div>
                    </div>

                    <div class=""mb-3"">
                        <label>E-Mail</label>
                        <div>
                            <input type=""email"" class=""form-control"" required
                                   parsley-type=""email"" placeholder=""Enter a valid e-mail"" />
                        </div>
                    </div>
                    <div class=""mb-3"">
                        <label>URL</label>
                  ");
            WriteLiteral(@"      <div>
                            <input parsley-type=""url"" type=""url"" class=""form-control""
                                   required placeholder=""URL"" />
                        </div>
                    </div>
                    <div class=""mb-3"">
                        <label>Digits</label>
                        <div>
                            <input data-parsley-type=""digits"" type=""text""
                                   class=""form-control"" required
                                   placeholder=""Enter only digits"" />
                        </div>
                    </div>
                    <div class=""mb-3"">
                        <label>Number</label>
                        <div>
                            <input data-parsley-type=""number"" type=""text""
                                   class=""form-control"" required
                                   placeholder=""Enter only numbers"" />
                        </div>
                    </div>
                 ");
            WriteLiteral(@"   <div class=""mb-3"">
                        <label>Alphanumeric</label>
                        <div>
                            <input data-parsley-type=""alphanum"" type=""text""
                                   class=""form-control"" required
                                   placeholder=""Enter alphanumeric value"" />
                        </div>
                    </div>
                    <div class=""mb-3"">
                        <label>Textarea</label>
                        <div>
                            <textarea required class=""form-control"" rows=""5""></textarea>
                        </div>
                    </div>
                    <div class=""mb-0"">
                        <div>
                            <button type=""submit"" class=""btn btn-primary waves-effect waves-light me-1"">
                                Submit
                            </button>
                            <button type=""reset"" class=""btn btn-secondary waves-effect"">
                    ");
            WriteLiteral(@"            Cancel
                            </button>
                        </div>
                    </div>
                </form>

            </div>
        </div>
    </div> <!-- end col -->

    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""card-title"">Range validation</h4>
                <p class=""card-title-desc"">
                    Parsley is a javascript form validation
                    library. It helps you provide your users with feedback on their form
                    submission before sending it to your server.
                </p>

                <form action=""#"" class=""custom-validation"">

                    <div class=""mb-3"">
                        <label>Min Length</label>
                        <div>
                            <input type=""text"" class=""form-control"" required
                                   data-parsley-minlength=""6"" placeholder=""Min 6 chars."" />
            ");
            WriteLiteral(@"            </div>
                    </div>
                    <div class=""mb-3"">
                        <label>Max Length</label>
                        <div>
                            <input type=""text"" class=""form-control"" required
                                   data-parsley-maxlength=""6"" placeholder=""Max 6 chars."" />
                        </div>
                    </div>
                    <div class=""mb-3"">
                        <label>Range Length</label>
                        <div>
                            <input type=""text"" class=""form-control"" required
                                   data-parsley-length=""[5,10]""
                                   placeholder=""Text between 5 - 10 chars length"" />
                        </div>
                    </div>
                    <div class=""mb-3"">
                        <label>Min Value</label>
                        <div>
                            <input type=""text"" class=""form-control"" required
           ");
            WriteLiteral(@"                        data-parsley-min=""6"" placeholder=""Min value is 6"" />
                        </div>
                    </div>
                    <div class=""mb-3"">
                        <label>Max Value</label>
                        <div>
                            <input type=""text"" class=""form-control"" required
                                   data-parsley-max=""6"" placeholder=""Max value is 6"" />
                        </div>
                    </div>
                    <div class=""mb-3"">
                        <label>Range Value</label>
                        <div>
                            <input class=""form-control"" required type=""text range"" min=""6""
                                   max=""100"" placeholder=""Number between 6 - 100"" />
                        </div>
                    </div>
                    <div class=""mb-3"">
                        <label>Regular Exp</label>
                        <div>
                            <input type=""text"" class=""");
            WriteLiteral(@"form-control"" required
                                   data-parsley-pattern=""#[A-Fa-f0-9]{6}""
                                   placeholder=""Hex. Color"" />
                        </div>
                    </div>

                    <div class=""mb-0"">
                        <div>
                            <button type=""submit"" class=""btn btn-primary waves-effect waves-light me-1"">
                                Submit
                            </button>
                            <button type=""reset"" class=""btn btn-secondary waves-effect"">
                                Cancel
                            </button>
                        </div>
                    </div>
                </form>

            </div>
        </div>
    </div> <!-- end col -->
</div> <!-- end row -->

<!-- JAVASCRIPT -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4416fb9d86d61d1c1f54385814b8c5e72d5d6e24120", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4416fb9d86d61d1c1f54385814b8c5e72d5d6e25160", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4416fb9d86d61d1c1f54385814b8c5e72d5d6e26200", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4416fb9d86d61d1c1f54385814b8c5e72d5d6e27240", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4416fb9d86d61d1c1f54385814b8c5e72d5d6e28280", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4416fb9d86d61d1c1f54385814b8c5e72d5d6e29324", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4416fb9d86d61d1c1f54385814b8c5e72d5d6e30368", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e4416fb9d86d61d1c1f54385814b8c5e72d5d6e31412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
