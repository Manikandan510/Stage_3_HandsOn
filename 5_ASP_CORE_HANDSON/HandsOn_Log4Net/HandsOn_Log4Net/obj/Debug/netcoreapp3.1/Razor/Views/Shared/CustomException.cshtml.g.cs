#pragma checksum "D:\C#\Stage_3Handsons\5_ASP_CORE_HANDSON\HandsOn_Log4Net\HandsOn_Log4Net\Views\Shared\CustomException.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfbd3c3f9c9710f1226726aac32c37f093ec0044"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomException), @"mvc.1.0.view", @"/Views/Shared/CustomException.cshtml")]
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
#line 1 "D:\C#\Stage_3Handsons\5_ASP_CORE_HANDSON\HandsOn_Log4Net\HandsOn_Log4Net\Views\_ViewImports.cshtml"
using HandsOn_Log4Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\Stage_3Handsons\5_ASP_CORE_HANDSON\HandsOn_Log4Net\HandsOn_Log4Net\Views\_ViewImports.cshtml"
using HandsOn_Log4Net.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfbd3c3f9c9710f1226726aac32c37f093ec0044", @"/Views/Shared/CustomException.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e84b235bc7e57ae6dfa2e3b0948fefce4d6d739", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CustomException : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Custom Exception</h1>\r\n");
#nullable restore
#line 5 "D:\C#\Stage_3Handsons\5_ASP_CORE_HANDSON\HandsOn_Log4Net\HandsOn_Log4Net\Views\Shared\CustomException.cshtml"
  
    Exception ex = ViewData["HandleException"] as Exception;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 9 "D:\C#\Stage_3Handsons\5_ASP_CORE_HANDSON\HandsOn_Log4Net\HandsOn_Log4Net\Views\Shared\CustomException.cshtml"
Write(ex.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div>");
#nullable restore
#line 10 "D:\C#\Stage_3Handsons\5_ASP_CORE_HANDSON\HandsOn_Log4Net\HandsOn_Log4Net\Views\Shared\CustomException.cshtml"
Write(ex.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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