#pragma checksum "C:\Users\Priscila\Downloads\Senai.Comentarios.Final\Views\Pages\Formulario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "632e623f947880837b44c0091913f022edd9b2d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_Formulario), @"mvc.1.0.view", @"/Views/Pages/Formulario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pages/Formulario.cshtml", typeof(AspNetCore.Views_Pages_Formulario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"632e623f947880837b44c0091913f022edd9b2d0", @"/Views/Pages/Formulario.cshtml")]
    public class Views_Pages_Formulario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Priscila\Downloads\Senai.Comentarios.Final\Views\Pages\Formulario.cshtml"
 if(@ViewBag.UsuarioLogado == null){
        Layout = "MasterPageDeslogado";
} else {
    if (@ViewBag.AdminBool == true)
    {
        Layout = "MasterPageAdministrador";
    } else {
        Layout = "MasterPageLogado";
    }
}

#line default
#line hidden
            BeginContext(240, 67, true);
            WriteLiteral("\r\n\r\n    <link rel=\"stylesheet\" href=\"css/formulario.css\">\r\n    \r\n\r\n");
            EndContext();
            BeginContext(307, 3424, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f69418b4df464ca09adb82b53b4b4be4", async() => {
                BeginContext(313, 3411, true);
                WriteLiteral(@"
    
    <main>
        <!--SEÇÃO DÚVIDAS-->
        <section class=""duvidas fullscreen"">
            <!--TOPO - DÚVIDAS-->
            <div class=""top-duvidas"">
                <div class=""duvidas-title"">
                    <h2>Dúvidas</h2>
                </div>
                <div class=""quebra"">
                    <img src=""/imagens/location_icon.png"" alt="""">
                </div>
            </div>
            <!--CONTEÚDO - DÚVIDAS-->
            <div class=""quadrados"">
                <div class=""quadrado"">
                    <h3>Planos
                        <img style=""width: 25px; height: 25px; transform: translateX(10.2em) rotateY(180deg);"" src=""/imagens/Seta (1).png"" alt="""">
                    </h3>
                    <h3>Como comprar?
                        <img style=""width: 25px; height: 25px; transform: translateX(7.9em);"" src=""/imagens/Seta (1).png"" alt="""">
                    </h3>
                    <h3>Cancelamento do Plano
                        <img style");
                WriteLiteral(@"=""width: 25px; height: 25px;"" src=""/imagens/Seta (1).png"" alt="""">
                    </h3>
                    <h3 style=""text-transform: lowercase;"">lorem ipsum
                        <img style=""width: 25px; height: 25px; transform: translateX(9.4em);"" src=""/imagens/Seta (1).png"" alt="""">
                    </h3>
                    <h3 style=""text-transform: lowercase;"">lorem ipsum
                        <img style=""width: 25px; height: 25px; transform: translateX(9.4em);"" src=""/imagens/Seta (1).png"" alt="""">
                    </h3>
                    <h3 style=""text-transform: lowercase;"">lorem ipsum
                        <img style=""width: 25px; height: 25px; transform: translateX(9.4em);"" src=""/imagens/Seta (1).png"" alt="""">
                    </h3>
                    <h3 style=""text-transform: lowercase;"">lorem ipsum
                        <img style=""width: 25px; height: 25px; transform: translateX(9.4em);"" src=""/imagens/Seta (1).png"" alt="""">
                    </h3>
               ");
                WriteLiteral(@"     <h3 style=""text-transform: lowercase;"">lorem ipsum
                        <img style=""width: 25px; height: 25px; transform: translateX(9.4em);"" src=""/imagens/Seta (1).png"" alt="""">
                    </h3>
                </div>
                <div class=""quadrado2"">
                    <h3>Como funcionam os planos?
                    </h3>
                    <h3>Posso trocar de plano?
                    </h3>
                    <h3>lorem ipsum
                    </h3>
                    <h3>lorem ipsum
                    </h3>
                    <h3>lorem ipsum
                    </h3>
                </div>
            </div>
        </section>
        <div class=""quebra"">
            <img src=""/imagens/location_icon.png"" alt="""">
        </div>
        <!--FORMULÁRIO-->
        <section class=""formulario fullscreen"">
            <h2>Formulário</h2>
            <div class=""formulario-itens"">
                <form action=""#"">
                    <input type=""text"" place");
                WriteLiteral(@"holder=""Digite seu nome..."">
                    <input type=""text"" placeholder=""Digite seu E-mail"">
                    <textarea cols=""30"" rows=""10"" placeholder=""Digite sua mensagem...""></textarea>
                    <input type=""button"" value=""Enviar"">
                </form>
            </div>
        </section>
    </main>
");
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
            BeginContext(3731, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
