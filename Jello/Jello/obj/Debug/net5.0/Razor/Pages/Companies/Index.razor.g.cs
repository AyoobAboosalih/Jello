#pragma checksum "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61b190d5385b8a58a7aa10358e9e2a9640950085"
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
#line 11 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\_Imports.razor"
using Jello.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
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
            __builder.OpenComponent<MudBlazor.MudPaper>(0);
            __builder.AddAttribute(1, "Class", "pa-10 ma-2");
            __builder.AddAttribute(2, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                        3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(4);
                __builder2.AddAttribute(5, "Class", "ma-2");
                __builder2.AddAttribute(6, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 11 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                Typo.h3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "Companies\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(9);
                    __builder3.AddAttribute(10, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 12 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                            Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                        Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                                                          Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Link", "/companies/create");
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(15, "Add Company");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    \r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDivider>(17);
                __builder2.CloseComponent();
#nullable restore
#line 16 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
     if (companies is null)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(18, "<p><em>Loading... !</em></p>");
#nullable restore
#line 19 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<MudBlazor.MudGrid>(19);
                __builder2.AddAttribute(20, "Class", "pa-5 ma-2");
                __builder2.AddAttribute(21, "Justify", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Justify>(
#nullable restore
#line 22 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                            Justify.FlexStart

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 23 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
             foreach (var company in companies)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudItem>(23);
                    __builder3.AddAttribute(24, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                             4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCard>(26);
                        __builder4.AddAttribute(27, "Class", "pa-2");
                        __builder4.AddAttribute(28, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                     25

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudCardHeader>(30);
                            __builder5.AddAttribute(31, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudText>(32);
                                __builder6.AddAttribute(33, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 29 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                               Typo.h6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(35, 
#nullable restore
#line 29 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                         company.Name

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(36, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudDivider>(37);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(38, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudCardActions>(39);
                            __builder5.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(41, "a");
                                __builder6.AddAttribute(42, "href", "/companies/details/" + (
#nullable restore
#line 34 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                         company.Id

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.OpenComponent<MudBlazor.MudButton>(43);
                                __builder6.AddAttribute(44, "Class", "pa-2 ma-2");
                                __builder6.AddAttribute(45, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 35 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                                      Variant.Filled

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(47, "View");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(48, "\r\n                            ");
                                __builder6.OpenElement(49, "a");
                                __builder6.AddAttribute(50, "href", "/companies/edit/" + (
#nullable restore
#line 37 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                      company.Id

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.OpenComponent<MudBlazor.MudFab>(51);
                                __builder6.AddAttribute(52, "Class", "pa-2 ma-2");
                                __builder6.AddAttribute(53, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 38 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                                 Color.Primary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(54, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                                                       Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(55, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 38 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                                                                                         Size.Small

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(56, "IconSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 38 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                                                                                                               Size.Small

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.CloseElement();
                                __builder6.AddMarkupContent(57, "\r\n                            ");
                                __builder6.OpenElement(58, "a");
                                __builder6.AddAttribute(59, "href", "/companies/delete/" + (
#nullable restore
#line 40 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                        company.Id

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.OpenComponent<MudBlazor.MudFab>(60);
                                __builder6.AddAttribute(61, "Class", "pa-2 ma-2");
                                __builder6.AddAttribute(62, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 41 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                                 Color.Secondary

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(63, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                                                         Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(64, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 41 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                                                                                             Size.Small

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(65, "IconSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 41 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
                                                                                                                                                   Size.Small

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.CloseElement();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 47 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 50 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\Admin\Desktop\IIT\L6\EAD\CW2\Jello\Jello\Jello\Pages\Companies\Index.razor"
       

    List<Company> companies;

    protected override async void OnInitialized()
    {
        GetCompanies();
    }

    private List<Company> GetCompanies()
    {
        companies = CompanyModel.GetCompanies();
        return companies;
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompanyModel CompanyModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigator { get; set; }
    }
}
#pragma warning restore 1591
