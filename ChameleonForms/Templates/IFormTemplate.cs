using System.Web;
using NancyContrib.Chameleon.Component.Config;
using NancyContrib.Chameleon.Enums;
using System.Web.Mvc;

namespace NancyContrib.Chameleon.Templates
{
    /// <summary>
    /// A Chameleon Forms form template renderer.
    /// </summary>
    public interface IFormTemplate
    {
        /// <summary>
        /// Creates the starting HTML for a form.
        /// </summary>
        /// <param name="action">The form action</param>
        /// <param name="method">The form method</param>
        /// <param name="htmlAttributes">Any HTML attributes the form should use; specified as an anonymous object</param>
        /// <param name="enctype">The encoding type for the form</param>
        /// <returns>The starting HTML for a form</returns>
         Nancy.ViewEngines.Razor.IHtmlString BeginForm(string action, FormMethod method, HtmlAttributes htmlAttributes, EncType? enctype);

        /// <summary>
        /// Creates the ending HTML for a form.
        /// </summary>
        /// <returns>The ending HTML for a form</returns>
         Nancy.ViewEngines.Razor.IHtmlString EndForm();

        /// <summary>
        /// Creates the beginning HTML for a section.
        /// </summary>
        /// <param name="title">The title of the section</param>
        /// <param name="leadingHtml">Any HTML to output at the start of the section</param>
        /// <param name="htmlAttributes">Any HTML attributes the section container should use; specified as an anonymous object</param>
        /// <returns>The beginning HTML for a section</returns>
         Nancy.ViewEngines.Razor.IHtmlString BeginSection(Nancy.ViewEngines.Razor.IHtmlString title,  Nancy.ViewEngines.Razor.IHtmlString leadingHtml, HtmlAttributes htmlAttributes);

        /// <summary>
        /// Creates the ending HTML for a section.
        /// </summary>
        /// <returns>The ending HTML for a section</returns>
         Nancy.ViewEngines.Razor.IHtmlString EndSection();

        /// <summary>
        /// Creates the beginning HTML for a section that is nested within another section.
        /// </summary>
        /// <param name="title">The title of the nested section</param>
        /// <param name="leadingHtml">Any HTML to output at the start of the nested section</param>
        /// <param name="htmlAttributes">Any HTML attributes the nested section container should use; specified as an anaonymous object</param>
        /// <returns>The beginning HTML for a nested section</returns>
         Nancy.ViewEngines.Razor.IHtmlString BeginNestedSection(Nancy.ViewEngines.Razor.IHtmlString title,  Nancy.ViewEngines.Razor.IHtmlString leadingHtml, HtmlAttributes htmlAttributes);

        /// <summary>
        /// Creates the ending HTML for a section that is nested within another section.
        /// </summary>
        /// <returns>The ending HTML for a nested section</returns>
         Nancy.ViewEngines.Razor.IHtmlString EndNestedSection();

        /// <summary>
        /// Creates the HTML for a single form field.
        /// </summary>
        /// <param name="labelHtml">The HTML that comprises the form label</param>
        /// <param name="elementHtml">The HTML that comprieses the field itself</param>
        /// <param name="validationHtml">The HTML that comprises the field's validation messages</param>
        /// <param name="fieldMetadata">The metadata for the field being created</param>
        /// <param name="fieldConfiguration">Configuration for the field</param>
        /// <param name="isValid">Whether or not the field is valid</param>
        /// <returns>The HTML for the field</returns>
         Nancy.ViewEngines.Razor.IHtmlString Field(Nancy.ViewEngines.Razor.IHtmlString labelHtml,  Nancy.ViewEngines.Razor.IHtmlString elementHtml,  Nancy.ViewEngines.Razor.IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration, bool isValid);

        /// <summary>
        /// Creates the beginning HTML for a single form field that contains other fields nested within it.
        /// </summary>
        /// <param name="labelHtml">The HTML that comprises the form label</param>
        /// <param name="elementHtml">The HTML that comprieses the field itself</param>
        /// <param name="validationHtml">The HTML that comprises the field's validation messages</param>
        /// <param name="fieldMetadata">The metadata for the field being created</param>
        /// <param name="fieldConfiguration">Configuration for the field</param>
        /// <param name="isValid">Whether or not the field is valid</param>
        /// <returns>The beginning HTML for the parent field</returns>
         Nancy.ViewEngines.Razor.IHtmlString BeginField(Nancy.ViewEngines.Razor.IHtmlString labelHtml,  Nancy.ViewEngines.Razor.IHtmlString elementHtml,  Nancy.ViewEngines.Razor.IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration, bool isValid);

        /// <summary>
        /// Creates the ending HTML for a single form field that contains other fields nested within it.
        /// </summary>
        /// <returns>The ending HTML for the parent field</returns>
         Nancy.ViewEngines.Razor.IHtmlString EndField();

        /// <summary>
        /// Creates the beginning HTML for a navigation section.
        /// </summary>
        /// <returns>The beginning HTML for a navigation section</returns>
         Nancy.ViewEngines.Razor.IHtmlString BeginNavigation();

        /// <summary>
        /// Creates the ending HTML for a navigation section.
        /// </summary>
        /// <returns>The ending HTML for a navigation section</returns>
         Nancy.ViewEngines.Razor.IHtmlString EndNavigation();

        /// <summary>
        /// Creates the beginning HTML for a message.
        /// </summary>
        /// <param name="messageType">The type of message being displayed</param>
        /// <param name="heading">The heading for the message</param>
        /// <returns>The beginning HTML for the message</returns>
         Nancy.ViewEngines.Razor.IHtmlString BeginMessage(MessageType messageType,  Nancy.ViewEngines.Razor.IHtmlString heading);

        /// <summary>
        /// Creates the ending HTML for a message.
        /// </summary>
        /// <returns>The ending HTML for the message</returns>
         Nancy.ViewEngines.Razor.IHtmlString EndMessage();

        /// <summary>
        /// Creates the HTML for a paragraph in a message.
        /// </summary>
        /// <param name="paragraph">The paragraph HTML</param>
        /// <returns>The HTML for the message paragraph</returns>
         Nancy.ViewEngines.Razor.IHtmlString MessageParagraph(Nancy.ViewEngines.Razor.IHtmlString paragraph);
    }
}