// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Jello
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\App.razor"
      
    public static Dictionary<Guid, Company> Companies = new Dictionary<Guid, Company>();
    public static Dictionary<Guid, Project> Projects = new Dictionary<Guid, Project>();
    public static Dictionary<Guid, User> Users = new Dictionary<Guid, User>();
    public static Dictionary<Guid, Ticket> Tickets = new Dictionary<Guid, Ticket>();

    protected override void OnInitialized()
    {
        var company1 = new Company()
        {
            Id = Guid.NewGuid(),
            Name = "Austasia"
        };


        var company2 = new Company()
        {
            Id = Guid.NewGuid(),
            Name = "Thingamagig"
        };

        var company3 = new Company()
        {
            Id = Guid.NewGuid(),
            Name = "Jello"
        };

        Companies.Add(company1.Id, company1);
        Companies.Add(company2.Id, company2);
        Companies.Add(company3.Id, company3);

        // Adding Project

        var Project1 = new Project()
        {
            Id = Guid.NewGuid(),
            Name = "dancing project",
            StartDate = DateTime.Today,
            Enddate = DateTime.Now,
            assignedCompany = company1.Id
        };


        var Project2 = new Project()
        {
            Id = Guid.NewGuid(),
            Name = "running project",
            StartDate = DateTime.Today,
            Enddate = DateTime.Now,
            assignedCompany = company2.Id
        };

        var Project3 = new Project()
        {
            Id = Guid.NewGuid(),
            Name = "Building project",
            StartDate = DateTime.Today,
            Enddate = DateTime.Now,
            assignedCompany = company3.Id
        };

        Projects.Add(Project1.Id, Project1);
        Projects.Add(Project2.Id, Project2);
        Projects.Add(Project3.Id, Project3);


        // Adding User

        var user1 = new User()
        {
            Id = Guid.NewGuid(),
            FirstName = "Ayoob",
            LastName = "Aboosalih",
            ContactNumber = "771512208",
            assignedCompany = company1.Id
        };


        var user2 = new User()
        {
            Id = Guid.NewGuid(),
            FirstName = "somone",
            LastName = "Else",
            ContactNumber = "210761296",
            assignedCompany = company2.Id
        };

        var user3 = new User()
        {
            Id = Guid.NewGuid(),
            FirstName = "Another",
            LastName = "One",
            ContactNumber = "210761296",
            assignedCompany = company3.Id
        };

        Users.Add(user1.Id, user1);
        Users.Add(user2.Id, user2);
        Users.Add(user3.Id, user3);


        // Adding Ticket

        var ticket1 = new Ticket()
        {
            Id = Guid.NewGuid(),
            Name = "Addd git ignore",
            Estimate = 2,
            State = "In progress",
            StartDate = DateTime.Today,
            Enddate = DateTime.Now,
            AssignedUsers = Users,
            AssignedProject = Project1.Id
        };


        var ticket2 = new Ticket()
        {
            Id = Guid.NewGuid(),
            Name = "Delete File",
            Estimate = 2,
            State = "In progress",
            StartDate = DateTime.Today,
            Enddate = DateTime.Now,
            AssignedUsers = Users,
            AssignedProject = Project1.Id
        };

        var ticket3 = new Ticket()
        {
            Id = Guid.NewGuid(),
            Name = "Update UI",
            Estimate = 2,
            State = "In progress",
            StartDate = DateTime.Today,
            Enddate = DateTime.Now,
            AssignedUsers = Users,
            AssignedProject = Project1.Id
        };


        Tickets.Add(ticket1.Id, ticket1);
        Tickets.Add(ticket2.Id, ticket2);
        Tickets.Add(ticket3.Id, ticket3);



    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
