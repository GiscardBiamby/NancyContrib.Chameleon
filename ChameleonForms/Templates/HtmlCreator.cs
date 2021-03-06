﻿using System.Web;
using System.Web.Mvc;
using NancyContrib.Chameleon.Enums;
using Humanizer;
using Nancy.ViewEngines.Razor;

namespace NancyContrib.Chameleon.Templates
{
    /// <summary>
    /// Helper class that creates HTML for a view.
    /// </summary>
    public static class HtmlCreator
    {
        /// <summary>
        /// Creates the HTML for a form tag.
        /// </summary>
        /// <param name="action">The URL the form submits to</param>
        /// <param name="method">The HTTP method the form submits with</param>
        /// <param name="htmlAttributes">Any HTML attributes that should be applied to the form; specified as an anonymous object</param>
        /// <param name="encType">The encoding type the form uses</param>
        /// <returns>The HTML for the form</returns>
        public static Nancy.ViewEngines.Razor.IHtmlString BuildFormTag(string action, FormMethod method, HtmlAttributes htmlAttributes = null, EncType? encType = null)
        {
            var tagBuilder = new TagBuilder("form");
            if (htmlAttributes != null)
                tagBuilder.MergeAttributes(htmlAttributes.Attributes);
            tagBuilder.MergeAttribute("action", action);
            tagBuilder.MergeAttribute("method", method.GetFormMethodString(), true);
            if (encType.HasValue)
            {
                tagBuilder.MergeAttribute("enctype", encType.Humanize());
            }
            return new NonEncodedHtmlString(tagBuilder.ToString(TagRenderMode.StartTag));
        }

        /// <summary>
        /// Creates the HTML for a submit &lt;button&gt;.
        /// </summary>
        /// <param name="text">The text to display for the button</param>
        /// <param name="type">The type of submit button; submit (default) or reset</param>
        /// <param name="value">The value to submit with the button</param>
        /// <param name="id">The id/name to use for the button</param>
        /// <param name="htmlAttributes">Any HTML attributes that should be applied to the button</param>
        /// <returns>The HTML for the submit button</returns>
        public static Nancy.ViewEngines.Razor.IHtmlString BuildButton(string text, string type = null, string id = null, string value = null, HtmlAttributes htmlAttributes = null)
        {
            return BuildButton(new NonEncodedHtmlString(HttpUtility.HtmlEncode(text)), type, id, value, htmlAttributes);
        }

        /// <summary>
        /// Creates the HTML for a submit &lt;button&gt;.
        /// </summary>
        /// <param name="content">The content to display for the button</param>
        /// <param name="type">The type of submit button; submit (default) or reset</param>
        /// <param name="value">The value to submit with the button</param>
        /// <param name="id">The id/name to use for the button</param>
        /// <param name="htmlAttributes">Any HTML attributes that should be applied to the button</param>
        /// <returns>The HTML for the submit button</returns>
        public static Nancy.ViewEngines.Razor.IHtmlString BuildButton(Nancy.ViewEngines.Razor.IHtmlString content, string type = null, string id = null, string value = null, HtmlAttributes htmlAttributes = null)
        {
            var t = new TagBuilder("button") {InnerHtml = content.ToHtmlString()};
            if (value != null)
                t.Attributes.Add("value", value);
            if (type != null)
                t.Attributes.Add("type", type);
            if (id != null)
            {
                t.Attributes.Add("id", id);
                t.Attributes.Add("name", id);
            }
            if (htmlAttributes != null)
                t.MergeAttributes(htmlAttributes.Attributes, true);

            return new NonEncodedHtmlString(t.ToString(TagRenderMode.Normal));
        }

        /// <summary>
        /// Creates the HTML for a single checkbox.
        /// </summary>
        /// <param name="name">The name/id for the checkbox</param>
        /// <param name="isChecked">Whether or not the checkbox is currently checked</param>
        /// <param name="htmlAttributes">Any HTML attributes that should be applied to the checkbox</param>
        /// <param name="value">The value to submit when the checkbox is ticked</param>
        /// <returns>The HTML for the checkbox</returns>
        public static Nancy.ViewEngines.Razor.IHtmlString BuildSingleCheckbox(string name, bool isChecked, HtmlAttributes htmlAttributes, string value = "true")
        {
            var t = new TagBuilder("input");
            t.Attributes.Add("value", value);
            t.Attributes.Add("type", "checkbox");
            if (value == "true")
                t.GenerateId(name);
            t.Attributes.Add("name", name);
            if (isChecked)
                t.Attributes.Add("checked", "checked");
            if (htmlAttributes != null)
                t.MergeAttributes(htmlAttributes.Attributes, false);

            return new NonEncodedHtmlString(t.ToString(TagRenderMode.SelfClosing));
        }

        /// <summary>
        /// Creates the HTML for an input.
        /// </summary>
        /// <param name="name">The name/id of the input</param>
        /// <param name="value">The value of the input</param>
        /// <param name="type">The type of the input</param>
        /// <param name="htmlAttributes">Any HTML attributes that should be applied to the button</param>
        /// <returns>The HTML for the input</returns>
        public static Nancy.ViewEngines.Razor.IHtmlString BuildInput(string name, string value, string type, HtmlAttributes htmlAttributes)
        {
            var t = new TagBuilder("input");
            t.Attributes.Add("name", name);
            t.GenerateId(name);
            t.Attributes.Add("value", value);
            t.Attributes.Add("type", type);
            if (htmlAttributes != null)
                t.MergeAttributes(htmlAttributes.Attributes, true);

            return new NonEncodedHtmlString(t.ToString(TagRenderMode.SelfClosing));
        }

        /// <summary>
        /// Creates the HTML for a label.
        /// </summary>
        /// <param name="for">The name/id for the checkbox</param>
        /// <param name="labelText">The text inside the label</param>
        /// <param name="htmlAttributes">Any HTML attributes that should be applied to the checkbox</param>
        /// <returns>The HTML for the checkbox</returns>
        public static Nancy.ViewEngines.Razor.IHtmlString BuildLabel(string @for,  Nancy.ViewEngines.Razor.IHtmlString labelText, HtmlAttributes htmlAttributes)
        {
            var t = new TagBuilder("label");
            t.Attributes.Add("for", TagBuilder.CreateSanitizedId(@for));
            t.InnerHtml = labelText.ToHtmlString();

            if (htmlAttributes != null)
                t.MergeAttributes(htmlAttributes.Attributes, false);

            return new NonEncodedHtmlString(t.ToString(TagRenderMode.Normal));
        }
    }
}
