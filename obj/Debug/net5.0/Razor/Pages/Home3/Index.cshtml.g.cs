#pragma checksum "C:\Users\ChristelleNyauchi\desktop\coding\NSC47\NAME\Pages\Home3\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76ae492067fcd766dbd4e3895170650cb6560ef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NAME.Pages.Home3.Pages_Home3_Index), @"mvc.1.0.razor-page", @"/Pages/Home3/Index.cshtml")]
namespace NAME.Pages.Home3
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
#line 1 "C:\Users\ChristelleNyauchi\desktop\coding\NSC47\NAME\Pages\_ViewImports.cshtml"
using NAME;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76ae492067fcd766dbd4e3895170650cb6560ef6", @"/Pages/Home3/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"993b8c5d85d8ea121eb7d2c0b427239897b052cf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home3_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form my-3 mr-2 ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("md-float-material form-material"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ChristelleNyauchi\desktop\coding\NSC47\NAME\Pages\Home3\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .mdi {
    font-size: 50px
}

.padding {
    padding: 8rem !important
}
body {
    background-color: #f2f7fb
}

.login-block {
    margin: 30px auto;
    min-height: 93.6vh
}

.login-block .auth-box {
    margin: 20px auto 0;
    max-width: 569px !important
}

.contact-us {
    font-size: 24px;
    font-weight: 300
}

.respond {
    font-size: 15px !important;
    font-weight: 200;
    margin-top: -6px
}
}

.card {
    border-radius: 5px;
    -webkit-box-shadow: 0 0 5px 0 rgba(43, 43, 43, .1), 0 11px 6px -7px rgba(43, 43, 43, .1);
    box-shadow: 0 0 5px 0 rgba(43, 43, 43, .1), 0 11px 6px -7px rgba(43, 43, 43, .1);
    border: none;
    margin-bottom: 30px;
    -webkit-transition: all .3s ease-in-out;
    transition: all .3s ease-in-out
}

.card .card-block {
    padding: 1.25rem
}

.f-56 {
    font-size: 56px
}

.form-group {
    margin-bottom: 1.25em
}

.form-material .form-control {
    display: inline-block;
    height: 43px;
    wid");
            WriteLiteral(@"th: 100%;
    border: none;
    border-radius: 0;
    font-size: 16px;
    font-weight: 400;
    padding: 0;
    background-color: transparent;
    -webkit-box-shadow: none;
    box-shadow: none;
    border-bottom: 1px solid #ccc
}

.btn-md {
    padding: 10px 16px;
    font-size: 15px;
    line-height: 23px
}

.btn-primary {
    background-color: #4099ff;
    border-color: #4099ff;
    color: #fff;
    cursor: pointer;
    -webkit-transition: all ease-in .3s;
    transition: all ease-in .3s
}

.btn {
    border-radius: 2px;
    text-transform: capitalize;
    font-size: 15px;
    padding: 10px 19px;
    cursor: pointer
}

.m-b-20 {
    margin-bottom: 20px
}

.btn-md {
    padding: 10px 16px;
    font-size: 15px;
    line-height: 23px
}
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76ae492067fcd766dbd4e3895170650cb6560ef65957", async() => {
                WriteLiteral(@"<div class=""padding"">
    <div style=""text-align: center""> <i class=""mdi mdi-forum""></i> <br>
        <h2 style=""color: #666;"">Contact Us</h2> <br>
        <p class=""text-center"" style=""color:#444;"">Have any Questions? Feel free to contact our Tech Support</p> <br> <button type=""submit"" class=""btn btn-outline-dark ml-sm-2 mb-2"" style=""border-radius: 50px"" data-toggle=""modal"" data-target=""#contact"">&emsp;&emsp;Contact Support&emsp;&emsp;</button>
    </div>
    <!--Contact Modal-->
    <div class=""modal fade"" id=""contact"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content bg-dark"">
                <div class=""modal-header"">
                    <h5 class=""modal-title text-light"" id=""exampleModalLabel"">We would love to hear from you!!</h5> <button type=""button"" class=""close text-light"" data-dismiss=""modal"" aria-label=""Close""> <span aria-hidden=""true"">&times;</span> </button>
      ");
                WriteLiteral("          </div>\r\n                <div class=\"modal-body\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76ae492067fcd766dbd4e3895170650cb6560ef67413", async() => {
                    WriteLiteral(@"
                        <div class=""form-row"">
                            <div class=""form-group col-sm""> <label for=""exampleInputEmail1"" style=""color: #fff;"">Enter Name</label> <input type=""text"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""First""> </div>
                            <div class=""form-group col-sm""> <label class=""sm-lbl"" for=""exampleInputEmail1"" style=""color:rgba(0, 0, 0, 0); visibility: hidden;"">Enter Name</label> <input type=""text"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Last""> </div>
                        </div>
                        <div class=""form-group""> <label for=""exampleInputEmail1"" style=""color: #fff;"">Enter Email</label> <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp""");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 3892, "\"", 3906, 0);
                    EndWriteAttribute();
                    WriteLiteral(@"> </div>
                        <div class=""form-group""> <label for=""exampleFormControlTextarea1"" style=""color: #fff;"">Your Query or Question</label> <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""2""></textarea> </div>
                    ");
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
                WriteLiteral(@"
                </div>
                <div class=""modal-footer""> <button type=""button"" class=""btn btn-outline-light ml-sm-2"" style=""border-radius: 50px; width:100%;"" data-dismiss=""modal"" aria-label=""Close"">Submit</button> </div>
            </div>
        </div>
    </div>
</div>
 <section class=""login-block"">
     <div class=""container-fluid"">
         <div class=""row"">
             <div class=""col-sm-12"">
                 ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76ae492067fcd766dbd4e3895170650cb6560ef610606", async() => {
                    WriteLiteral(@"
                     <div class=""auth-box card"">
                         <div class=""card-block"">
                             <div class=""row"">
                                 <div class=""col-md-12"">
                                     <h3 class=""text-center""><i class=""fa fa-phone-square text-primary f-56""></i></h3>
                                     <h3 class=""text-center contact-us"">Contact Us</h3>
                                     <h6 class=""text-center respond"">(we generally respond in 24 hours)</h6>
                                 </div>
                             </div>
                             <div class=""row"">
                                 <div class=""col-md-6"">
                                     <div class=""form-group form-primary""> <input type=""text"" name=""email"" class=""form-control text-left"" placeholder=""Name""");
                    BeginWriteAttribute("required", " required=\"", 5533, "\"", 5544, 0);
                    EndWriteAttribute();
                    WriteLiteral(@"> </div>
                                 </div>
                                 <div class=""col-md-6"">
                                     <div class=""form-group form-primary""> <input type=""text"" name=""email"" class=""form-control text-left"" placeholder=""Email""");
                    BeginWriteAttribute("required", " required=\"", 5810, "\"", 5821, 0);
                    EndWriteAttribute();
                    WriteLiteral("> </div>\r\n                                 </div>\r\n                             </div>\r\n                             <div class=\"form-group form-primary\"> <input type=\"text\" name=\"email\" class=\"form-control text-left\" placeholder=\"Message\"");
                    BeginWriteAttribute("required", " required=\"", 6061, "\"", 6072, 0);
                    EndWriteAttribute();
                    WriteLiteral(@"> </div>
                             <div class=""row"">
                                 <div class=""col-md-12"">
                                     <button type=""button"" class=""btn btn-primary btn-md btn-block waves-effect text-center m-b-20""><i class=""fa fa-phone""></i> Contact Now </button>
                                 </div>
                             </div>
                         </div>
                     </div>
                 ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n             </div>\r\n         </div>\r\n     </div>\r\n </section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
