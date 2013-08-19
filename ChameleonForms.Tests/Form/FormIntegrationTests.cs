using System.Web.Mvc;
using ApprovalTests.Html;
using ApprovalTests.Reporters;
using NancyContrib.Chameleon.Tests.FieldGenerator;
using NancyContrib.Chameleon.Tests.Helpers;
using NUnit.Framework;
using NancyContrib.Chameleon.Component;
using Nancy.ViewEngines.Razor;

namespace NancyContrib.Chameleon.Tests.Form
{
    [TestFixture]
    [UseReporter(typeof(DiffReporter))]
    class IntegratedFormShould
    {
        private HtmlHelpers<TestFieldViewModel> _h;

        [SetUp]
        public void Setup()
        {
            var autoSubstitute = AutoSubstituteContainer.Create();
            _h = autoSubstitute.Resolve<HtmlHelpers<TestFieldViewModel>>();
        }

        [Test]
        public void Output_field_html_with_field_configuration_values()
        {
            var form = _h.BeginChameleonForm();

            var html = form.FieldFor(m => m.Decimal).AddClass("a-class").ToHtmlString();

            HtmlApprovals.VerifyHtml(html);
        }

        [Test]
        public void Output_label_html_with_field_configuration_values()
        {
            var form = _h.BeginChameleonForm();

            var html = form.LabelFor(m => m.Decimal).Label("LABEL").ToHtmlString();

            HtmlApprovals.VerifyHtml(html);
        }

        [Test]
        public void Output_required_field_using_default_template()
        {
            string html;
            using (var f = _h.BeginChameleonForm())
            {
                using (var s = f.BeginSection("Section"))
                {
                    html = s.FieldFor(m => m.Decimal).AddClass("a-class").Label("LABEL").ToHtmlString();
                }
            }

            HtmlApprovals.VerifyHtml(html);
        }

        [Test]
        public void Output_optional_field_using_default_template()
        {
            string html;
            using (var f = _h.BeginChameleonForm())
            {
                using (var s = f.BeginSection("Section"))
                {
                    html = s.FieldFor(m => m.NullableDateTime).ToHtmlString();
                }
            }

            HtmlApprovals.VerifyHtml(html);
        }
    }
}