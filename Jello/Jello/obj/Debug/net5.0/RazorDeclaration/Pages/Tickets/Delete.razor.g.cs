// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Jello.Pages.Tickets
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/tickets/delete/{Id:guid}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Tickets\Delete.razor"
       
    [Parameter]
    public Guid Id { get; set; }
    private Ticket ticket;

    protected override void OnInitialized()
    {
        if (App.Tickets.ContainsKey(Id))
            ticket = App.Tickets[Id];
        else
            Console.WriteLine("Item does not exist");

    }

    private void DeleteTicket()
    {
        App.Tickets.Remove(Id);
        Navigation.NavigateTo("/tickets");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
