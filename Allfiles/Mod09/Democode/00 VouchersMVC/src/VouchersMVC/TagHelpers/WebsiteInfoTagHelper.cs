using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Vouchers
{
    [HtmlTargetElement("Website-Info")]
    public class WebsiteInfoTagHelper : TagHelper
    {
        public WebsiteInfo Info { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            output.Content.SetHtmlContent(
                $@"<ul>
                <li><strong>Copyright Year:</strong> {Info.CopyrightYear}</li>
                <li><strong>Company:</strong> {Info.Company}</li>
                </ul>");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}