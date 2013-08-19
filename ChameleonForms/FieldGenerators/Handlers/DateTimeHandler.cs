using System;
using System.Web;
using NancyContrib.Chameleon.Component.Config;
using NancyContrib.Chameleon.Enums;

namespace NancyContrib.Chameleon.FieldGenerators.Handlers
{
    internal class DateTimeHandler<TModel, T> : FieldGeneratorHandler<TModel, T>
    {
        public DateTimeHandler(IFieldGenerator<TModel, T> fieldGenerator, IReadonlyFieldConfiguration fieldConfiguration)
            : base(fieldGenerator, fieldConfiguration)
        { }

        public override bool CanHandle()
        {
            return GetUnderlyingType() == typeof (DateTime);
        }

        public override Nancy.ViewEngines.Razor.IHtmlString GenerateFieldHtml()
        {
            return GetInputHtml(TextInputType.Text);
        }

        public override void PrepareFieldConfiguration(IFieldConfiguration fieldConfiguration)
        {
            if (!string.IsNullOrEmpty(FieldGenerator.Metadata.DisplayFormatString))
                fieldConfiguration.Attr("data-val-format", FieldGenerator.Metadata.DisplayFormatString.Replace("{0:", "").Replace("}", ""));
        }
    }
}
