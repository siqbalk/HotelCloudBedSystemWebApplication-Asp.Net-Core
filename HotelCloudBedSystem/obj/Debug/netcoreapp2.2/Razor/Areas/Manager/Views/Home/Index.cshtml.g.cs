#pragma checksum "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1bfa8374624df7a0a55c71ac8a98fec1518d8e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Manager/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manager/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Manager_Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1bfa8374624df7a0a55c71ac8a98fec1518d8e1", @"/Areas/Manager/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Manager/Views/_ViewImports.cshtml")]
    public class Areas_Manager_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(45, 585, true);
            WriteLiteral(@"

<div class=""content-wrapper"" style=""min-height: 960px;margin-left:-10px;min-width:100px;"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <h1>
            Dashboard
            <small>Version 2.0</small>
        </h1>
        <ol class=""breadcrumb"">
            <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
            <li class=""active"">Dashboard</li>
        </ol>
    </section>

    <!-- Main content -->
    <section class=""content"">
        <!-- Info boxes -->
        <div class=""row"">

            ");
            EndContext();
            BeginContext(631, 101, false);
#line 26 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("HotelCloudBedSystem.Areas.Manager.ViewComponents.ManagerDashBoardCount"));

#line default
#line hidden
            EndContext();
            BeginContext(732, 1707, true);
            WriteLiteral(@"
        </div>
        <!-- /.row -->

        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""box"">
                    <div class=""box-header with-border"">
                        <h1 class=""box-title""><i class=""fa fa-hotel""> Hotel Info</i></h1>

                        <div class=""box-tools pull-right"">
                            <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                                <i class=""fa fa-minus""></i>
                            </button>
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-box-tool dropdown-toggle"" data-toggle=""dropdown"">
                                    <i class=""fa fa-wrench""></i>
                                </button>
                                <ul class=""dropdown-menu"" role=""menu"">
                                    <li><a href=""#"">Action</a></li>
                                    <li><a href");
            WriteLiteral(@"=""#"">Another action</a></li>
                                    <li><a href=""#"">Something else here</a></li>
                                    <li class=""divider""></li>
                                    <li><a href=""#"">Separated link</a></li>
                                </ul>
                            </div>
                            <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                        </div>
                    </div>
                    <!-- /.box-header -->
                    <div class=""box-body"">
                        <div class=""row"">


                            ");
            EndContext();
            BeginContext(2440, 89, false);
#line 60 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Home\Index.cshtml"
                       Write(await Component.InvokeAsync("HotelCloudBedSystem.Areas.Manager.ViewComponents.FloorList"));

#line default
#line hidden
            EndContext();
            BeginContext(2529, 156, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                            <!-- /.col -->\r\n                            <!--fjwhgwejrgjheoiroglgneojgiegieojrgoejro-->\r\n                            ");
            EndContext();
            BeginContext(2686, 89, false);
#line 66 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Manager\Views\Home\Index.cshtml"
                       Write(await Component.InvokeAsync("HotelCloudBedSystem.Areas.Manager.ViewComponents.HotelRoom"));

#line default
#line hidden
            EndContext();
            BeginContext(2775, 839, true);
            WriteLiteral(@"

                            <!-- /.col -->
                        </div>
                        <!-- /.row -->
                    </div>
                    <!-- ./box-body -->
                    <div class=""box-footer"">
                        <!-- /.row -->
                    </div>
                    <!-- /.box-footer -->
                </div>
                <!-- /.box -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
        <!-- Main row -->
        <div class=""row"">
            <!-- Left col -->
            <div class=""col-md-8"" style=""width:1100px;"">
                <!-- MAP & BOX PANE -->
                <div class=""box box-success"">
                    <!-- /.box-header -->
                    <div class=""box-body no-padding"" style=""left:300px;"">
");
            EndContext();
            BeginContext(3731, 187, true);
            WriteLiteral("\r\n                        <!-- /.col -->\r\n                        <!-- /.row -->\r\n                    </div>\r\n\r\n                    <div class=\"box-body no-padding\" style=\"left:300px;\">\r\n");
            EndContext();
            BeginContext(4036, 485, true);
            WriteLiteral(@"
                        <!-- /.col -->
                        <!-- /.row -->
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box --
                <!-- /.row -->
                <!-- TABLE: LATEST ORDERS -->
                <!-- /.box -->
            </div>
            <!-- /.col -->
            <!-- /.col -->
        </div>
        <!-- /.row -->

    </section>
    <!-- /.content -->
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
