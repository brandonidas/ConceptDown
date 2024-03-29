#pragma checksum "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32de87f4e006cca6e9adca5604e59b28788bcdb3"
// <auto-generated/>
#pragma warning disable 1591
namespace CDClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/_Imports.razor"
using CDClient;

#line default
#line hidden
#line 7 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/_Imports.razor"
using CDClient.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/courses")]
    public partial class Courses : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Courses</h1>\n\n");
            __builder.AddMarkupContent(1, "<button>Table Format</button>\n");
            __builder.AddMarkupContent(2, "<button>Drop-down Format</button>\n\n");
#line 9 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
 if (courseReq.Courses == null)
{

#line default
#line hidden
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>\n");
#line 12 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
}
else
{

#line default
#line hidden
#line 15 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
 foreach (var course in courseReq.Courses) 
{

#line default
#line hidden
            __builder.OpenElement(5, "details");
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenElement(7, "summary");
            __builder.AddAttribute(8, "class", "lead");
            __builder.AddAttribute(9, "open", "True");
            __builder.AddContent(10, 
#line 18 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                                       course.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "list-group");
            __builder.AddMarkupContent(14, "\n");
#line 20 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
     foreach (var topic in course.Topics) 
    {

#line default
#line hidden
            __builder.AddContent(15, "        ");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "list-group-item");
            __builder.AddMarkupContent(18, "\n        ");
            __builder.OpenElement(19, "details");
            __builder.AddMarkupContent(20, "\n            ");
            __builder.OpenElement(21, "summary");
            __builder.AddContent(22, 
#line 24 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                      topic.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n            ");
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table table-hover");
            __builder.AddMarkupContent(26, "\n            ");
            __builder.AddMarkupContent(27, "<thead>\n                <tr>\n                    <th>Name</th>\n                    <th>Priority</th>\n                    <th>Master</th>\n                </tr>   \n            </thead>\n            ");
            __builder.OpenElement(28, "tbody");
            __builder.AddMarkupContent(29, "\n");
#line 34 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
             foreach (var concept in topic.Concepts)
            {

#line default
#line hidden
            __builder.AddContent(30, "            ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "\n                ");
            __builder.OpenComponent<CDClient.Pages.ConceptComponent>(33);
            __builder.AddAttribute(34, "Concept", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CDClient.Concept>(
#line 37 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                                           concept

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "  \n");
#line 39 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
            }

#line default
#line hidden
            __builder.AddContent(37, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n");
#line 45 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
    }

#line default
#line hidden
            __builder.AddContent(42, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n");
#line 48 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"

}

#line default
#line hidden
            __builder.AddContent(45, "    ");
            __builder.OpenElement(46, "table");
            __builder.AddAttribute(47, "class", "table");
            __builder.AddMarkupContent(48, "\n\n        ");
            __builder.OpenElement(49, "tbody");
            __builder.AddMarkupContent(50, "            \n");
#line 54 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
             foreach (var course in courseReq.Courses)
            {

#line default
#line hidden
            __builder.AddContent(51, "                ");
            __builder.OpenElement(52, "tr");
            __builder.AddMarkupContent(53, "\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#line 57 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                         course.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n                    \n");
#line 59 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                     foreach (var topic in course.Topics) 
                    {

#line default
#line hidden
            __builder.AddContent(57, "                        ");
            __builder.OpenElement(58, "tr");
            __builder.AddMarkupContent(59, "\n                            ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#line 62 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                                 topic.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n                            \n");
#line 65 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                         foreach (var concept in topic.Concepts){

#line default
#line hidden
            __builder.AddContent(63, "                            ");
            __builder.OpenElement(64, "tr");
            __builder.AddMarkupContent(65, "\n                                ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#line 67 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                                     concept.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n                                ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#line 68 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                                     concept.Priority

#line default
#line hidden
            );
            __builder.AddMarkupContent(71, "\n                                    ");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "btn btn-primary");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 69 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                                                                               concept.decPriority

#line default
#line hidden
            ));
            __builder.AddContent(75, "-");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n                                    ");
            __builder.OpenElement(77, "button");
            __builder.AddAttribute(78, "class", "btn btn-primary");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 70 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                                                                               concept.incPriority

#line default
#line hidden
            ));
            __builder.AddContent(80, "+");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n                                ");
            __builder.OpenElement(83, "td");
            __builder.AddContent(84, 
#line 72 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                                     concept.Mastery

#line default
#line hidden
            );
            __builder.AddMarkupContent(85, "\n                                    ");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "class", "btn btn-primary");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 73 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                                                                               concept.decMastery

#line default
#line hidden
            ));
            __builder.AddContent(89, "-");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\n                                    ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "class", "btn btn-primary");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 74 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                                                                               concept.incMastery

#line default
#line hidden
            ));
            __builder.AddContent(94, "+");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "  \n");
#line 78 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                        }

#line default
#line hidden
            __builder.AddContent(98, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n");
#line 80 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
                    }

#line default
#line hidden
            __builder.AddContent(100, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\n");
#line 82 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
            }

#line default
#line hidden
            __builder.AddMarkupContent(102, "            \n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\n");
#line 86 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 88 "/Users/brandontong/Documents/GitHub/ConceptDown/CDClient/Pages/Courses.razor"
       
    private CoursesRequest courseReq = new CoursesRequest();

    protected override async Task OnInitializedAsync()
    {
        courseReq.Courses = await Http.GetJsonAsync<Course[]>("sample-data/sample-courses.json");
        
    }
    public class CoursesRequest
    {
        public Course[] Courses { get; set; }
        public Concept[] concepts { get; set; }
        // needs thie CoursesRequest object for
        // file to link to Concept Class for some reason
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
