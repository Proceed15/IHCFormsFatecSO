using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace IHCFormsFatecSO.Utils.TagHelpers
{
    [HtmlTargetElement("label", Attributes = "asp-for")]
    public class RequiredLabelTagHelper : TagHelper
    {
        private readonly IHtmlGenerator _htmlGenerator;

        public RequiredLabelTagHelper(IHtmlGenerator htmlGenerator)
        {
            _htmlGenerator = htmlGenerator;
        }

        [HtmlAttributeName("asp-for")]
        public ModelExpression For { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var metadata = For.Metadata;
            if (metadata.IsRequired)
            {
                // Adiciona o asterisco ao conteúdo do label
                // Para demonstrar que o campo é de preenchimento obrigatório
                output.Content.AppendHtml(" <span class='text-danger'>*</span>");
            }
        }
    }
}