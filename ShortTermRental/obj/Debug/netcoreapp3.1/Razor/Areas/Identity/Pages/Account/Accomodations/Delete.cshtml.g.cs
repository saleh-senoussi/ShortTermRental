#pragma checksum "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f9e9d5c0ad71c80534ed0d4d682a1888fca390c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Accomodations_Delete), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml")]
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
#line 1 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/_ViewImports.cshtml"
using ShortTermRental.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/_ViewImports.cshtml"
using ShortTermRental.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/_ViewImports.cshtml"
using ShortTermRental.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using ShortTermRental.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9e9d5c0ad71c80534ed0d4d682a1888fca390c", @"/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39f65c779f80c770e28a236101aa13f4bf6ea802", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b71225a0a44b05b3ff51a236fdf14c0d122f35", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Accomodations_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Property</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.MaximumGuests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.MaximumGuests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.PrivateSpace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.PrivateSpace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Bathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Bathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Bedrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Bedrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Beds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Beds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.HostId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.HostId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Cleanliness));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Cleanliness));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 112 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Accuracy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 115 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Accuracy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 118 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.CheckIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 121 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.CheckIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 124 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Communication));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 127 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Communication));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 130 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 133 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 136 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 139 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 142 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Overall));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 145 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Property.Overall));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9e9d5c0ad71c80534ed0d4d682a1888fca390c22041", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1f9e9d5c0ad71c80534ed0d4d682a1888fca390c22306", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 150 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Property.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f9e9d5c0ad71c80534ed0d4d682a1888fca390c24126", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShortTermRental.Areas.Identity.Pages.Account.Accomodations.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShortTermRental.Areas.Identity.Pages.Account.Accomodations.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShortTermRental.Areas.Identity.Pages.Account.Accomodations.DeleteModel>)PageContext?.ViewData;
        public ShortTermRental.Areas.Identity.Pages.Account.Accomodations.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
