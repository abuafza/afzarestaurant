#pragma checksum "G:\College_Doc\Trios_College\Afza\13.C_sharp_Development_Jun132021_Jul092021\Project\Final_Project\afza\afza\Pages\Thanksreservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0659205ec3892dc1b998be3df4c6edd37e38873b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(afza.Pages.Pages_Thanksreservation), @"mvc.1.0.razor-page", @"/Pages/Thanksreservation.cshtml")]
namespace afza.Pages
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
#line 1 "G:\College_Doc\Trios_College\Afza\13.C_sharp_Development_Jun132021_Jul092021\Project\Final_Project\afza\afza\Pages\_ViewImports.cshtml"
using afza;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0659205ec3892dc1b998be3df4c6edd37e38873b", @"/Pages/Thanksreservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2d70f5b66d8e5542bfe83ee6e37e18caee64ff", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Thanksreservation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Reservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "G:\College_Doc\Trios_College\Afza\13.C_sharp_Development_Jun132021_Jul092021\Project\Final_Project\afza\afza\Pages\Thanksreservation.cshtml"
  
    ViewData["Title"] = "ThanksReservation";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section id=\"showcase3\">\r\n    <div class=\"box-showcase3\">\r\n        <div class=\"content-showcase3\">\r\n            <h3>Hi ");
#nullable restore
#line 9 "G:\College_Doc\Trios_College\Afza\13.C_sharp_Development_Jun132021_Jul092021\Project\Final_Project\afza\afza\Pages\Thanksreservation.cshtml"
              Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h3>\r\n            <h3>Here is your booking information:</h3>\r\n            <div style=\"text-align:justify\">\r\n                <p><b>Email: </b> ");
#nullable restore
#line 12 "G:\College_Doc\Trios_College\Afza\13.C_sharp_Development_Jun132021_Jul092021\Project\Final_Project\afza\afza\Pages\Thanksreservation.cshtml"
                             Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><b>Phone Number: </b>");
#nullable restore
#line 13 "G:\College_Doc\Trios_College\Afza\13.C_sharp_Development_Jun132021_Jul092021\Project\Final_Project\afza\afza\Pages\Thanksreservation.cshtml"
                                   Write(Model.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><b>Booking Table No:</b> ");
#nullable restore
#line 14 "G:\College_Doc\Trios_College\Afza\13.C_sharp_Development_Jun132021_Jul092021\Project\Final_Project\afza\afza\Pages\Thanksreservation.cshtml"
                                       Write(Model.tableno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><b>Date of reservation: </b>");
#nullable restore
#line 15 "G:\College_Doc\Trios_College\Afza\13.C_sharp_Development_Jun132021_Jul092021\Project\Final_Project\afza\afza\Pages\Thanksreservation.cshtml"
                                          Write(Model.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><b>Nuber of Guest:</b> ");
#nullable restore
#line 16 "G:\College_Doc\Trios_College\Afza\13.C_sharp_Development_Jun132021_Jul092021\Project\Final_Project\afza\afza\Pages\Thanksreservation.cshtml"
                                     Write(Model.guest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h3>Print your information</h3>\r\n                <a class=\"btn btn-primary\" onclick=\"window.print()\">Print</a>\r\n            </div>\r\n            <br />\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0659205ec3892dc1b998be3df4c6edd37e38873b6458", async() => {
                WriteLiteral("Book another Table");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<afza.Pages.ThanksreservationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<afza.Pages.ThanksreservationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<afza.Pages.ThanksreservationModel>)PageContext?.ViewData;
        public afza.Pages.ThanksreservationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591