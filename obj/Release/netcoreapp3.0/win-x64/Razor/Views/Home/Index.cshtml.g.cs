#pragma checksum "C:\Users\alpert\Downloads\SHARPC\IdentityServer4-master\samples\Quickstarts\3_AspNetCoreAndApis\src\MvcClient\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0945cc72bdc84287c8d4958d354a8697f2fd3bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\alpert\Downloads\SHARPC\IdentityServer4-master\samples\Quickstarts\3_AspNetCoreAndApis\src\MvcClient\Views\_ViewImports.cshtml"
using MvcClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alpert\Downloads\SHARPC\IdentityServer4-master\samples\Quickstarts\3_AspNetCoreAndApis\src\MvcClient\Views\_ViewImports.cshtml"
using MvcClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\alpert\Downloads\SHARPC\IdentityServer4-master\samples\Quickstarts\3_AspNetCoreAndApis\src\MvcClient\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0945cc72bdc84287c8d4958d354a8697f2fd3bf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc1f45ec327c217f62474bbe078819a158424a43", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Claims</h2>\n\n<dl>\n");
#nullable restore
#line 6 "C:\Users\alpert\Downloads\SHARPC\IdentityServer4-master\samples\Quickstarts\3_AspNetCoreAndApis\src\MvcClient\Views\Home\Index.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 8 "C:\Users\alpert\Downloads\SHARPC\IdentityServer4-master\samples\Quickstarts\3_AspNetCoreAndApis\src\MvcClient\Views\Home\Index.cshtml"
       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd>");
#nullable restore
#line 9 "C:\Users\alpert\Downloads\SHARPC\IdentityServer4-master\samples\Quickstarts\3_AspNetCoreAndApis\src\MvcClient\Views\Home\Index.cshtml"
       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n");
#nullable restore
#line 10 "C:\Users\alpert\Downloads\SHARPC\IdentityServer4-master\samples\Quickstarts\3_AspNetCoreAndApis\src\MvcClient\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>\n\n<h2>Properties</h2>\n\n<dl>\n");
#nullable restore
#line 16 "C:\Users\alpert\Downloads\SHARPC\IdentityServer4-master\samples\Quickstarts\3_AspNetCoreAndApis\src\MvcClient\Views\Home\Index.cshtml"
     foreach (var prop in (await Context.AuthenticateAsync()).Properties.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 18 "C:\Users\alpert\Downloads\SHARPC\IdentityServer4-master\samples\Quickstarts\3_AspNetCoreAndApis\src\MvcClient\Views\Home\Index.cshtml"
       Write(prop.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\n        <dd>");
#nullable restore
#line 19 "C:\Users\alpert\Downloads\SHARPC\IdentityServer4-master\samples\Quickstarts\3_AspNetCoreAndApis\src\MvcClient\Views\Home\Index.cshtml"
       Write(prop.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n");
#nullable restore
#line 20 "C:\Users\alpert\Downloads\SHARPC\IdentityServer4-master\samples\Quickstarts\3_AspNetCoreAndApis\src\MvcClient\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>");
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