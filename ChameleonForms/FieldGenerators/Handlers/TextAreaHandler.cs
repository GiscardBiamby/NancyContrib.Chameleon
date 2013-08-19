using System.ComponentModel.DataAnnotations;
using System.Web;
//using System.Web.Mvc.Html;
using NancyContrib.Chameleon.Component.Config;
using Nancy.ViewEngines.Razor;

namespace NancyContrib.Chameleon.FieldGenerators.Handlers
{
    internal class TextAreaHandler<TModel, T> : FieldGeneratorHandler<TModel, T>
    {
        public TextAreaHandler(IFieldGenerator<TModel, T> fieldGenerator, IReadonlyFieldConfiguration fieldConfiguration)
            : base(fieldGenerator, fieldConfiguration)
        {}

        public override bool CanHandle()
        {
            return FieldGenerator.Metadata.DataTypeName == DataType.MultilineText.ToString();
        }

        public override Nancy.ViewEngines.Razor.IHtmlString GenerateFieldHtml()
        {
            return FieldGenerator.HtmlHelper.TextAreaFor(
                FieldGenerator.FieldProperty,
                FieldConfiguration.HtmlAttributes
            );
        }
    }
}
