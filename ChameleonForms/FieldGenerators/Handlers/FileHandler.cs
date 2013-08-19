using System.Web;
using NancyContrib.Chameleon.Component.Config;
using NancyContrib.Chameleon.Enums;

namespace NancyContrib.Chameleon.FieldGenerators.Handlers
{
    internal class FileHandler<TModel, T> : FieldGeneratorHandler<TModel, T>
    {
        public FileHandler(IFieldGenerator<TModel, T> fieldGenerator, IReadonlyFieldConfiguration fieldConfiguration)
            : base(fieldGenerator, fieldConfiguration)
        {}

        public override bool CanHandle()
        {
            return typeof(HttpPostedFileBase).IsAssignableFrom(FieldGenerator.Metadata.ModelType);
        }

        public override Nancy.ViewEngines.Razor.IHtmlString GenerateFieldHtml()
        {
            return GetInputHtml(TextInputType.File);
        }
    }
}
