#pragma checksum "C:\Users\47822980807\Downloads\Senai.Comentarios.FinalPronto\Views\Pages\Sobre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e189b39a34b3601bee7ad26ab6ed3a61b21bd94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_Sobre), @"mvc.1.0.view", @"/Views/Pages/Sobre.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pages/Sobre.cshtml", typeof(AspNetCore.Views_Pages_Sobre))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e189b39a34b3601bee7ad26ab6ed3a61b21bd94", @"/Views/Pages/Sobre.cshtml")]
    public class Views_Pages_Sobre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\47822980807\Downloads\Senai.Comentarios.FinalPronto\Views\Pages\Sobre.cshtml"
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
            BeginContext(240, 40, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            EndContext();
            BeginContext(280, 313, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "348df8664944456cb62fbdd9c2a73e39", async() => {
                BeginContext(286, 300, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""stylesheet"" href=""/css/sobre.css"">
    <link href=""https://fonts.googleapis.com/css?family=Raleway"" rel=""stylesheet"">
");
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
            BeginContext(593, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(597, 2355, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3863254672884a9ab37c0e57b7075dd2", async() => {
                BeginContext(603, 2342, true);
                WriteLiteral(@"
    <main>
        <section class=""nossa-historia"">
            <h2>Nossa História</h2>
            <div class=""historia-cont"">
                <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Reprehenderit quas quasi molestias tenetur veritatis,
                    saepe ullam dicta. Esse, quasi consequuntur. Officia blanditiis odit, autem dignissimos ea aperiam quaerat
                    laudantium beatae?Lorem ipsum dolor sit amet consectetur adipisicing elit. Laudantium porro illo aperiam
                    maiores adipisci, ut facere a odio molestias explicabo sunt voluptatibus vero! Enim non aliquam, tempore
                    ipsa delectus repellendus?</p>
                <img style=""width: 500px; height: 300px;"" src=""/imagens/nossa-historia-img.jpg"" alt="""">
                <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Maiores ratione amet modi doloremque facere architecto
                    sint. Fuga, natus cumque. Totam delectus voluptates odit quod eaque?");
                WriteLiteral(@" Odio praesentium nisi possimus doloremque.
                    Lorem ipsum dolor sit, amet consectetur adipisicing elit. Maiores ratione amet modi doloremque facere
                    architecto sint. Fuga, natus cumque. Totam delectus voluptates odit quod eaque? Odio praesentium nisi
                    possimus doloremque. Lorem ipsum dolor sit amet consectetur adipisicing elit. Ex aperiam laborum est
                    repellendus eveniet nam nulla quasi cupiditate, quisquam magni suscipit enim excepturi accusantium natus
                    corrupti hic fuga nihil quis.</p>
            </div>
        </section>

        <div class=""quebra"">
            <img src=""/imagens/location_icon.png"" alt="""">
        </div>

        <section class=""galeria"">
            <h2>Galeria</h2>
            <div class=""fotos-cima"">
                <img src=""/imagens/galeria-1.jpg"" alt="""">
                <img src=""/imagens/galeria-2.jpg"" alt="""">
                <img src=""/imagens/galeria-3.jpg"" alt="""">
 ");
                WriteLiteral(@"           </div>
            <div class=""fotos-baixo"">
                <img src=""/imagens/galeria-4.jpg"" alt="""">
                <img src=""/imagens/galeria-5.jpg"" alt="""">
                <img src=""/imagens/galeria-6.jpg"" alt="""">
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
            BeginContext(2952, 11, true);
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
