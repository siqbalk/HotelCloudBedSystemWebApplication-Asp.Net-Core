#pragma checksum "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Shared\Components\ManagerSideBarProfile\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5409272275e094de4ad9140788fb191d2571f171"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Shared_Components_ManagerSideBarProfile_Default), @"mvc.1.0.view", @"/Areas/Manager/Views/Shared/Components/ManagerSideBarProfile/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manager/Views/Shared/Components/ManagerSideBarProfile/Default.cshtml", typeof(AspNetCore.Areas_Manager_Views_Shared_Components_ManagerSideBarProfile_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5409272275e094de4ad9140788fb191d2571f171", @"/Areas/Manager/Views/Shared/Components/ManagerSideBarProfile/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Manager/Views/_ViewImports.cshtml")]
    public class Areas_Manager_Views_Shared_Components_ManagerSideBarProfile_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelCloudBedSystem.Areas.Manager.ViewModels.ManagerProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/img/mkhan.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("woman avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Shared\Components\ManagerSideBarProfile\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(106, 93, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"user-panel\">\r\n    <div class=\"pull-left image\" style=\"margin-top:4px;\">\r\n");
            EndContext();
#line 12 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Shared\Components\ManagerSideBarProfile\Default.cshtml"
         if (Model.AvatarImage == null)
        {


#line default
#line hidden
            BeginContext(253, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(265, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5409272275e094de4ad9140788fb191d2571f1715165", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(344, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Shared\Components\ManagerSideBarProfile\Default.cshtml"
        }
        else
        {
            var base64 = Convert.ToBase64String(Model.AvatarImage);
            var imgsrc = string.Format("data:image/gif;base64,{0}", base64);


#line default
#line hidden
            BeginContext(531, 16, true);
            WriteLiteral("            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\'", 547, "\'", 560, 1);
#line 22 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Shared\Components\ManagerSideBarProfile\Default.cshtml"
WriteAttributeValue("", 553, imgsrc, 553, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(561, 39, true);
            WriteLiteral(" class=\"img-circle\" alt=\"User Image\">\r\n");
            EndContext();
#line 23 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Shared\Components\ManagerSideBarProfile\Default.cshtml"
                                                                        
        }

#line default
#line hidden
            BeginContext(685, 77, true);
            WriteLiteral("    </div>\r\n    <div class=\"pull-left info\" style=\"color:white\">\r\n        <p>");
            EndContext();
            BeginContext(763, 15, false);
#line 27 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Shared\Components\ManagerSideBarProfile\Default.cshtml"
      Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(778, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(780, 14, false);
#line 27 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Shared\Components\ManagerSideBarProfile\Default.cshtml"
                       Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(794, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(812, 11, false);
#line 28 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Shared\Components\ManagerSideBarProfile\Default.cshtml"
      Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(823, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(862, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelCloudBedSystem.Areas.Manager.ViewModels.ManagerProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
