using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Nancy.ViewEngines.Razor;
using NancyContrib.Chameleon.Component.Config;
using NancyContrib.Chameleon.Enums;
using NancyContrib.Chameleon.Templates;

namespace NancyContrib.Chameleon.FieldGenerators.Handlers
{
    internal class BooleanHandler<TModel, T> : FieldGeneratorHandler<TModel, T>
    {
        public BooleanHandler(IFieldGenerator<TModel, T> fieldGenerator, IReadonlyFieldConfiguration fieldConfiguration)
            : base(fieldGenerator, fieldConfiguration)
        {}

        public override bool CanHandle()
        {
            return GetUnderlyingType() == typeof(bool);
        }

        public override Nancy.ViewEngines.Razor.IHtmlString GenerateFieldHtml()
        {
            if (FieldConfiguration.DisplayType == FieldDisplayType.Default && FieldGenerator.Metadata.ModelType == typeof(bool))
                return GetSingleCheckboxHtml();

            var selectList = GetBooleanSelectList();
            return GetSelectListHtml(selectList);
        }

        private bool? GetValue()
        {
            return FieldGenerator.GetValue() as bool?;
        }

        private Nancy.ViewEngines.Razor.IHtmlString GetSingleCheckboxHtml()
        {
            var attrs = new HtmlAttributes(FieldConfiguration.HtmlAttributes);
            AdjustHtmlForModelState(attrs);
            var fieldhtml = HtmlCreator.BuildSingleCheckbox(GetFieldName(), GetValue() ?? false, attrs);
            var labelHtml = HtmlCreator.BuildLabel(
                GetFieldName(),
                FieldConfiguration.InlineLabelText ?? new NonEncodedHtmlString(FieldGenerator.GetFieldDisplayName()),
                null
            );

            return new NonEncodedHtmlString(string.Format("{0} {1}", fieldhtml, labelHtml));
        }

        private IEnumerable<SelectListItem> GetBooleanSelectList()
        {
            var value = GetValue();
            yield return new SelectListItem { Value = "true", Text = FieldConfiguration.TrueString, Selected = value == true };
            yield return new SelectListItem { Value = "false", Text = FieldConfiguration.FalseString, Selected = value == false };
        }
    }
}
