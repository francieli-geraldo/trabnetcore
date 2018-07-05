#pragma checksum "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f79132871a7f270c09a1bcbf6a4dc464ce6ec462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_TwoFactorAuthentication), @"mvc.1.0.view", @"/Views/Manage/TwoFactorAuthentication.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/TwoFactorAuthentication.cshtml", typeof(AspNetCore.Views_Manage_TwoFactorAuthentication))]
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
#line 1 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Web.UI;

#line default
#line hidden
#line 3 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Web.UI.Models;

#line default
#line hidden
#line 4 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Web.UI.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\_ViewImports.cshtml"
using Web.UI.Models.ManageViewModels;

#line default
#line hidden
#line 1 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\_ViewImports.cshtml"
using Web.UI.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79132871a7f270c09a1bcbf6a4dc464ce6ec462", @"/Views/Manage/TwoFactorAuthentication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916cdad7c8602f1298d29c870924a9ecbec6da80", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7edfc7c15fee17e32b47d47b512a1f1bbebdd1f5", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_TwoFactorAuthentication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TwoFactorAuthenticationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateRecoveryCodes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Disable2faWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateRecoveryCodesWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnableAuthenticator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResetAuthenticatorWarning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml"
  
    ViewData["Title"] = "Two-factor authentication";
    ViewData.AddActivePage(ManageNavPages.TwoFactorAuthentication);

#line default
#line hidden
            BeginContext(171, 6, true);
            WriteLiteral("\r\n<h4>");
            EndContext();
            BeginContext(178, 17, false);
#line 7 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(195, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 8 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml"
 if (Model.Is2faEnabled)
{
    if (Model.RecoveryCodesLeft == 0)
    {

#line default
#line hidden
            BeginContext(277, 129, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>You have no recovery codes left.</strong>\r\n            <p>You must ");
            EndContext();
            BeginContext(406, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec8fe13684af4c859b4244d692315351", async() => {
                BeginContext(444, 36, true);
                WriteLiteral("generate a new set of recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(484, 66, true);
            WriteLiteral(" before you can log in with a recovery code.</p>\r\n        </div>\r\n");
            EndContext();
#line 16 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml"
    }
    else if (Model.RecoveryCodesLeft == 1)
    {

#line default
#line hidden
            BeginContext(608, 126, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <strong>You have 1 recovery code left.</strong>\r\n            <p>You can ");
            EndContext();
            BeginContext(734, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4e8f5343a9a4ba6846e3cdad14bbc4c", async() => {
                BeginContext(772, 36, true);
                WriteLiteral("generate a new set of recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(812, 23, true);
            WriteLiteral(".</p>\r\n        </div>\r\n");
            EndContext();
#line 23 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml"
    }
    else if (Model.RecoveryCodesLeft <= 3)
    {

#line default
#line hidden
            BeginContext(893, 72, true);
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            <strong>You have ");
            EndContext();
            BeginContext(966, 23, false);
#line 27 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml"
                        Write(Model.RecoveryCodesLeft);

#line default
#line hidden
            EndContext();
            BeginContext(989, 58, true);
            WriteLiteral(" recovery codes left.</strong>\r\n            <p>You should ");
            EndContext();
            BeginContext(1047, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f52074bbbab4316881261e27460a6ae", async() => {
                BeginContext(1085, 36, true);
                WriteLiteral("generate a new set of recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1125, 23, true);
            WriteLiteral(".</p>\r\n        </div>\r\n");
            EndContext();
#line 30 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml"
    }


#line default
#line hidden
            BeginContext(1157, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1161, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2140876a32d4368a8a42232daea0b10", async() => {
                BeginContext(1219, 11, true);
                WriteLiteral("Disable 2FA");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1234, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1240, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da01ff3d6cf74c24adc0d84d21c29043", async() => {
                BeginContext(1309, 20, true);
                WriteLiteral("Reset recovery codes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1333, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml"
}

#line default
#line hidden
            BeginContext(1338, 30, true);
            WriteLiteral("\r\n<h5>Authenticator app</h5>\r\n");
            EndContext();
#line 37 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml"
 if (!Model.HasAuthenticator)
{

#line default
#line hidden
            BeginContext(1402, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1406, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d07cd10c437044138d20d066ae699e5e", async() => {
                BeginContext(1466, 21, true);
                WriteLiteral("Add authenticator app");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1491, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1505, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1509, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdfae395dfd942c2af130c091959f5db", async() => {
                BeginContext(1569, 27, true);
                WriteLiteral("Configure authenticator app");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1600, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1606, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51f02174cec043f28f692e77c5f3c501", async() => {
                BeginContext(1672, 23, true);
                WriteLiteral("Reset authenticator key");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1699, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 45 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml"
}

#line default
#line hidden
            BeginContext(1704, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1724, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1731, 52, false);
#line 48 "C:\Users\Fran\Documents\Visual Studio 2017\Projects\prof\MaisCadastros\Web.UI\Views\Manage\TwoFactorAuthentication.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(1783, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TwoFactorAuthenticationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
