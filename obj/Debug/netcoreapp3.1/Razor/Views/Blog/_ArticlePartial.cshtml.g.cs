#pragma checksum "C:\Users\jvanh\source\repos\VivesBlog\Views\Blog\_ArticlePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63bb941631062a05c7c4c572e07f3c00556d2406"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog__ArticlePartial), @"mvc.1.0.view", @"/Views/Blog/_ArticlePartial.cshtml")]
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
#line 1 "C:\Users\jvanh\source\repos\VivesBlog\Views\_ViewImports.cshtml"
using VivesBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jvanh\source\repos\VivesBlog\Views\_ViewImports.cshtml"
using VivesBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63bb941631062a05c7c4c572e07f3c00556d2406", @"/Views/Blog/_ArticlePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39488c2a4fc597293ada89f3ee25de17ad6e8109", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog__ArticlePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VivesBlog.Models.Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<tr>\n    <td>\n        ");
#nullable restore
#line 11 "C:\Users\jvanh\source\repos\VivesBlog\Views\Blog\_ArticlePartial.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 14 "C:\Users\jvanh\source\repos\VivesBlog\Views\Blog\_ArticlePartial.cshtml"
   Write(Model.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 17 "C:\Users\jvanh\source\repos\VivesBlog\Views\Blog\_ArticlePartial.cshtml"
   Write(Model.AuthorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n    </td>\n    <td>\n        ");
#nullable restore
#line 22 "C:\Users\jvanh\source\repos\VivesBlog\Views\Blog\_ArticlePartial.cshtml"
   Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 25 "C:\Users\jvanh\source\repos\VivesBlog\Views\Blog\_ArticlePartial.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 28 "C:\Users\jvanh\source\repos\VivesBlog\Views\Blog\_ArticlePartial.cshtml"
   Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VivesBlog.Models.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
