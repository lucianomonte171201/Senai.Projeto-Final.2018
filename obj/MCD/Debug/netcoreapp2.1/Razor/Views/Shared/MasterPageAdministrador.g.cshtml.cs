#pragma checksum "C:\Users\Priscila\Downloads\Senai.Comentarios.Final\Views\Shared\MasterPageAdministrador.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad759a0c02e0aec94f6a590e539d29cd7f0ee29b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MasterPageAdministrador), @"mvc.1.0.view", @"/Views/Shared/MasterPageAdministrador.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MasterPageAdministrador.cshtml", typeof(AspNetCore.Views_Shared_MasterPageAdministrador))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad759a0c02e0aec94f6a590e539d29cd7f0ee29b", @"/Views/Shared/MasterPageAdministrador.cshtml")]
    public class Views_Shared_MasterPageAdministrador : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 308, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3946adaae804ffbb27cc452e2b1dbc7", async() => {
                BeginContext(6, 252, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <title>Check Point</title>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <link href=\"/css/style.css\" rel=\"stylesheet\">\r\n    ");
                EndContext();
                BeginContext(259, 40, false);
#line 7 "C:\Users\Priscila\Downloads\Senai.Comentarios.Final\Views\Shared\MasterPageAdministrador.cshtml"
Write(RenderSection("styles", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(299, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(308, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(310, 2022, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09a23f72a6104306a52be1890634241b", async() => {
                BeginContext(316, 271, true);
                WriteLiteral(@"
    <!--TOPO-->
<header class=""top-bar"">
    <div class=""logo"">
        <img src=""/imagens/Logo Checkpoint.png"" alt=""Logo"">
    </div>
    <nav id=""menuTopo"" class=""menu"">
        <ul>
            <li>
                <p class=""usuarioLogado"" href=""/Pages/Home"">");
                EndContext();
                BeginContext(588, 21, false);
#line 18 "C:\Users\Priscila\Downloads\Senai.Comentarios.Final\Views\Shared\MasterPageAdministrador.cshtml"
                                                       Write(ViewBag.UsuarioLogado);

#line default
#line hidden
                EndContext();
                BeginContext(609, 603, true);
                WriteLiteral(@"</p>
            </li>
            <li>
                <a href=""/Pages/Home"">Home</a>
            </li>
            <li>
                <a href=""/Pages/Sobre"">Sobre</a>
            </li>
            <li>
                <a href=""/Pages/Formulario"">Formulário/FAQ</a>
            </li>
            <li>
                <a href=""/Comentario/Gerenciar"">Gerenciar</a>
            </li>
            <li>
                <a href=""/Usuario/Sair"">Sair</a>
            </li>
            
                <p>Tel: XXXX-XXXX</p>
            </li>
        </ul>
    </nav>

</header>

    ");
                EndContext();
                BeginContext(1213, 12, false);
#line 43 "C:\Users\Priscila\Downloads\Senai.Comentarios.Final\Views\Shared\MasterPageAdministrador.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1225, 1100, true);
                WriteLiteral(@"

    <!--CONTATO-->
<footer class=""contato"">
    <h2>Contato</h2>
    <div class=""redes-sociais"">
        <nav class=""icons"">
            <ul>
                <li>
                    <img style=""width: 60px; height: 60px;"" src=""/imagens/twitter-icon.png"" alt="""">
                </li>
                <li>
                    <img style=""width: 50px; height: 50px;"" src=""/imagens/instagram-icon.png"" alt="""">
                </li>
                <li>
                    <img style=""width: 73px; height: 73px;"" src=""/imagens/facebook-icon.png"" alt="""">
                </li>
            </ul>
        </nav>
        <nav id=""menuIcons"" class=""icons-text"">
            <ul>
                <li>
                    <a href=""https://twitter.com/"">Twitter</a>
                </li>
                <li>
                    <a href=""https://www.instagram.com/?hl=pt-br"">Instagram</a>
                </li>
                <li>
                    <a href=""https://www.facebook.com/"">Facebook</a>
     ");
                WriteLiteral("           </li>\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n</footer>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2332, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591