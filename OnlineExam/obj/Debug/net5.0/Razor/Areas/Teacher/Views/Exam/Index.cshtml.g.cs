#pragma checksum "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Teacher\Views\Exam\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "166081eb7e3dc5b82b035dd9c9cc274dfa4e8358"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Teacher_Views_Exam_Index), @"mvc.1.0.view", @"/Areas/Teacher/Views/Exam/Index.cshtml")]
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
#line 1 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Teacher\Views\_ViewImports.cshtml"
using OnlineExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Teacher\Views\_ViewImports.cshtml"
using OnlineExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"166081eb7e3dc5b82b035dd9c9cc274dfa4e8358", @"/Areas/Teacher/Views/Exam/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c26b38a268148b41f8d27cf9435d899b998ac06", @"/Areas/Teacher/Views/_ViewImports.cshtml")]
    public class Areas_Teacher_Views_Exam_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineExam.Models.Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/exam-datatables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/exam-modal-form.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Teacher\Views\Exam\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-main-counter"">
    <div class=""container"">
        <div class=""row pt-5 pb-5 d-flex align-items-center"" style=""min-height:300px"">
            <div class=""col-3"">
                <div class=""col-12 border border-primary rounded text-white text-center pt-3 pb-3 shadow"">
                    <p><i class=""fa fa-users"" style=""font-size:50px""></i></p>
                    <h2>11+</h2>
                    <h4>Users</h4>
                </div>
            </div>
            <div class=""col-3"">
                <div class=""col-12 border border-primary rounded text-white text-center pt-3 pb-3 shadow"">
                    <p><i class=""fas fa-shapes"" style=""font-size:50px""></i></p>
                    <h2>11+</h2>
                    <h4>Courses</h4>
                </div>
            </div>
            <div class=""col-3"">
                <div class=""col-12 border border-primary rounded text-white text-center pt-3 pb-3 shadow"">
                    <p><i class=""fas fa-clipboard-list");
            WriteLiteral(@""" style=""font-size:50px""></i></p>
                    <h2>11+</h2>
                    <h4>Exams</h4>
                </div>
            </div>
            <div class=""col-3"">
                <div class=""col-12 border border-primary rounded text-white text-center pt-3 pb-3 shadow"">
                    <p><i class=""fa fa-check"" style=""font-size:50px""></i></p>
                    <h2>11+</h2>
                    <h4>Questions</h4>
                </div>
            </div>
        </div>
    </div>
</div>
<div style=""background-color:#fafafa"">
    <div class=""container"">
        <div class=""row pt-3 pb-5"" style=""background-color:#f6f6f6"">
            <div class=""col-12"">
                <div class=""row pt-4"">
                    <div class=""col-6"">
                        <h2 class=""font-weight-bold text-secondary""><i class=""fas fa-book-reader text-danger""></i>&nbsp; ");
#nullable restore
#line 47 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Teacher\Views\Exam\Index.cshtml"
                                                                                                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                    <div class=\"col-6 text-right\">\r\n                        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2140, "\"", 2217, 5);
            WriteAttributeValue("", 2150, "openModal(\'/Teacher/Exam/Upsert?courseId=", 2150, 41, true);
#nullable restore
#line 50 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Teacher\Views\Exam\Index.cshtml"
WriteAttributeValue("", 2191, Model.Id, 2191, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2200, "\',", 2200, 2, true);
            WriteAttributeValue(" ", 2202, "\'Create", 2203, 8, true);
            WriteAttributeValue(" ", 2210, "Exam\')", 2211, 7, true);
            EndWriteAttribute();
            WriteLiteral(@"
                                class=""btn btn-primary text-white"">
                            <i class=""fas fa-plus""></i> &nbsp; Create New Exam
                        </button>
                    </div>
                </div>
                <br />
                <table id=""table-exam"" class=""table table-bordered table-striped rounded"" style=""width:100%"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th>Name</th>
                            <th>Date Created</th>
                            <th>Start Date</th>
                            <th>Duration</th>
                            <th></th>
                        </tr>
                    </thead>
                </table>
                <br />
                <table id=""table-waiting"" class=""table table-bordered table-striped"" style=""width:100%"">
                    <thead class=""thead-dark text-center"">
                        <tr>
                            <th>Name<");
            WriteLiteral(@"/th>
                            <th></th>
                        </tr>
                    </thead>
                </table>
            </div>

            <!-- Modal -->
            <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""form-modal"">
                <div class=""modal-dialog modal-lg"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header bg-light"">
                            <h5 class=""modal-title""></h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body"">

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "166081eb7e3dc5b82b035dd9c9cc274dfa4e83589479", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "166081eb7e3dc5b82b035dd9c9cc274dfa4e835810578", async() => {
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
                WriteLiteral("\r\n    <script>\r\n        document.getElementById(\"container-main\").className = \"container-fluid p-0\";\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineExam.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
