#pragma checksum "E:\WebApplication5\WebApplication5\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e129eccc80b299bd74c5a5c1dbdc53a6f400431"
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
#line 1 "E:\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e129eccc80b299bd74c5a5c1dbdc53a6f400431", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<catogry>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"featured-services\">\r\n    <div class=\"container aos-init aos-animate\" data-aos=\"fade-up\">\r\n        <div class=\"row\">\r\n            \r\n");
#nullable restore
#line 6 "E:\WebApplication5\WebApplication5\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-6 col-lg-3 d-flex align-items-stretch mb-5 mb-lg-0"">
                   
                        <div class=""icon-box aos-init aos-animate"" style=""width:100%"" data-aos=""fade-up"" data-aos-delay=""100"">
                        <center>
                            <a");
            BeginWriteAttribute("href", " href=\"", 542, "\"", 568, 2);
            WriteAttributeValue("", 549, "/Home/news/", 549, 11, true);
#nullable restore
#line 13 "E:\WebApplication5\WebApplication5\Views\Home\Index.cshtml"
WriteAttributeValue("", 560, item.Id, 560, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"icon\"><i class=\"fas fa-heartbeat\"></i></div>\r\n                                <h4 class=\"title\">");
#nullable restore
#line 15 "E:\WebApplication5\WebApplication5\Views\Home\Index.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p class=\"description\">");
#nullable restore
#line 16 "E:\WebApplication5\WebApplication5\Views\Home\Index.cshtml"
                                                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </a>\r\n                        </center>\r\n                    </div>\r\n                    \r\n                    </div>\r\n");
#nullable restore
#line 22 "E:\WebApplication5\WebApplication5\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </div>\r\n\r\n    </div>\r\n\r\n</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<catogry>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
