using System.ComponentModel.DataAnnotations;
using System.Web;
using NancyContrib.Chameleon.Component.Config;
using NancyContrib.Chameleon.Enums;

namespace NancyContrib.Chameleon.FieldGenerators.Handlers
{
    internal class PasswordHandler<TModel, T> : FieldGeneratorHandler<TModel, T>
    {
        public PasswordHandler(IFieldGenerator<TModel, T> fieldGenerator, IReadonlyFieldConfiguration fieldConfiguration)
            : base(fieldGenerator, fieldConfiguration)
        {}

        public override bool CanHandle()
        {
            return FieldGenerator.Metadata.DataTypeName == DataType.Password.ToString();
        }

        public override Nancy.ViewEngines.Razor.IHtmlString GenerateFieldHtml()
        {
            return GetInputHtml(TextInputType.Password);
        }
    }
}
