#pragma checksum "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4652c0486de9490b4bb2e5f8dec7527aeb004389"
// <auto-generated/>
#pragma warning disable 1591
namespace Personenregister.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\_Imports.razor"
using Personenregister;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\_Imports.razor"
using Personenregister.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
using Personenregister.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registry")]
    public partial class Registry : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Registry</h1>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<label class=\"control-label\">Name</label>\r\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
                                                newReg.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newReg.Name = __value, newReg.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, "<label class=\"control-label\">Prename</label>\r\n            ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
                                                newReg.PreName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newReg.PreName = __value, newReg.PreName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col");
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.AddMarkupContent(29, "<label class=\"control-label\">Age</label>\r\n            ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
                                                newReg.Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newReg.Age = __value, newReg.Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.AddMarkupContent(39, "<label class=\"control-label\">Summary</label>\r\n            ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
                                                newReg.Summary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newReg.Summary = __value, newReg.Summary));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row");
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col");
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
                                                       CreateReg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(56, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "class", "btn btn-primary");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
                                                       DeleteReg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(61, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "class", "btn btn-primary");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
                                                       UpdateReg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(66, "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(71, "table");
            __builder.AddAttribute(72, "class", "table table-striped table-bordered");
            __builder.AddMarkupContent(73, "\r\n\r\n    ");
            __builder.AddMarkupContent(74, @"<thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Prename
            </th>
            <th>
                Age
            </th>
            <th>
                Summary
            </th>
        </tr>
    </thead>

    ");
            __builder.OpenElement(75, "tbody");
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 58 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
         foreach (RegistryC reg in allReg)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "        ");
            __builder.OpenElement(78, "tr");
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenElement(80, "td");
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.AddContent(82, 
#nullable restore
#line 62 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
                 reg.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.OpenElement(85, "td");
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.AddContent(87, 
#nullable restore
#line 65 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
                 reg.PreName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.OpenElement(90, "td");
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.AddContent(92, 
#nullable restore
#line 68 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
                 reg.Age

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.OpenElement(95, "td");
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.AddContent(97, 
#nullable restore
#line 71 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
                 reg.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 74 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\Fero47\Desktop\Programs\Personenregister\Personenregister\Pages\Registry.razor"
       

    List<RegistryC> allReg = new List<RegistryC>();

    RegistryC newReg = new RegistryC();

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        allReg = await registryService.GetRegistry();
    }

    protected async void CreateReg()
    {
        await registryService.AddRegistry(newReg);
    }

    protected async void DeleteReg()
    {
        await registryService.DeleteRegistry(newReg);
    }

    protected async void UpdateReg()
    {
        await registryService.UpdateRegistry(newReg);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RegistryService registryService { get; set; }
    }
}
#pragma warning restore 1591
