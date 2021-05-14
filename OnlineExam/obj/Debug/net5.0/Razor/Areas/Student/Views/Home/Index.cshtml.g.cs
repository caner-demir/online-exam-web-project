#pragma checksum "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e966957eb274263b994f0b99658618d96e7a4e3c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e966957eb274263b994f0b99658618d96e7a4e3c", @"/Areas/Student/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c26b38a268148b41f8d27cf9435d899b998ac06", @"/Areas/Student/Views/_ViewImports.cshtml")]
    public class Areas_Student_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineExam.Models.ViewModels.CoursesVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/student-home-index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""container-main-counter"">
    <div class=""container"">
        <div class=""row pt-5 pb-5 d-flex align-items-center"" style=""min-height:400px"">
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
<div class=""container-main-courses p-0"">
    <div class=""container"">
        <div class=""row pt-5 pb-5"">
");
#nullable restore
#line 41 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
             foreach (var course in Model.Courses)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3\">\r\n                    <div class=\"card mb-4 shadow border border-success\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1940, "\"", 1962, 1);
#nullable restore
#line 45 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
WriteAttributeValue("", 1946, course.ImageUrl, 1946, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top shadow-sm\" style=\"width:100%; height:225px\" />\r\n                        <div class=\"card-body text-dark\">\r\n                            <h5 class=\"font-weight-bolder text-secondary\">");
#nullable restore
#line 47 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
                                                                     Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <div class=\"d-flex justify-content-between text-black-50\">\r\n                                <p style=\"font-size:small\"><i class=\"fas fa-user\"></i>&nbsp; By ");
#nullable restore
#line 49 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
                                                                                           Write(course.ApplicationUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p style=\"font-size:small\">\r\n                                    <i class=\"fas fa-users\"></i>&nbsp;\r\n                                    ");
#nullable restore
#line 52 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
                               Write(Model.CourseUsers.Where(cu => cu.CourseId == course.Id).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Students
                                </p>
                            </div>
                            <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-sm btn-danger text-light"">View</button>
");
#nullable restore
#line 59 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
                                     if (User.Identity.IsAuthenticated)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button type=\"button\" class=\"btn btn-sm btn-success text-light\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3382, "\"", 3421, 3);
            WriteAttributeValue("", 3392, "sendRequest(this,", 3392, 17, true);
#nullable restore
#line 61 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3409, course.Id, 3410, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3420, ")", 3420, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Enroll</button>\r\n");
#nullable restore
#line 62 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <button type=\"button\" class=\"btn btn-sm btn-success text-light\" onclick=\"redirectToLogin()\">Enroll</button>\r\n");
#nullable restore
#line 66 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <small class=\"font-weight-bold text-black-50\">");
#nullable restore
#line 68 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
                                                                         Write(course.DateCreated.ToString("MM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 73 "C:\Users\Caner Demir\Caner\OnlineExam\OnlineExam\Areas\Student\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e966957eb274263b994f0b99658618d96e7a4e3c10974", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineExam.Models.ViewModels.CoursesVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
