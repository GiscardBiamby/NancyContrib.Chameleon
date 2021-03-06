﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using NancyContrib.Chameleon.Component.Config;
using NancyContrib.Chameleon.Templates;
using Nancy.ViewEngines.Razor;
using System.Web.Mvc;

namespace NancyContrib.Chameleon.FieldGenerators
{
    /// <summary>
    /// The default field HTML generator.
    /// </summary>
    /// <typeparam name="TModel">The type of the view model for the form</typeparam>
    /// <typeparam name="T">The type of the field being generated</typeparam>
    public class DefaultFieldGenerator<TModel, T> : IFieldGenerator<TModel, T>
    {
        /// <summary>
        /// Constructs the field generator.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper for the current view</param>
        /// <param name="fieldProperty">Expression to identify the property to generate the field for</param>
        public DefaultFieldGenerator(HtmlHelpers<TModel> htmlHelper, Expression<Func<TModel, T>> fieldProperty)
        {
            HtmlHelper = htmlHelper;
            FieldProperty = fieldProperty;
            Metadata = ModelMetadata.FromLambdaExpression(FieldProperty, HtmlHelper.ViewData);
        }

        public ModelMetadata Metadata { get; private set; }
        public HtmlHelpers<TModel> HtmlHelper { get; private set; }
        public Expression<Func<TModel, T>> FieldProperty { get; private set; }

        public Nancy.ViewEngines.Razor.IHtmlString GetLabelHtml(IReadonlyFieldConfiguration fieldConfiguration)
        {
            string @for;
            if (fieldConfiguration != null && fieldConfiguration.HtmlAttributes.ContainsKey("id"))
            {
                @for = fieldConfiguration.HtmlAttributes["id"].ToString();
            }
            else
            {
                @for = HtmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(
                    ExpressionHelper.GetExpressionText(FieldProperty));
            }

            var labelText = (fieldConfiguration == null ? null : fieldConfiguration.LabelText)
                ?? new NonEncodedHtmlString(GetFieldDisplayName());

            if (fieldConfiguration != null && !fieldConfiguration.HasLabel)
                return labelText;

            return HtmlCreator.BuildLabel(@for, labelText, null);
        }

        public string GetFieldDisplayName()
        {
            return Metadata.DisplayName
                ?? Metadata.PropertyName
                ?? ExpressionHelper.GetExpressionText(FieldProperty).Split('.').Last();
        }

        public Nancy.ViewEngines.Razor.IHtmlString GetValidationHtml(IReadonlyFieldConfiguration fieldConfiguration)
        {
            return HtmlHelper.ValidationMessageFor(FieldProperty);
        }

        public    Nancy.ViewEngines.Razor.IHtmlString GetFieldHtml(IFieldConfiguration fieldConfiguration)
        {
            return GetFieldHtml(PrepareFieldConfiguration(fieldConfiguration));
        }

        public    Nancy.ViewEngines.Razor.IHtmlString GetLabelHtml(IFieldConfiguration fieldConfiguration)
        {
            return GetLabelHtml(PrepareFieldConfiguration(fieldConfiguration));
        }

        public    Nancy.ViewEngines.Razor.IHtmlString GetValidationHtml(IFieldConfiguration fieldConfiguration)
        {
            return GetValidationHtml(PrepareFieldConfiguration(fieldConfiguration));
        }

        public IReadonlyFieldConfiguration PrepareFieldConfiguration(IFieldConfiguration fieldConfiguration)
        {
            fieldConfiguration = fieldConfiguration ?? new FieldConfiguration();
            if (!string.IsNullOrEmpty(Metadata.EditFormatString) && string.IsNullOrEmpty(fieldConfiguration.FormatString))
                fieldConfiguration.WithFormatString(Metadata.EditFormatString);
            if (!string.IsNullOrEmpty(Metadata.NullDisplayText) && string.IsNullOrEmpty(fieldConfiguration.NoneString))
                fieldConfiguration.WithNoneAs(Metadata.NullDisplayText);

            FieldGeneratorHandlersRouter<TModel, T>.PrepareFieldConfiguration(this, fieldConfiguration);

            return new ReadonlyFieldConfiguration(fieldConfiguration);
        }

        public    Nancy.ViewEngines.Razor.IHtmlString GetFieldHtml(IReadonlyFieldConfiguration fieldConfiguration)
        {
            fieldConfiguration = fieldConfiguration ?? new ReadonlyFieldConfiguration(new FieldConfiguration());
            if (fieldConfiguration.FieldHtml != null)
                return fieldConfiguration.FieldHtml;
            
            return FieldGeneratorHandlersRouter<TModel, T>.GetFieldHtml(this, fieldConfiguration);
        }

        public T GetValue()
        {
            var model = GetModel();

            return model == null ? default(T) : FieldProperty.Compile().Invoke(model);
        }

        public string GetFieldId()
        {
            return ((MemberExpression) FieldProperty.Body).Member.Name;
        }

        public TModel GetModel()
        {
            return (TModel) HtmlHelper.ViewData.ModelMetadata.Model;
        }
    }
}
