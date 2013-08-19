using System.Web;
using NancyContrib.Chameleon.Component.Config;
using NancyContrib.Chameleon.Enums;

namespace NancyContrib.Chameleon.FieldGenerators.Handlers
{
    internal class DefaultHandler<TModel, T> : FieldGeneratorHandler<TModel, T>
    {
        public DefaultHandler(IFieldGenerator<TModel, T> fieldGenerator, IReadonlyFieldConfiguration fieldConfiguration)
            : base(fieldGenerator, fieldConfiguration)
        {}

        public override bool CanHandle()
        {
            return true;
        }

        public override Nancy.ViewEngines.Razor.IHtmlString GenerateFieldHtml()
        {
            return GetInputHtml(TextInputType.Text);
        }
    }
}
