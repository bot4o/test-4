#pragma checksum "C:\Users\User\Source\Repos\bot4o\test-4\WebApplication7\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8da297784ce9932656acfead66edeedff972c3f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
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
#line 1 "C:\Users\User\Source\Repos\bot4o\test-4\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Source\Repos\bot4o\test-4\WebApplication7\Views\_ViewImports.cshtml"
using WebApplication7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8da297784ce9932656acfead66edeedff972c3f4", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7dc31cafed32aad956e8e002afa406e7283b5ab", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Source\Repos\bot4o\test-4\WebApplication7\Views\Login\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body, html {
        height: 100%;
    }

    .login-page {
        position: relative;
        height: 100%;
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .login-form {
        width: 300px;
        background:black;
        padding: 20px;
        border-radius: 20px;
    }

    .login-form h2 {
        color: #fff;
        font-weight:bold;
        margin-bottom: 30px;
    }
    .form-group {
    position:relative;
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
    margin-bottom: 15px;
}

    .form-group label {
        color: #fff;
        font-size: 10px;
        font-weight: bold;
        margin-left: 10px;
        text-align: left;
        width: 80px;
    }

    .form-group input {
        flex-grow: 1;
        padding: 10px;
        border: none;
        border-radius: 5px;
        background-color: #e5e5e5;
        font-size: 16px;");
            WriteLiteral(@"
    }

    .login-form .login-btn {
        font-family: Arial;
        font-weight: bold;
        font-size: 20px;
        background: red;
        transition: 0.3s;
        padding: 9px 15px;
    }

    .login-form .login-btn {
        text-decoration: none;
        color: #fff;
    }

    .login-form .login-btn:hover {
            cursor: pointer;
            text-decoration: none;
            background: #fff;
            color: #000;
        }


</style>
<div class=""login-page"">
    <div class=""login-form"">
        <h2>Login</h2>
        <div class=""form-group"">
            <input type=""email"" name=""emailaddress"" id=""emailaddress"" />
            <label for=""emailaddress"">Email</label>
        </div>
        <div class=""form-group"">
            <input type=""password"" name=""password"" id=""password"" />
            <label for=""password"">Password</label>
        </div>
        <a href=""#"" class=""login-btn"">Log In</a>
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
