#pragma checksum "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5faafceacce171745c2c4da32a9d51a3c5816259"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/companies/edit/{Id:guid}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Company</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Edit.razor"
                 company

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Edit.razor"
                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "<label class=\"control-label\">Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Edit.razor"
                                 company.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => company.Name = __value, company.Name))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => company.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __Blazor.Jello.Pages.Companies.Edit.TypeInference.CreateValidationMessage_0(__builder2, 15, 16, 
#nullable restore
#line 11 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Edit.razor"
                                  () => company.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n\r\n    ");
                __builder2.AddMarkupContent(18, "<button class=\"btn btn-primary\" type=\"submit\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Edit.razor"
       

    [Parameter]
    public Guid Id { get; set; }
    private Company company;

    protected override void OnInitialized()
    {
        if (App.Companies.ContainsKey(Id))
            company = App.Companies[Id];
        else
            Console.WriteLine("Item does not exist");

    }

    private void HandleValidSubmit()
    {
        App.Companies[Id] = company;
        Console.WriteLine($"Edited todo with id: {Id}");
        Navigation.NavigateTo("/companies");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
namespace __Blazor.Jello.Pages.Companies.Edit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
