#pragma checksum "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dc3a2ee812dc02a49e5afa36c589d0087a0718a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Accomodations_Details), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Accomodations/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dc3a2ee812dc02a49e5afa36c589d0087a0718a", @"/Areas/Identity/Pages/Account/Accomodations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39f65c779f80c770e28a236101aa13f4bf6ea802", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b71225a0a44b05b3ff51a236fdf14c0d122f35", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Accomodations_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Property</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.MaximumGuests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.MaximumGuests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Available));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.PrivateSpace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.PrivateSpace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Bathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Bathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Bedrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Bedrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Beds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Beds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Province));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Cleanliness));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Cleanliness));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Accuracy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Accuracy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.CheckIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.CheckIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Communication));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Communication));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Properties.Overall));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Properties.Overall));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <h4>Pricing</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 145 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Pricings.RegularRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 148 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Pricings.RegularRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 151 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Pricings.PercentDiscount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 154 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Pricings.PercentDiscount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 157 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Pricings.DiscountedRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 160 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Pricings.DiscountedRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 163 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.Pricings.CleaningFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 166 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.Pricings.CleaningFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dc3a2ee812dc02a49e5afa36c589d0087a0718a24218", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 171 "/Users/salehbicharasenoussi/Projects/ShortTermRental/ShortTermRental/Areas/Identity/Pages/Account/Accomodations/Details.cshtml"
                           WriteLiteral(Model.Property.Properties.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dc3a2ee812dc02a49e5afa36c589d0087a0718a26396", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShortTermRental.Areas.Identity.Pages.Account.Accomodations.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShortTermRental.Areas.Identity.Pages.Account.Accomodations.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ShortTermRental.Areas.Identity.Pages.Account.Accomodations.DetailsModel>)PageContext?.ViewData;
        public ShortTermRental.Areas.Identity.Pages.Account.Accomodations.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
