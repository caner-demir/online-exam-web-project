#pragma checksum "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91c5a6595fa5274b74b23937084c1046220ff792"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Student_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Student/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\_ViewImports.cshtml"
using OnlineExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\_ViewImports.cshtml"
using OnlineExam.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
using OnlineExam.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c5a6595fa5274b74b23937084c1046220ff792", @"/Areas/Student/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c26b38a268148b41f8d27cf9435d899b998ac06", @"/Areas/Student/Views/_ViewImports.cshtml")]
    public class Areas_Student_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<OnlineExam.Models.ViewModels.HomeCourseVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-begin", new global::Microsoft.AspNetCore.Html.HtmlString("ajaxBegin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("ajaxSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-auto mb-4 form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CoursesPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/student-home-index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("NavbarSearch", async() => {
                WriteLiteral(@" 
    <div class=""container-main-head"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-6"">
                    <div class=""d-flex flex-column align-items-start justify-content-center"" style=""height: 280px; font-family: 'Montserrat', sans-serif; "">
                        <h1 data-aos=""fade-in"" data-aos-delay=""200"" class=""text-light"">Your Online<br>Testing Partner</h1>
                        <p data-aos=""fade-in"" data-aos-delay=""200"" class=""text-light"">Online exam system for all your testing needs for <strong>assessment, recruitment, selection</strong> and <strong>certifications.</strong></p>
                    </div>
                </div>
                <div class=""col-6"">
                    <div class=""d-flex flex-column align-items-end"" style=""height:280px"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91c5a6595fa5274b74b23937084c1046220ff7928104", async() => {
                    WriteLiteral(@"
                            <input class=""form-control mr-sm-2"" type=""search"" placeholder=""Search"" name=""searchTerm"">
                            <button type=""submit"" class=""ml-2 btn btn-outline-light rounded-0""><i class=""fas fa-search""></i>&nbsp; SEARCH</button>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral(@"<div class=""container-main-intro"">
    <div class=""container overflow-hidden"">
        <div class=""row"">
            <div class=""col-md-12 text-center text-dark"" style=""font-family: 'Asap', sans-serif; "">
                <h1 data-aos=""fade-down"" data-aos-delay=""100"" style=""margin-top: 60px; font-size:42px"">Create Your Own Test</h1>
                <h2 data-aos=""fade-right"" data-aos-delay=""100"" style=""margin-bottom: 60px"">The Online Exam Builder You've Been Looking For</h2>
                <h4>Courses</h4>
                <a class=""text-success"" style=""display:inline-block; margin-bottom:60px"" href=""#courses"">
                    <h1 class=""display-3 fas fa-angle-double-down arrow""></h1>
                </a>
            </div>
        </div>
    </div>
</div>
<div class=""container-main-counter"" style=""font-family: 'Asap', sans-serif; "">
    <div class=""container overflow-hidden"">
        <div data-aos=""fade-in"" data-aos-once=""true"" class=""row py-5 d-flex align-items-center"" style=""min-height:45");
            WriteLiteral(@"0px"">
            <h2 class=""col-12 text-center text-light font-weight-bold mb-0"" data-aos=""fade-down"" style=""font-size: 42px; font-family: 'Nunito', sans-serif;"">Numbers Speak Aloud</h2>
            <div class=""col-6 col-md-3 mb-3"">
                <div class=""col-12 border-thick border-primary rounded text-white text-center py-3 rounded-0 shadow"">
                    <p><i class=""fa fa-users text-light"" style=""font-size:50px""></i></p>
                    <h2><span id=""user-counter""></span>+</h2>
                    <h4>Users</h4>
                </div>
            </div>
            <div class=""col-6 col-md-3 mb-3"">
                <div class=""col-12 border-thick border-primary rounded text-white text-center py-3 rounded-0 shadow"">
                    <p><i class=""fas fa-book-open text-light"" style=""font-size:50px""></i></p>
                    <h2><span id=""course-counter""></span>+</h2>
                    <h4>Courses</h4>
                </div>
            </div>
            <div class=""col");
            WriteLiteral(@"-6 col-md-3 mb-3"">
                <div class=""col-12 border-thick border-primary rounded text-white text-center py-3 rounded-0 shadow"">
                    <p><i class=""fas fa-sticky-note text-light"" style=""font-size:50px""></i></p>
                    <h2><span id=""exam-counter""></span>+</h2>
                    <h4>Exams</h4>
                </div>
            </div>
            <div class=""col-6 col-md-3 mb-3"">
                <div class=""col-12 border-thick border-primary rounded text-white text-center py-3 rounded-0 shadow"">
                    <p><i class=""fas fa-question-circle text-light"" style=""font-size:50px""></i></p>
                    <h2><span id=""question-counter""></span>+</h2>
                    <h4>Questions</h4>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""container-main-courses p-0 overflow-hidden"" id=""courses"">
    <div class=""container pt-5"">
        <h2 class=""text-light font-weight-bold"" data-aos=""fade-right"" style=""font-size");
            WriteLiteral(": 46px; font-family: \'Nunito\', sans-serif; \">Course List</h2>\r\n        <div data-aos=\"fade-up\" data-aos-once=\"true\" class=\"row pb-5\" id=\"courses-partial\" style=\"min-height:1060px\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91c5a6595fa5274b74b23937084c1046220ff79214115", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 82 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("           \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91c5a6595fa5274b74b23937084c1046220ff79215845", async() => {
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
                WriteLiteral(@"
    <script>
        var loadingIcon =
                    `<div class=""d-flex align-items-center justify-content-center w-100"" style=""height:768px"">
                        <div class=""fa-3x text-light"">
                            <i class=""fas fa-circle-notch fa-spin""></i>
                        </div>
                    </div>`

        $(function () {
            $('#courses-partial').on('click', 'a', function () {                
                window.location = ""#courses""
                var link = ""/"" + this.href.split(""/"").pop() + ""#courses"";
                $('#courses-partial').html(loadingIcon);
                $.ajax({
                    url: this.href,
                    type: 'GET',
                    cache: false,
                    success: function (result) {
                        $('#courses-partial').html(result);
                        window.history.pushState(""object or string"", ""Title"", link);
                    }
                });
                re");
                WriteLiteral(@"turn false;
            });
        });

        function ajaxBegin() {
            $('#courses-partial').html(loadingIcon);
            window.location = ""#courses"";
        }
        function ajaxSuccess(xhr) {
            var link = ""/?searchterm="" + $(""input[name='searchTerm']"").val() + ""#courses"";
            window.history.pushState(""object or string"", ""Title"", link);
            $('#courses-partial').html(xhr);
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<OnlineExam.Models.ViewModels.HomeCourseVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
