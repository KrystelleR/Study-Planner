#pragma checksum "F:\BCAD\Semester 4\PROG6212\POE\Part 3\ProjectWebApp\ProjectWebApp\ProjectWebApp\Pages\addStudyHours.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21051567de79d295ec887dc1dd5735aa12016d7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjectWebApp.Pages.Pages_addStudyHours), @"mvc.1.0.razor-page", @"/Pages/addStudyHours.cshtml")]
namespace ProjectWebApp.Pages
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
#line 1 "F:\BCAD\Semester 4\PROG6212\POE\Part 3\ProjectWebApp\ProjectWebApp\ProjectWebApp\Pages\_ViewImports.cshtml"
using ProjectWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21051567de79d295ec887dc1dd5735aa12016d7d", @"/Pages/addStudyHours.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0500c6ef271a43ed46e69229f0eb1a5639d983e5", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_addStudyHours : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:red;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\BCAD\Semester 4\PROG6212\POE\Part 3\ProjectWebApp\ProjectWebApp\ProjectWebApp\Pages\addStudyHours.cshtml"
  
    ViewData["Title"] = "Add Module Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""h-100 gradient-form"">
  <div class=""container py-5 h-100"">
    <div class=""row d-flex justify-content-center align-items-center h-100"">
      <div class=""col-xl-10"">
        <div class=""card rounded-3 text-black"" style=""background-color:white"">
              <div class=""card-body p-md-5 mx-md-4"">

              <h2 class=""text-uppercase text-center mb-5"">Add Study Hours</h2>

              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21051567de79d295ec887dc1dd5735aa12016d7d4712", async() => {
                WriteLiteral(@"

                <div class=""form-outline mb-4"">
                    <label style=""color:black;"">Module Code</label> 
                  <label id=""form3Example3cg"" class=""form-control form-control-lg"" style=""background-color:lightgray"" name=""txtModCode"">");
#nullable restore
#line 20 "F:\BCAD\Semester 4\PROG6212\POE\Part 3\ProjectWebApp\ProjectWebApp\ProjectWebApp\Pages\addStudyHours.cshtml"
                                                                                                                                   Write(Model.label1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label> 
                </div>

                <div class=""form-outline mb-4"">
                    <label style=""color:black;"">Hours remaining for the week</label> 
                  <label id=""form3Example3cg"" class=""form-control form-control-lg"" style=""background-color:lightgray""  name=""txtHrsRem"">");
#nullable restore
#line 25 "F:\BCAD\Semester 4\PROG6212\POE\Part 3\ProjectWebApp\ProjectWebApp\ProjectWebApp\Pages\addStudyHours.cshtml"
                                                                                                                                   Write(Model.label2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label> 
                </div>

                <div class=""form-outline mb-4"">
                  <input type=""number"" id=""form3Example4cdg"" class=""form-control form-control-lg"" name=""txtHrsDone"" placeholder=""Add your Hours Done""/>
                </div>

                 <div class=""form-outline mb-4"">
                     <label style=""color:black;"">Date Done</label> 
                  <input type=""date"" id=""form3Example4cdg"" class=""form-control form-control-lg"" name=""txtDateDone""/>
                </div>
                 
                 ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21051567de79d295ec887dc1dd5735aa12016d7d6901", async() => {
#nullable restore
#line 37 "F:\BCAD\Semester 4\PROG6212\POE\Part 3\ProjectWebApp\ProjectWebApp\ProjectWebApp\Pages\addStudyHours.cshtml"
                                                        Write(Model.Message);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 37 "F:\BCAD\Semester 4\PROG6212\POE\Part 3\ProjectWebApp\ProjectWebApp\ProjectWebApp\Pages\addStudyHours.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Message);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" 

                <div class=""d-flex justify-content-center"">                 
                  <button style=""background-color:#48a169"" type=""submit"" class=""btn btn-primary btn-block fa-lg gradient-custom-2 mb-3"">Add Module</button>
                </div>
              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectWebApp.Pages.addStudyHoursModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjectWebApp.Pages.addStudyHoursModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjectWebApp.Pages.addStudyHoursModel>)PageContext?.ViewData;
        public ProjectWebApp.Pages.addStudyHoursModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
