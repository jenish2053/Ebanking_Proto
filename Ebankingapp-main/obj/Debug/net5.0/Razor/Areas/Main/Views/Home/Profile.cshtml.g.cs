#pragma checksum "D:\sampleprojects\Jenish\Ebanking-Prototype\Ebankingapp-main\Areas\Main\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "befbe4607a7806cbf79ef9946a0f47a11bc8ef54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Main_Views_Home_Profile), @"mvc.1.0.view", @"/Areas/Main/Views/Home/Profile.cshtml")]
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
#line 1 "D:\sampleprojects\Jenish\Ebanking-Prototype\Ebankingapp-main\Areas\Main\Views\_ViewImports.cshtml"
using EbankingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\sampleprojects\Jenish\Ebanking-Prototype\Ebankingapp-main\Areas\Main\Views\_ViewImports.cshtml"
using MigrationHelper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"befbe4607a7806cbf79ef9946a0f47a11bc8ef54", @"/Areas/Main/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53dfd6460f2b3a118476f38c9cb25be7c1b278d5", @"/Areas/Main/Views/_ViewImports.cshtml")]
    public class Areas_Main_Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MigrationHelper.ViewModels.ProfileInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\sampleprojects\Jenish\Ebanking-Prototype\Ebankingapp-main\Areas\Main\Views\Home\Profile.cshtml"
   Layout = "~/Areas/Main/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "befbe4607a7806cbf79ef9946a0f47a11bc8ef544207", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>

body{
    color: #6F8BA4;
    margin-top:20px;
}
.section {
    padding: 100px 0;
    position: relative;
}
.gray-bg {
    background-color: #f5f5f5;
}
img {
    max-width: 100%;
}
img {
    vertical-align: middle;
    border-style: none;
}
/* About Me 
---------------------*/
.about-text h3 {
  font-size: 45px;
  font-weight: 700;
  margin: 0 0 6px;
}
.media (max-width: 767px) {
  .about-text h3 {
    font-size: 35px;
  }
}
.about-text h6 {
  font-weight: 600;
  margin-bottom: 15px;
}
.media (max-width: 767px) {
  .about-text h6 {
    font-size: 18px;
  }
}
.about-text p {
  font-size: 18px;
  max-width: 450px;
}
.about-text p mark {
  font-weight: 600;
  color: #20247b;
}

.about-list {
  padding-top: 10px;
}
.about-list .media {
  padding: 5px 0;
}
.about-list label {
  color: #20247b;
  font-weight: 600;
  width: 88px;
  margin: 0;
  position: relative;
}
.about-list label:after {
  content: """";
  position: absolute;
  top: 0;
 ");
            WriteLiteral(@" bottom: 0;
  right: 11px;
  width: 1px;
  height: 12px;
  background: #20247b;
  -moz-transform: rotate(15deg);
  -o-transform: rotate(15deg);
  -ms-transform: rotate(15deg);
  -webkit-transform: rotate(15deg);
  transform: rotate(15deg);
  margin: auto;
  opacity: 0.5;
}
.about-list p {
  margin: 0;
  font-size: 15px;
}

.media (max-width: 991px) {
  .about-avatar {
    margin-top: 30px;
  }
}

.about-section .counter {
  padding: 22px 20px;
  background: #ffffff;
  border-radius: 10px;
  box-shadow: 0 0 30px rgba(31, 45, 61, 0.125);
}
.about-section .counter .count-data {
  margin-top: 10px;
  margin-bottom: 10px;
}
.about-section .counter .count {
  font-weight: 700;
  color: #20247b;
  margin: 0 0 5px;
}
.about-section .counter p {
  font-weight: 600;
  margin: 0;
}
mark {
    background-image: linear-gradient(rgba(252, 83, 86, 0.6), rgba(252, 83, 86, 0.6));
    background-size: 100% 3px;
    background-repeat: no-repeat;
    background-position: 0 bottom;
");
            WriteLiteral(@"    background-color: transparent;
    padding: 0;
    color: currentColor;
}
.theme-color {
    color: #fc5356;
}
.dark-color {
    color: #20247b;
}
</style>

<section class=""section about-section gray-bg"" id=""about"">
            <div class=""container"">
                <div class=""row align-items-center"">
                    <div class=""col-lg-6 col-md-4 col-sm-3"">
                        <div class=""about-avatar"">
                            <img src=""https://bootdey.com/img/Content/avatar/avatar7.png""");
            BeginWriteAttribute("title", " title=\"", 6648, "\"", 6656, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6657, "\"", 6663, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"count-data\">\r\n                                <h6 class=\"count h2\" data-to=\"500\" data-speed=\"500\">£");
#nullable restore
#line 204 "D:\sampleprojects\Jenish\Ebanking-Prototype\Ebankingapp-main\Areas\Main\Views\Home\Profile.cshtml"
                                                                                Write(Model.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                <p class=""m-0px font-w-600"">Available Balance</p>
                            </div>
                    </div>
                    <div class=""col-lg-6 col-md-4"">
                        <div class=""about-text go-to"">
                            <h3 class=""dark-color"">");
#nullable restore
#line 210 "D:\sampleprojects\Jenish\Ebanking-Prototype\Ebankingapp-main\Areas\Main\Views\Home\Profile.cshtml"
                                              Write(Model.FullName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <h6 class=\"theme-color lead\">");
#nullable restore
#line 211 "D:\sampleprojects\Jenish\Ebanking-Prototype\Ebankingapp-main\Areas\Main\Views\Home\Profile.cshtml"
                                                    Write(Model.AccNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            <h8 class=\"theme-color lead\">");
#nullable restore
#line 212 "D:\sampleprojects\Jenish\Ebanking-Prototype\Ebankingapp-main\Areas\Main\Views\Home\Profile.cshtml"
                                                    Write(Model.AccountType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h8>
                            <div class=""row about-list"">
                                <div class=""col-md-6"">
                                    <div class=""media"">
                                        <label>Full name</label>
                                        <p>");
#nullable restore
#line 217 "D:\sampleprojects\Jenish\Ebanking-Prototype\Ebankingapp-main\Areas\Main\Views\Home\Profile.cshtml"
                                      Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"media\">\r\n                                        <label>Account No</label>\r\n                                        <p>");
#nullable restore
#line 221 "D:\sampleprojects\Jenish\Ebanking-Prototype\Ebankingapp-main\Areas\Main\Views\Home\Profile.cshtml"
                                      Write(Model.AccNum);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                   
                                    <div class=""media"">
                                        <label>Address</label>
                                        <p>N/A</p>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""media"">
                                        <label>E-mail</label>
                                        <p>N/A</p>
                                    </div>
                                    <div class=""media"">
                                        <label>Phone</label>
                                        <p>N/A</p>
                                    </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
             ");
            WriteLiteral("   </div>\r\n        </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MigrationHelper.ViewModels.ProfileInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
