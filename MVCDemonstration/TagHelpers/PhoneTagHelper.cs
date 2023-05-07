using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCDemonstration.TagHelpers
{
    public class PhoneTagHelper : TagHelper
    {
        //properties Phone
        public string Tel { get; set; }

        //Process method, this method is called when the tag helper is used
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "tel:" + Tel);
            output.Content.SetContent(Tel);
        }
    }
}
