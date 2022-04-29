using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CssIsolationViaRenderTreeBuilder.Shared
{
    public class MyComponent : ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);

            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "my-class");
            builder.AddContent(3, "My component 1");

            builder.CloseElement();
        }
    }
}
