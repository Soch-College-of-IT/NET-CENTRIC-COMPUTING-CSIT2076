using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MVCDemonstration.TagHelpers
{
     //Email Tag Helper class, extend the class from TagHelper class
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "example.com";

        //properties MailTo
        public string MailTo { get; set; }

        //Process method, this method is called when the tag helper is used
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a"; // Replaces <email> with <a> tag
            var address = MailTo + "@" + EmailDomain;
            output.Attributes.SetAttribute("href", "mailto:" + address); // Set the href attribute
            output.Content.SetContent(address); // Set the content
        }
    }
}
