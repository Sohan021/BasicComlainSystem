#pragma checksum "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\MyComplain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0d605aa453273c4142ad2005b526b340ca5ac20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Complain_MyComplain), @"mvc.1.0.view", @"/Views/Complain/MyComplain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Complain/MyComplain.cshtml", typeof(AspNetCore.Views_Complain_MyComplain))]
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
#line 1 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\_ViewImports.cshtml"
using Complain_System;

#line default
#line hidden
#line 2 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\_ViewImports.cshtml"
using Complain_System.Models;

#line default
#line hidden
#line 3 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\_ViewImports.cshtml"
using Complain_System.Models.Auth;

#line default
#line hidden
#line 4 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\_ViewImports.cshtml"
using Complain_System.ViewModels;

#line default
#line hidden
#line 5 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\MyComplain.cshtml"
using Complain_System.Models.Regular;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0d605aa453273c4142ad2005b526b340ca5ac20", @"/Views/Complain/MyComplain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a392109b396bec8b99624aa6973f9e62f8e9fc0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Complain_MyComplain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Complain>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\MyComplain.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 114, true);
            WriteLiteral("<br /><br />\n<div class=\"row\">\n    <div class=\"col-6\">\n        <h2 class=\"text-success\">Complains</h2>\n    </div>\n");
            EndContext();
            BeginContext(381, 266, true);
            WriteLiteral(@"</div>
<br />
<div>
    <table class=""table table-striped border"">
        <tr class=""table-success"">
            <th>
                Details
            </th>
            <th>
                Area
            </th>
            <th>
            </th>
        </tr>
");
            EndContext();
#line 28 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\MyComplain.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(694, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(732, 12, false);
#line 31 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\MyComplain.cshtml"
               Write(item.Details);

#line default
#line hidden
            EndContext();
            BeginContext(744, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(771, 9, false);
#line 32 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\MyComplain.cshtml"
               Write(item.Area);

#line default
#line hidden
            EndContext();
            BeginContext(780, 50, true);
            WriteLiteral("</td>\n                <td></td>\n            </tr>\n");
            EndContext();
#line 35 "F:\Study\SixCrdt\Complain_System\Complain_System\Views\Complain\MyComplain.cshtml"
        }

#line default
#line hidden
            BeginContext(840, 20, true);
            WriteLiteral("    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Complain>> Html { get; private set; }
    }
}
#pragma warning restore 1591
