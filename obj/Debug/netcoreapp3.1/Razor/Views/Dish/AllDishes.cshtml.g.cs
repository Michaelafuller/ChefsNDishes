#pragma checksum "C:\Users\micha\OneDrive\Desktop\stacks\c_sharp\ORMs\ChefsNDishes\Views\Dish\AllDishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7aa6f3e1996d3fab1ff5fcf16ec893dddb0c2b2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dish_AllDishes), @"mvc.1.0.view", @"/Views/Dish/AllDishes.cshtml")]
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
#line 1 "C:\Users\micha\OneDrive\Desktop\stacks\c_sharp\ORMs\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\OneDrive\Desktop\stacks\c_sharp\ORMs\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\micha\OneDrive\Desktop\stacks\c_sharp\ORMs\ChefsNDishes\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aa6f3e1996d3fab1ff5fcf16ec893dddb0c2b2f", @"/Views/Dish/AllDishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28733db6e7d5566b8961ddf765e6b5cc9f81c06e", @"/Views/_ViewImports.cshtml")]
    public class Views_Dish_AllDishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Dishes</h1>
    <p>Yum, take a look at our tasty dishes!</p>
</div>

<div class=""container-fluid"">
    <table class=""table table-striped"">
        <tr>
            <th>Name</th>
            <th>Chef</th>
            <th>Tastiness</th>
            <th>Calories</th>
        </tr>
");
#nullable restore
#line 16 "C:\Users\micha\OneDrive\Desktop\stacks\c_sharp\ORMs\ChefsNDishes\Views\Dish\AllDishes.cshtml"
         foreach (Dish dish in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\micha\OneDrive\Desktop\stacks\c_sharp\ORMs\ChefsNDishes\Views\Dish\AllDishes.cshtml"
               Write(dish.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\micha\OneDrive\Desktop\stacks\c_sharp\ORMs\ChefsNDishes\Views\Dish\AllDishes.cshtml"
               Write(dish.Creator.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "C:\Users\micha\OneDrive\Desktop\stacks\c_sharp\ORMs\ChefsNDishes\Views\Dish\AllDishes.cshtml"
                                       Write(dish.Creator.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\micha\OneDrive\Desktop\stacks\c_sharp\ORMs\ChefsNDishes\Views\Dish\AllDishes.cshtml"
               Write(dish.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\micha\OneDrive\Desktop\stacks\c_sharp\ORMs\ChefsNDishes\Views\Dish\AllDishes.cshtml"
               Write(dish.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\micha\OneDrive\Desktop\stacks\c_sharp\ORMs\ChefsNDishes\Views\Dish\AllDishes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
