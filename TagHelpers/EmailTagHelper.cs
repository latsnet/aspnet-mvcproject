using Microsoft.AspNetCore.Razor.TagHelpers;

namespace mvc_project.TagHelpers;

public class EmailTagHelper : TagHelper
{
    public string Address { get; set; }
    public string Content { get; set; }


    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "a";
        output.Attributes.SetAttribute("href", "mailto: " + this.Address);
        output.Content.SetContent(this.Content);

        base.Process(context, output);
    }

}