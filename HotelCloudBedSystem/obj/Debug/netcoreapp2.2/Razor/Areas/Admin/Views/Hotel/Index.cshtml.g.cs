#pragma checksum "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfc293c722fc09a5c92866afe166c314e19615e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Hotel_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Hotel/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Hotel/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Hotel_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfc293c722fc09a5c92866afe166c314e19615e4", @"/Areas/Admin/Views/Hotel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Hotel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelCloudBedSystem.Models.Hotel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Hotel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "_AddHotel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddHotelbtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteHotel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("HotelList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HotelDetailList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bootbox.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
  
    ViewData["Title"] = "AllUserList";

#line default
#line hidden
            BeginContext(101, 573, true);
            WriteLiteral(@"
<section class=""content-header"">
    <h1>
        UsersList
        <small>All Users</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">Tables</a></li>
        <li class=""active"">Data tables</li>
    </ol>
</section>

<div class=""box-body"" id=""hotellist"">
    <div id=""example1_wrapper"" class=""dataTables_wrapper form-inline dt-bootstrap"">
        <div class=""row"">
            <div class=""text-center"" style=""margin-top:30px;margin-left:-650px;"">

                ");
            EndContext();
            BeginContext(675, 28, false);
#line 23 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
           Write(Html.Partial("Pages", Model));

#line default
#line hidden
            EndContext();
            BeginContext(703, 87, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <div style=\"margin-left:-180px;\">\r\n                ");
            EndContext();
            BeginContext(791, 95, false);
#line 27 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
           Write(await Component.InvokeAsync("HotelCloudBedSystem.Areas.Admin.ViewComponents.HotelSearchByName"));

#line default
#line hidden
            EndContext();
            BeginContext(886, 102, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\" style=\"margin-left:900px\">\r\n                ");
            EndContext();
            BeginContext(988, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfc293c722fc09a5c92866afe166c314e19615e48608", async() => {
                BeginContext(1107, 52, true);
                WriteLiteral("\r\n                    Add New User\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1163, 59, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-sm-12\">\r\n");
            EndContext();
#line 35 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
                 if (Model == null)
                {

#line default
#line hidden
            BeginContext(1278, 127, true);
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        Empty Data Found..\r\n                    </div>\r\n");
            EndContext();
#line 40 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1465, 1166, true);
            WriteLiteral(@"                    <table id=""example1"" class=""table table-bordered table-striped dataTable"" role=""grid"" aria-describedby=""example1_info"" style=""margin-top:25px;margin-left:100px;"">
                        <thead>
                            <tr role=""row"">
                                <th class=""sorting_asc"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Rendering engine: activate to sort column descending"" style=""width:20px;"">Hotel Name</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-label=""Browser: activate to sort column ascending"" style=""width: 40px;"">City</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-label=""Engine version: activate to sort column ascending"" style=""width: 60px;"">No of Floors</th>
                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1");
            WriteLiteral("\" colspan=\"1\" aria-label=\"CSS grade: activate to sort column ascending\" style=\"width: 40px;margin-left:-100px;height:20px;\">No Of Rooms</th>\r\n");
            EndContext();
            BeginContext(2873, 312, true);
            WriteLiteral(@"                                <th class=""sorting"" tabindex=""0"" aria-controls=""example1"" rowspan=""1"" colspan=""1"" aria-label=""CSS grade: activate to sort column ascending"" style=""width: 150px;"">Actions</th>
                            </tr>
                        </thead>
                        <tbody>

");
            EndContext();
#line 56 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
                             foreach (var hotel in Model)
                            {

#line default
#line hidden
            BeginContext(3275, 161, true);
            WriteLiteral("                                <tr role=\"row\" class=\"odd\">\r\n                                    <td class=\"sorting_1\">\r\n                                        ");
            EndContext();
            BeginContext(3437, 15, false);
#line 60 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
                                   Write(hotel.HotelName);

#line default
#line hidden
            EndContext();
            BeginContext(3452, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3580, 15, false);
#line 63 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
                                   Write(hotel.HotelCity);

#line default
#line hidden
            EndContext();
            BeginContext(3595, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3723, 16, false);
#line 66 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
                                   Write(hotel.NoOfFloors);

#line default
#line hidden
            EndContext();
            BeginContext(3739, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3867, 15, false);
#line 69 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
                                   Write(hotel.NoOfRooms);

#line default
#line hidden
            EndContext();
            BeginContext(3882, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
            BeginContext(4106, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4188, 240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfc293c722fc09a5c92866afe166c314e19615e415731", async() => {
                BeginContext(4309, 115, true);
                WriteLiteral("\r\n                                            <i class=\"fa fa-trash\"></i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
                                                                                                                                     WriteLiteral(hotel.HotelId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4428, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4470, 260, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfc293c722fc09a5c92866afe166c314e19615e418825", async() => {
                BeginContext(4612, 114, true);
                WriteLiteral("\r\n                                            <i class=\"fa fa-list\"></i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(" ");
#line 78 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
                                                                                                                                                          WriteLiteral(hotel.HotelId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4730, 88, true);
            WriteLiteral("\r\n\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 85 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4849, 68, true);
            WriteLiteral("\r\n                        </tbody>\r\n\r\n                    </table>\r\n");
            EndContext();
#line 90 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4936, 135, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"text-center\" style=\"margin-top:15px;margin-left:-650px;\">\r\n    ");
            EndContext();
            BeginContext(5072, 28, false);
#line 98 "D:\HiaerNetdata\FYP\HotelCloudBedSystem\HotelCloudBedSystem\Areas\Admin\Views\Hotel\Index.cshtml"
Write(Html.Partial("Pages", Model));

#line default
#line hidden
            EndContext();
            BeginContext(5100, 169, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"modal\" id=\"rolemoodal\">\r\n\r\n</div>\r\n\r\n<div class=\"modal\" id=\"AddHotelModal\">\r\n\r\n</div>\r\n\r\n<div class=\"modal\" id=\"UpdateUserModal\">\r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5286, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5292, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfc293c722fc09a5c92866afe166c314e19615e423612", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5332, 6954, true);
                WriteLiteral(@"
    <script>
        $(function () {
            //Create
            $(""#AddHotelbtn"").on(""click"", function (e) {
                e.preventDefault();
                var btn = $(this);
                console.log(""Button 1 is working..."");
                $.ajax({
                    async: true,
                    url: btn.attr('href'),
                    type: 'GET',
                    success: function (response) {
                        $(""#AddHotelModal"").html(response);
                        $(""#AddHotelModal"").modal('show');
                    }
                });
            });

            //get HotelProfile
            $(""#HotelList"").on(""click"", function (e) {
                e.preventDefault();
                var btn = $(this);
                console.log(""Button 1 is working..."");
                $.ajax({
                    async: true,

                    url: btn.attr('href'),
                    type: 'GET',
                    success: function (resp");
                WriteLiteral(@"onse) {
                        //$(""#rolemoodal"").html(response);
                        //$(""#rolemoodal"").modal('show');
                    }
                });
            });


            //FormCreate
            $(document.body).delegate("".FormCreate"", ""submit"", function (e) {
                e.preventDefault();
                console.log(""Button is working"");
                var frm = $(this);

                $.ajax({
                    async: true,
                    url: frm.attr('action'),
                    type: frm.attr('method'),
                    data: frm.serialize(),
                    success: function (response) {
                        if (response.status == true) {

                            bootbox.alert(response.message);

                            // refresh data grid
                            $.ajax({
                                async: true,
                                url: '/Admin/Hotel/Index/',
                                ty");
                WriteLiteral(@"pe: 'GET',
                                success: function (data) {
                                    $(""#hotellist"").html(data);
                                },
                                error: function () {

                                }
                            });

                            // hide modal
                            $(""#AddHotelModal"").modal('hide');
                        } else {
                            console.warn(response.message);
                        }
                    },
                    error: function () {

                    }
                });

            });




            //Update
            $("".js-update"").on(""click"", function (e) {
                e.preventDefault();
                var btn = $(this);
                console.log(""Button 1 is working..."");
                $.ajax({
                    async: true,
                    url: btn.attr('href'),
                    type: 'GET',
            ");
                WriteLiteral(@"        success: function (response) {
                        $(""#UpdateUserModal"").html(response);
                        $(""#UpdateUserModal"").modal('show');
                    }
                });
            });




            //FormUpdate
            $(document.body).delegate("".FormUpdate"", ""submit"", function (e) {
                e.preventDefault();
                console.log(""Button is working"");
                var frm = $(this);

                $.ajax({
                    url: frm.attr('action'),
                    type: frm.attr('method'),
                    data: frm.serialize(),
                    success: function (response) {
                        if (response.status == true) {

                            bootbox.alert(response.message);

                            // refresh data grid
                            $.ajax({
                                url: '/Admin/AppUser/AllUserList/',
                                type: 'GET',
                   ");
                WriteLiteral(@"             success: function (data) {
                                    $(""#Alluserlist"").html(data);
                                },
                                error: function () {

                                }
                            });

                            // hide modal
                            $(""#UpdateUserModal"").modal('hide');
                        } else {
                            console.warn(response.message);
                        }
                    },
                    error: function () {

                    }
                });

            });


            //Assign Role
            $("".js-userroledetail"").on(""click"", function (e) {
                e.preventDefault();
                var btn = $(this);
                console.log(""Button 1 is working..."");
                $.ajax({
                    url: btn.attr('href'),
                    type: 'GET',
                    success: function (response) {
            ");
                WriteLiteral(@"            $(""#rolemoodal"").html(response);
                        $(""#rolemoodal"").modal('show');
                    }
                });
            });

            //delete

            $("".js-user-delete"").on(""click"", function (e) {
                e.preventDefault();

                var btn = $(this);

                bootbox.confirm(""Are you sure to delete the record?"", function (result) {
                    console.log(""Btn working"")
                    if (result) {
                        $.ajax({
                            url: btn.attr('href'),
                            type: 'Get',
                            data: { id: btn.attr('data-id') },
                            success: function (response) {
                                if (response.status) {
                                    bootbox.alert(response.message);

                                    // refresh data grid
                                    $.ajax({
                                      ");
                WriteLiteral(@"  url: '/Admin/AppUser/AllUserList/',
                                        type: 'GET',
                                        success: function (data) {
                                            $(""#Alluserlist"").html(data);
                                        },
                                        error: function () {

                                        }
                                    });
                                } else {
                                    bootbox.alert(response.message);
                                }
                            },
                            error: function () {

                            }
                        });
                    }
                });
            });
        });
    </script>

");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelCloudBedSystem.Models.Hotel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
