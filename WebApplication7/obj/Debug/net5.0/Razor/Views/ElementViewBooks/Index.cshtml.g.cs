#pragma checksum "C:\Users\44740\Documents\GitHub\test-4\WebApplication7\Views\ElementViewBooks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a267cc5952f65b843c4f9974e09a7393cffe119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ElementViewBooks_Index), @"mvc.1.0.view", @"/Views/ElementViewBooks/Index.cshtml")]
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
#line 1 "C:\Users\44740\Documents\GitHub\test-4\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\44740\Documents\GitHub\test-4\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a267cc5952f65b843c4f9974e09a7393cffe119", @"/Views/ElementViewBooks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7dc31cafed32aad956e8e002afa406e7283b5ab", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ElementViewBooks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\44740\Documents\GitHub\test-4\WebApplication7\Views\ElementViewBooks\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .element {
        color: #fff;
        float: left;
        padding: 30px 10px 30px 10px;
        background: #000;
        border-radius: 5px;
    }

    ul {
        list-style-type: none;
    }

    .element .element-tittle {
        font-weight: bold;
    }

    .element p {
        font-size: 13px;
    }

    .element .img {
        width: 330px;
        height: 480px;
    }

    .element .element-price {
        text-align: center;
        border-radius: 5px;
        background: #111;
        display: flex;
        flex-direction: column;
        align-items: stretch;
    }

        .element .element-price span {
            font-size: 30px;
        }

        .element .element-price a {
            font-family: Arial;
            font-weight: bold;
            font-size: 20px;
            background: red;
            transition: 0.3s;
            padding: 9px 15px;
        }

        .element .element-price a {
            text-decoration: n");
            WriteLiteral(@"one;
            color: #fff;
        }

            .element .element-price a:hover {
                cursor: pointer;
                text-decoration: none;
                background: #fff;
                color: #000;
            }

</style>
<div class=""container"">
    <div class=""element"">
        <div class=""col-xs-4 col-lg-5"">
            <div class=""img"" style=""background:cyan;""></div> ");
            WriteLiteral(@"
        </div>
        <div class=""col-xs-5"">
            <h1 class=""element-tittle"">
                BookTitle
            </h1>
            <ul class=""attribute-list"">
                <li>Genre: <span>None</span></li>
                <li>Creator: <span>None</span></li>
                <li>Amount: <span>None</span></li>
                <li>Published by: <span>None</span></li>
            </ul>
            <br />
            <p class=""item-description"">
                ""The Peach Thief"" is a novel by Bulgarian author Emilian Stanev, first published in 1964. The story is set in a small Bulgarian village during the 1930s and follows the life of a young boy named Bai Dancho.

                Bai Dancho is known for stealing peaches from the orchards of the local landowner, who is also the boy's father's employer. The theft of peaches is seen as a symbolic act of rebellion against the oppression and inequality that the villagers experience under the rule of the wealthy landowner.

             ");
            WriteLiteral(@"   As the story progresses, Bai Dancho grows up and becomes involved in the struggles and conflicts of the village community. He becomes a key figure in the fight for justice and equality, standing up against the oppressive landowner and the corrupt local authorities.

                Through the character of Bai Dancho, Stanev explores themes of social injustice, poverty, and the struggle for freedom and dignity. The novel has been widely regarded as a masterpiece of Bulgarian literature and has been translated into multiple languages.
            </p>
        </div>
        <div class=""element-price col-xs-3 col-lg-2"">
            <span>0.00LV</span>
            <a>Buy</a>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
