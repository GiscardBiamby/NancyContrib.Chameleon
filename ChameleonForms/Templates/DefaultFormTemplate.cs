using System.Web;
using System.Web.Mvc;
using NancyContrib.Chameleon.Component.Config;
using NancyContrib.Chameleon.Enums;
using Nancy.ViewEngines.Razor;

namespace NancyContrib.Chameleon.Templates
{
    /// <summary>
    /// The default Chameleon Forms form template renderer.
    /// </summary>
    public class DefaultFormTemplate : IFormTemplate
    {
        public virtual Nancy.ViewEngines.Razor.IHtmlString BeginForm(string action, FormMethod method, HtmlAttributes htmlAttributes, EncType? enctype)
        {
            return HtmlCreator.BuildFormTag(action, method, htmlAttributes, enctype);
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString EndForm()
        {
            return HtmlHelpers.EndForm();
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString BeginSection(Nancy.ViewEngines.Razor.IHtmlString title,   Nancy.ViewEngines.Razor.IHtmlString leadingHtml, HtmlAttributes htmlAttributes)
        {
            return HtmlHelpers.BeginSection(title, leadingHtml, htmlAttributes);
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString EndSection()
        {
            return HtmlHelpers.EndSection();
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString BeginNestedSection(Nancy.ViewEngines.Razor.IHtmlString title,   Nancy.ViewEngines.Razor.IHtmlString leadingHtml, HtmlAttributes htmlAttributes)
        {
            return HtmlHelpers.BeginNestedSection(title, leadingHtml, htmlAttributes);
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString EndNestedSection()
        {
            return HtmlHelpers.EndNestedSection();
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString Field(Nancy.ViewEngines.Razor.IHtmlString labelHtml,   Nancy.ViewEngines.Razor.IHtmlString elementHtml,   Nancy.ViewEngines.Razor.IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration, bool isValid)
        {
            return HtmlHelpers.Field(labelHtml, elementHtml, validationHtml, fieldMetadata, fieldConfiguration);
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString BeginField(Nancy.ViewEngines.Razor.IHtmlString labelHtml,   Nancy.ViewEngines.Razor.IHtmlString elementHtml,   Nancy.ViewEngines.Razor.IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration, bool isValid)
        {
            return HtmlHelpers.BeginField(labelHtml, elementHtml, validationHtml, fieldMetadata, fieldConfiguration);
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString EndField()
        {
            return HtmlHelpers.EndField();
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString BeginMessage(MessageType messageType, Nancy.ViewEngines.Razor.IHtmlString heading)
        {
            return HtmlHelpers.BeginMessage(messageType, heading);
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString EndMessage()
        {
            return HtmlHelpers.EndMessage();
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString MessageParagraph(Nancy.ViewEngines.Razor.IHtmlString paragraph)
        {
            return HtmlHelpers.MessageParagraph(paragraph);
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString BeginNavigation()
        {
            return HtmlHelpers.BeginNavigation();
        }

        public virtual Nancy.ViewEngines.Razor.IHtmlString EndNavigation()
        {
            return HtmlHelpers.EndNavigation();
        }
    }
}