#pragma checksum "C:\Users\CA\source\repos\BlazorCrud\Pages\AddEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef52a5733647154ca55e64c9d892384e0688cff9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CA\source\repos\BlazorCrud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CA\source\repos\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CA\source\repos\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CA\source\repos\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CA\source\repos\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CA\source\repos\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CA\source\repos\BlazorCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CA\source\repos\BlazorCrud\_Imports.razor"
using BlazorCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CA\source\repos\BlazorCrud\_Imports.razor"
using BlazorCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CA\source\repos\BlazorCrud\Pages\AddEmployee.razor"
using BlazorCrud.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/addemployee")]
    public partial class AddEmployee : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Employee</h3>\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 5 "C:\Users\CA\source\repos\BlazorCrud\Pages\AddEmployee.razor"
                  obj

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\CA\source\repos\BlazorCrud\Pages\AddEmployee.razor"
                                      CreateEmployee

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-8");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.AddMarkupContent(17, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "Name");
                __builder2.AddAttribute(20, "form", "Name");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 11 "C:\Users\CA\source\repos\BlazorCrud\Pages\AddEmployee.razor"
                                                                                    obj.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Name = __value, obj.Name))));
                __builder2.AddAttribute(24, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-md-5");
                global::__Blazor.BlazorCrud.Pages.AddEmployee.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 12 "C:\Users\CA\source\repos\BlazorCrud\Pages\AddEmployee.razor"
                                                                () => obj.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(30, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.AddMarkupContent(36, "<label for=\"Age\" class=\"control-label\">Age</label>\r\n                ");
                global::__Blazor.BlazorCrud.Pages.AddEmployee.TypeInference.CreateInputNumber_1(__builder2, 37, 38, "Age", 39, "Age", 40, "form-control", 41, 
#nullable restore
#line 17 "C:\Users\CA\source\repos\BlazorCrud\Pages\AddEmployee.razor"
                                                                                    obj.Age

#line default
#line hidden
#nullable disable
                , 42, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Age = __value, obj.Age)), 43, () => obj.Age);
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "col-md-5");
                global::__Blazor.BlazorCrud.Pages.AddEmployee.TypeInference.CreateValidationMessage_2(__builder2, 47, 48, 
#nullable restore
#line 18 "C:\Users\CA\source\repos\BlazorCrud\Pages\AddEmployee.razor"
                                                                () => obj.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(49, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            \r\n            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.AddMarkupContent(55, "<label for=\"Position\" class=\"control-label\">Position</label>\r\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "form", "Position");
                __builder2.AddAttribute(58, "id", "Position");
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 23 "C:\Users\CA\source\repos\BlazorCrud\Pages\AddEmployee.razor"
                                                                                            obj.Position

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.Position = __value, obj.Position))));
                __builder2.AddAttribute(62, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.Position));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-md-5");
                global::__Blazor.BlazorCrud.Pages.AddEmployee.TypeInference.CreateValidationMessage_3(__builder2, 66, 67, 
#nullable restore
#line 24 "C:\Users\CA\source\repos\BlazorCrud\Pages\AddEmployee.razor"
                                                                () => obj.Position

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(68, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n\r\n\r\n            ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group");
                __builder2.AddMarkupContent(73, "\r\n                ");
                __builder2.AddMarkupContent(74, "<label for=\"City\" class=\"control-label\">City</label>\r\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(75);
                __builder2.AddAttribute(76, "form", "City");
                __builder2.AddAttribute(77, "id", "City");
                __builder2.AddAttribute(78, "class", "form-control");
                __builder2.AddAttribute(79, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 31 "C:\Users\CA\source\repos\BlazorCrud\Pages\AddEmployee.razor"
                                                                                    obj.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => obj.City = __value, obj.City))));
                __builder2.AddAttribute(81, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => obj.City));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n                ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "col-md-5");
                global::__Blazor.BlazorCrud.Pages.AddEmployee.TypeInference.CreateValidationMessage_4(__builder2, 85, 86, 
#nullable restore
#line 32 "C:\Users\CA\source\repos\BlazorCrud\Pages\AddEmployee.razor"
                                                                () => obj.City

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(87, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n\r\n    ");
                __builder2.AddMarkupContent(92, "<div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" class=\"btn btn-primary\" value=\"Add\">\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BlazorCrud.Pages.AddEmployee
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "form", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
