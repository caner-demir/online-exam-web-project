#pragma checksum "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Admin\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5276b3c5b1855974b0a5e5add0903f852eb7475e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Course_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Course/Index.cshtml")]
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
#line 1 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5276b3c5b1855974b0a5e5add0903f852eb7475e", @"/Areas/Admin/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c26b38a268148b41f8d27cf9435d899b998ac06", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin-course.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Admin\Views\Course\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-main-counter"">
    <div class=""container"">
        <div data-aos=""fade-in"" data-aos-once=""true"" class=""row pt-5 pb-5 d-flex align-items-center"" style=""min-height:360px"">
            <h1 data-aos=""fade-down"" data-aos-delay=""100"" class=""col-12 text-center font-weight-bold pb-3"" style=""font-size:34px; color:#e8b87e"">All Courses</h1>
            <div class=""col-3"">
                <div class=""col-12 border-thick border-primary rounded text-white text-center py-3 rounded-0 shadow"">
                    <p><i class=""fa fa-users text-light"" style=""font-size:50px""></i></p>
                    <h2 id=""user-counter""></h2>
                    <h4>Users</h4>
                </div>
            </div>
            <div class=""col-3"">
                <div class=""col-12 border-thick border-primary rounded text-white text-center py-3 rounded-0 shadow"">
                    <p><i class=""fas fa-book-open text-light"" style=""font-size:50px""></i></p>
                    <h2 id=""course-counter""></");
            WriteLiteral(@"h2>
                    <h4>Courses</h4>
                </div>
            </div>
            <div class=""col-3"">
                <div class=""col-12 border-thick border-primary rounded text-white text-center py-3 rounded-0 shadow"">
                    <p><i class=""fas fa-sticky-note text-light"" style=""font-size:50px""></i></p>
                    <h2 id=""exam-counter""></h2>
                    <h4>Exams</h4>
                </div>
            </div>
            <div class=""col-3"">
                <div class=""col-12 border-thick border-primary rounded text-white text-center py-3 rounded-0 shadow"">
                    <p><i class=""fas fa-question-circle text-light"" style=""font-size:50px""></i></p>
                    <h2 id=""question-counter""></h2>
                    <h4>Questions</h4>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""container-teacher"">
    <div class=""container"">
        <div class=""row pt-5 pb-5"" style=""background-color:rgb(255,255,");
            WriteLiteral(@"255,0.01)"">
            <div class=""col-12"">
                <div class=""row pt-3 pb-2 bg-light rounded shadow-sm border"">
                    <div class=""col-6"">
                        <h2 class=""font-weight-normal text-secondary""><i class=""fas fa-book-open text-danger""></i>&nbsp; All Courses</h2>
                    </div>
                </div>
                <br />
                <div class=""row bg-white mt-2 pt-4 pb-4 rounded shadow-sm border"">
                    <div class=""col-12"">
                        <table id=""tblData"" class=""table table-bordered border-top-0 table-striped w-100"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th>Name</th>
                                    <th>Image</th>
                                    <th>Created By</th>
                                    <th>Date Created</th>
                                    <th>Students</th>
                                    <th");
            WriteLiteral(" class=\"text-center\">Edit</th>\r\n                                </tr>\r\n                            </thead>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5276b3c5b1855974b0a5e5add0903f852eb7475e7381", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
