#pragma checksum "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6b9215ccb88ff0e0cb4cdcc31abf03f88de1f7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Details.cshtml", typeof(AspNetCore.Views_Blog_Details))]
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
#line 1 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\_ViewImports.cshtml"
using BlogMvc;

#line default
#line hidden
#line 2 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\_ViewImports.cshtml"
using BlogMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6b9215ccb88ff0e0cb4cdcc31abf03f88de1f7b", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c424dd8d6a919341ea9bcfb81d5d22179c71c42", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogMvc.Models.Article>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Article</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(209, 48, false);
#line 14 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ArticleTitle));

#line default
#line hidden
            EndContext();
            BeginContext(257, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(321, 44, false);
#line 17 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
       Write(Html.DisplayFor(model => model.ArticleTitle));

#line default
#line hidden
            EndContext();
            BeginContext(365, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(428, 47, false);
#line 20 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ArticleDate));

#line default
#line hidden
            EndContext();
            BeginContext(475, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(539, 43, false);
#line 23 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
       Write(Html.DisplayFor(model => model.ArticleDate));

#line default
#line hidden
            EndContext();
            BeginContext(582, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(645, 50, false);
#line 26 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ArticleContent));

#line default
#line hidden
            EndContext();
            BeginContext(695, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(759, 46, false);
#line 29 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
       Write(Html.DisplayFor(model => model.ArticleContent));

#line default
#line hidden
            EndContext();
            BeginContext(805, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(866, 47, false);
#line 32 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ArticleTags));

#line default
#line hidden
            EndContext();
            BeginContext(913, 49, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            EndContext();
#line 35 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
             foreach (var item in Model.ArticleTags)
            {

#line default
#line hidden
            BeginContext(1031, 17, true);
            WriteLiteral("               <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1048, "\"", 1104, 1);
#line 37 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
WriteAttributeValue("", 1055, Url.Action("Index","Tags", new { @item.TagID } ), 1055, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1105, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1107, 16, false);
#line 37 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
                                                                      Write(item.Tag.TagName);

#line default
#line hidden
            EndContext();
            BeginContext(1123, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 38 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1144, 53, true);
            WriteLiteral("        </dd>        \r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1197, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6b9215ccb88ff0e0cb4cdcc31abf03f88de1f7b8585", async() => {
                BeginContext(1243, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\FerdiAhçıoğlu\Source\Repos\BlogMvc\BlogMvc\Views\Blog\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1251, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1259, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6b9215ccb88ff0e0cb4cdcc31abf03f88de1f7b10904", async() => {
                BeginContext(1281, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1297, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogMvc.Models.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591