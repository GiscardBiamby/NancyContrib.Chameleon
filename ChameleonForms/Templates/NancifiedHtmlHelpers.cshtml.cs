﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NancyContrib.Chameleon.Templates {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;

#line 1 "..\..\Templates\HtmlHelpers.cshtml"
    using System.Web.Mvc;

#line default
#line hidden
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;

#line 2 "..\..\Templates\HtmlHelpers.cshtml"
    using Component.Config;

#line default
#line hidden

#line 3 "..\..\Templates\HtmlHelpers.cshtml"
    using Enums;

#line default
#line hidden

#line 5 "..\..\Templates\HtmlHelpers.cshtml"
    using Nancy.ViewEngines.Razor;

#line default
#line hidden

#line 4 "..\..\Templates\HtmlHelpers.cshtml"
    using Templates;

#line default
#line hidden

    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public class HtmlHelpers : HelperPage {

#line 11 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult EndForm() {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 11 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "    </form>\r\n");


#line 13 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 13 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 15 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult BeginSection(Nancy.ViewEngines.Razor.IHtmlString title, Nancy.ViewEngines.Razor.IHtmlString leadingHtml, HtmlAttributes htmlAttributes) {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 15 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "    <fieldset");


#line 16 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, htmlAttributes);


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, ">\r\n");

                WriteLiteralTo(__razor_helper_writer, "        <legend>");


#line 17 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, title);


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "</legend>\r\n");

                WriteLiteralTo(__razor_helper_writer, "        ");


#line 18 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, leadingHtml);


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "\r\n");

                WriteLiteralTo(__razor_helper_writer, "        <dl>\r\n");


#line 20 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 20 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 22 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult BeginNestedSection(Nancy.ViewEngines.Razor.IHtmlString title, Nancy.ViewEngines.Razor.IHtmlString leadingHtml, HtmlAttributes htmlAttributes) {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 23 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "            <dt>");


#line 24 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, title);


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

                WriteLiteralTo(__razor_helper_writer, "            <dd>\r\n");

                WriteLiteralTo(__razor_helper_writer, "                ");


#line 26 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, leadingHtml);


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "\r\n");

                WriteLiteralTo(__razor_helper_writer, "                <dl");


#line 27 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, htmlAttributes);


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 28 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 28 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 30 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult EndSection() {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 30 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "        </dl>\r\n");

                WriteLiteralTo(__razor_helper_writer, "    </fieldset>\r\n");


#line 33 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 33 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 35 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult EndNestedSection() {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 35 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "                </dl>\r\n");

                WriteLiteralTo(__razor_helper_writer, "            </dd>\r\n");


#line 38 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 38 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 40 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult GetPrependedHtml(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 40 "..\..\Templates\HtmlHelpers.cshtml"

                if (fieldConfiguration != null) {
                    foreach (var html in fieldConfiguration.PrependedHtml) {

#line default
#line hidden

#line 42 "..\..\Templates\HtmlHelpers.cshtml"
                        WriteTo(__razor_helper_writer, html);


#line default
#line hidden

#line 42 "..\..\Templates\HtmlHelpers.cshtml"
                    }
                }


#line default
#line hidden
            });

#line 44 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 46 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult GetAppendedHtml(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 46 "..\..\Templates\HtmlHelpers.cshtml"

                if (fieldConfiguration != null) {
                    foreach (var html in fieldConfiguration.AppendedHtml) {

#line default
#line hidden

#line 48 "..\..\Templates\HtmlHelpers.cshtml"
                        WriteTo(__razor_helper_writer, html);


#line default
#line hidden

#line 48 "..\..\Templates\HtmlHelpers.cshtml"
                    }
                }


#line default
#line hidden
            });

#line 50 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 52 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult GetHint(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 52 "..\..\Templates\HtmlHelpers.cshtml"

                if (fieldConfiguration != null && fieldConfiguration.Hint != null) {

#line default
#line hidden
                    WriteLiteralTo(__razor_helper_writer, "<div");

                    WriteLiteralTo(__razor_helper_writer, " class=\"hint\"");

                    WriteLiteralTo(__razor_helper_writer, ">");


#line 53 "..\..\Templates\HtmlHelpers.cshtml"
                    WriteTo(__razor_helper_writer, fieldConfiguration.Hint);


#line default
#line hidden
                    WriteLiteralTo(__razor_helper_writer, "</div>");


#line 53 "..\..\Templates\HtmlHelpers.cshtml"
                }


#line default
#line hidden
            });

#line 54 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 56 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult BeginFieldInternal(Nancy.ViewEngines.Razor.IHtmlString labelHtml, Nancy.ViewEngines.Razor.IHtmlString elementHtml, Nancy.ViewEngines.Razor.IHtmlString validationHtml, IReadonlyFieldConfiguration fieldConfiguration, ModelMetadata fieldMetadata) {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 56 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "            <dt>");


#line 57 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, labelHtml);


#line default
#line hidden

#line 57 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, new HtmlString(fieldMetadata != null && fieldMetadata.IsRequired ? " <em class=\"required\">*</em>" : ""));


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "</dt>\r\n");

                WriteLiteralTo(__razor_helper_writer, "            <dd>\r\n");

                WriteLiteralTo(__razor_helper_writer, "                ");


#line 59 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, GetPrependedHtml(fieldConfiguration));


#line default
#line hidden

#line 59 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, elementHtml);


#line default
#line hidden

#line 59 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, GetAppendedHtml(fieldConfiguration));


#line default
#line hidden

#line 59 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, GetHint(fieldConfiguration));


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, " ");


#line 59 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, validationHtml);


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 60 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 60 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 62 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult Field(Nancy.ViewEngines.Razor.IHtmlString labelHtml, Nancy.ViewEngines.Razor.IHtmlString elementHtml, Nancy.ViewEngines.Razor.IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 62 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden

#line 63 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, BeginFieldInternal(labelHtml, elementHtml, validationHtml, fieldConfiguration, fieldMetadata));


#line default
#line hidden

#line 63 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "            </dd>\r\n");


#line 65 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 65 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 67 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult BeginField(Nancy.ViewEngines.Razor.IHtmlString labelHtml, Nancy.ViewEngines.Razor.IHtmlString elementHtml, Nancy.ViewEngines.Razor.IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 68 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden

#line 69 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, BeginFieldInternal(labelHtml, elementHtml, validationHtml, fieldConfiguration, fieldMetadata));


#line default
#line hidden

#line 69 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "                <dl>\r\n");


#line 71 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 71 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 73 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult EndField() {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 73 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "                </dl>\r\n");

                WriteLiteralTo(__razor_helper_writer, "            </dd>\r\n");


#line 76 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 76 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 78 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult BeginNavigation() {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 78 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "        <div class=\"form_navigation\">\r\n");


#line 80 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 80 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 82 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult EndNavigation() {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 82 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "        </div>\r\n");


#line 84 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 84 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 86 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult BeginMessage(MessageType messageType, Nancy.ViewEngines.Razor.IHtmlString heading) {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 86 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "      <div class=\"");


#line 87 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, string.Format("{0}{1}", messageType.ToString().ToLower(), "_message"));


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "\">\r\n");

                WriteLiteralTo(__razor_helper_writer, "          <h3>");


#line 88 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, heading);


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "</h3>\r\n");

                WriteLiteralTo(__razor_helper_writer, "          <div class=\"message\">\r\n");


#line 90 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 90 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 92 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult EndMessage() {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 92 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "          </div>\r\n");

                WriteLiteralTo(__razor_helper_writer, "      </div>\r\n");


#line 95 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 95 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 97 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult MessageParagraph(Nancy.ViewEngines.Razor.IHtmlString paragraph) {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 97 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "    <p>\r\n");

                WriteLiteralTo(__razor_helper_writer, "        ");


#line 99 "..\..\Templates\HtmlHelpers.cshtml"
                WriteTo(__razor_helper_writer, paragraph);


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "\r\n");

                WriteLiteralTo(__razor_helper_writer, "    </p>\r\n");


#line 101 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 101 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

#line 103 "..\..\Templates\HtmlHelpers.cshtml"
        public static Nancy.ViewEngines.Razor.HelperResult List(IEnumerable<Nancy.ViewEngines.Razor.IHtmlString> items) {
#line default
#line hidden
            return new Nancy.ViewEngines.Razor.HelperResult(__razor_helper_writer => {

#line 103 "..\..\Templates\HtmlHelpers.cshtml"



#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "    <ul>\r\n");


#line 105 "..\..\Templates\HtmlHelpers.cshtml"
                foreach (var i in items) {


#line default
#line hidden
                    WriteLiteralTo(__razor_helper_writer, "        <li>");


#line 106 "..\..\Templates\HtmlHelpers.cshtml"
                    WriteTo(__razor_helper_writer, i);


#line default
#line hidden
                    WriteLiteralTo(__razor_helper_writer, "</li>\r\n");


#line 107 "..\..\Templates\HtmlHelpers.cshtml"
                }


#line default
#line hidden
                WriteLiteralTo(__razor_helper_writer, "    </ul>\r\n");


#line 109 "..\..\Templates\HtmlHelpers.cshtml"


#line default
#line hidden
            });

#line 109 "..\..\Templates\HtmlHelpers.cshtml"
        }
#line default
#line hidden

    }
}
#pragma warning restore 1591
