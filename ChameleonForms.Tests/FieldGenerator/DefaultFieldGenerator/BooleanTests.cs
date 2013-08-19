﻿using ApprovalTests.Html;
using NancyContrib.Chameleon.Component.Config;
using NUnit.Framework;

namespace NancyContrib.Chameleon.Tests.FieldGenerator.DefaultFieldGenerator
{
    class BooleanTests : DefaultFieldGeneratorShould
    {
        [Test]
        public void Use_correct_html_for_single_checkbox_with_default_label()
        {
            var g = Arrange(m => m.RequiredBoolean);

            var result = g.GetFieldHtml(default(IFieldConfiguration));

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_checked_single_checkbox_with_default_label()
        {
            var g = Arrange(m => m.RequiredBoolean, m => m.RequiredBoolean = true);

            var result = g.GetFieldHtml(default(IFieldConfiguration));

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_single_checkbox_with_custom_label()
        {
            var g = Arrange(m => m.RequiredBoolean);

            var result = g.GetFieldHtml(new FieldConfiguration().InlineLabel("Some label"));

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_boolean_list_and_false_value()
        {
            var g = Arrange(m => m.RequiredBoolean);

            var result = g.GetFieldHtml(new FieldConfiguration().AsList());

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_boolean_list_and_true_value()
        {
            var g = Arrange(m => m.RequiredBoolean, m => m.RequiredBoolean = true);

            var result = g.GetFieldHtml(new FieldConfiguration().AsList());

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_optional_boolean_list_and_no_value()
        {
            var g = Arrange(m => m.OptionalBooleanField);

            var result = g.GetFieldHtml(new FieldConfiguration().AsList());

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_optional_boolean_dropdown_and_no_value()
        {
            var g = Arrange(m => m.OptionalBooleanField);

            var result = g.GetFieldHtml(new FieldConfiguration().AsDropDown());

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_optional_boolean_and_no_value()
        {
            var g = Arrange(m => m.OptionalBooleanField);

            var result = g.GetFieldHtml(new FieldConfiguration().AsDropDown());

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_boolean_list_and_custom_labels()
        {
            var g = Arrange(m => m.RequiredBoolean);

            var result = g.GetFieldHtml(new FieldConfiguration().AsList().WithTrueAs("True").WithFalseAs("False"));

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_boolean_dropdown_list_and_false_value()
        {
            var g = Arrange(m => m.RequiredBoolean);

            var result = g.GetFieldHtml(new FieldConfiguration().AsDropDown());

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_boolean_dropdown_list_and_true_value()
        {
            var g = Arrange(m => m.RequiredBoolean, m => m.RequiredBoolean = true);

            var result = g.GetFieldHtml(new FieldConfiguration().AsDropDown());

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_nullable_required_boolean_checkbox_with_no_value()
        {
            var g = Arrange(m => m.RequiredNullableBoolean);

            var result = g.GetFieldHtml(default(IFieldConfiguration));

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_nullable_required_boolean_list_with_no_value()
        {
            var g = Arrange(m => m.RequiredNullableBoolean);

            var result = g.GetFieldHtml(new FieldConfiguration().AsList());

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

        [Test]
        public void Use_correct_html_for_nullable_required_boolean_dropdown_with_no_value()
        {
            var g = Arrange(m => m.RequiredNullableBoolean);

            var result = g.GetFieldHtml(new FieldConfiguration().AsDropDown());

            HtmlApprovals.VerifyHtml(result.ToHtmlString());
        }

    }
}
