#pragma checksum "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\Home\SubscribeConfirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b9ab5f3beb11567e6bb6bbb59fdecd567b3688c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SubscribeConfirm), @"mvc.1.0.view", @"/Views/Home/SubscribeConfirm.cshtml")]
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
#line 2 "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\_ViewImports.cshtml"
using T_Shirt_Store.WebUI.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\_ViewImports.cshtml"
using T_Shirt_Store.WebUI.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\_ViewImports.cshtml"
using T_Shirt_Store.WebUI.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\_ViewImports.cshtml"
using T_Shirt_Store.WebUI.AppCode.infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\_ViewImports.cshtml"
using T_Shirt_Store.WebUI.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\_ViewImports.cshtml"
using T_Shirt_Store.WebUI.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b9ab5f3beb11567e6bb6bbb59fdecd567b3688c", @"/Views/Home/SubscribeConfirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c146454e7166413d214fe9f6f694024f6c336318", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SubscribeConfirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommandJsonResponse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\Home\SubscribeConfirm.cshtml"
  
    ViewData["Title"] = "SubscribeConfirm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\Home\SubscribeConfirm.cshtml"
 if (Model.Error)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger text-white d-flex justify-content-center\" role=\"alert\">\n\n    ");
#nullable restore
#line 11 "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\Home\SubscribeConfirm.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
#nullable restore
#line 13 "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\Home\SubscribeConfirm.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-success text-white d-flex justify-content-center\" role=\"alert\">\n    ");
#nullable restore
#line 18 "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\Home\SubscribeConfirm.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b9ab5f3beb11567e6bb6bbb59fdecd567b3688c6405", async() => {
                WriteLiteral("Ana Sehife");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(".\n</div>\n");
#nullable restore
#line 20 "C:\Users\hp\Desktop\T-Shirt Store Solution\T-Shirt Store.WebUI\Views\Home\SubscribeConfirm.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommandJsonResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
