#pragma checksum "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac8a9a5ec44612cdc9ab80afe00377eb7113b04"
// <auto-generated/>
#pragma warning disable 1591
namespace Jello.Pages.Companies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\_Imports.razor"
using Jello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\_Imports.razor"
using Jello.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\_Imports.razor"
using Jello.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/companies")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>List of companies</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "table-responsive");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-hover");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead class=\"thead-dark\">\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Read</th>\r\n                <th>Edit</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 16 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
             foreach (var company in App.Companies)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.AddContent(15, 
#nullable restore
#line 20 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                          company.Value.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/companies/details/" + (
#nullable restore
#line 23 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                     company.Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Details");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", "/companies/edit/" + (
#nullable restore
#line 26 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                  company.Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "href", "/companies/delete/" + (
#nullable restore
#line 29 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                    company.Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 32 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(44, "<p>\r\n    <a class=\"btn btn-primary\" href=\"/companies/create\">Create</a>\r\n</p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
