#pragma checksum "C:\Users\47822980807\Downloads\Senai.Comentarios.FinalPronto\Views\Usuario\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44493700fb870a7ff959b48e48094bf1f2d3650a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Login), @"mvc.1.0.view", @"/Views/Usuario/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Login.cshtml", typeof(AspNetCore.Views_Usuario_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44493700fb870a7ff959b48e48094bf1f2d3650a", @"/Views/Usuario/Login.cshtml")]
    public class Views_Usuario_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\47822980807\Downloads\Senai.Comentarios.FinalPronto\Views\Usuario\Login.cshtml"
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
            BeginContext(240, 828, true);
            WriteLiteral(@"
<link href=""/css/login.css"" rel=""stylesheet"">

<main>
        <section class=""efetuarlogin"">
            
            <div class=""login"">
                <h2>Login</h2>
                <form action=""/Usuario/Login"" method=""POST"">
                    <label>
                    <p>Email</p>
                    <input type=""text"" placeholder=""Digite seu e-mail"" name=""email"" required>
                    </label>
                    <br>
                    <label>
                    <p>Senha</p>
                    <input type=""password"" placeholder=""Digite sua senha"" name=""senha"" required>
                    </label>
                    
                    <br>
                    <button type=""submit"">Entrar</button>
                </form>
            </div>
        </section>
    </main>");
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
