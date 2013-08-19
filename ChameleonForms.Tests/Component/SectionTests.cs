using System.Web;
using System.Web.Mvc;
using NancyContrib.Chameleon.Component;
using NancyContrib.Chameleon.Component.Config;
using NancyContrib.Chameleon.Templates;
using NSubstitute;
using NUnit.Framework;

namespace NancyContrib.Chameleon.Tests.Component
{
    [TestFixture]
    public class SectionShould
    {
        private readonly Nancy.ViewEngines.Razor.IHtmlString _beginHtml = new HtmlString("");
        private readonly Nancy.ViewEngines.Razor.IHtmlString _endHtml = new HtmlString("");
        private readonly Nancy.ViewEngines.Razor.IHtmlString _nestedBeginHtml = new HtmlString("");
        private readonly Nancy.ViewEngines.Razor.IHtmlString _nestedEndHtml = new HtmlString("");
        private IForm<object, IFormTemplate> _f;
        private readonly Nancy.ViewEngines.Razor.IHtmlString _title = new HtmlString("title");

        [SetUp]
        public void Setup()
        {
            _f = Substitute.For<IForm<object, IFormTemplate>>();
            _f.Template.BeginSection(Arg.Is Nancy.ViewEngines.Razor.IHtmlString>(h => h.ToHtmlString() == _title.ToHtmlString()), Arg.Any Nancy.ViewEngines.Razor.IHtmlString>(), Arg.Any<HtmlAttributes>()).Returns(_beginHtml);
            _f.Template.EndSection().Returns(_endHtml);
            _f.Template.BeginNestedSection(Arg.Is Nancy.ViewEngines.Razor.IHtmlString>(h => h.ToHtmlString() == _title.ToHtmlString()), Arg.Any Nancy.ViewEngines.Razor.IHtmlString>(), Arg.Any<HtmlAttributes>()).Returns(_nestedBeginHtml);
            _f.Template.EndNestedSection().Returns(_nestedEndHtml);
        }

        private Section<object, IFormTemplate> Arrange(bool isNested)
        {
            return new Section<object, IFormTemplate>(_f, _title, isNested);
        }

        [Test]
        public void Use_section_begin_from_template_for_begin_html()
        {
            var s = Arrange(false);

            Assert.That(s.Begin(), Is.EqualTo(_beginHtml));
        }

        [Test]
        public void Use_section_end_from_template_for_end_html()
        {
            var s = Arrange(false);

            Assert.That(s.End(), Is.EqualTo(_endHtml));
        }

        [Test]
        public void Use_nested_section_begin_from_template_for_nested_begin_html()
        {
            var s = Arrange(true);

            Assert.That(s.Begin(), Is.EqualTo(_nestedBeginHtml));
        }

        [Test]
        public void Use_nested_section_end_from_template_for_nested_end_html()
        {
            var s = Arrange(true);

            Assert.That(s.End(), Is.EqualTo(_nestedEndHtml));
        }

        [Test]
        public void Construct_section_via_extension_method()
        {
            var s = _f.BeginSection(_title.ToHtmlString());

            Assert.That(s, Is.Not.Null);
            _f.Received().Write(_beginHtml);
        }

        [Test]
        public void Construct_nested_section_via_extension_method()
        {
            var s = _f.BeginSection(_title.ToHtmlString());
            _f.ClearReceivedCalls();
            var ss = s.BeginSection(_title.ToHtmlString());

            Assert.That(ss, Is.Not.Null);
            _f.Received().Write(_nestedBeginHtml);
        }
        
        [Test]
        public void Output_a_field([Values(true, false)] bool isValid)
        {
            var labelHtml = Substitute.For Nancy.ViewEngines.Razor.IHtmlString>();
            var elementHtml = Substitute.For Nancy.ViewEngines.Razor.IHtmlString>();
            var validationHtml = Substitute.For Nancy.ViewEngines.Razor.IHtmlString>();
            var metadata = new ModelMetadata(Substitute.For<ModelMetadataProvider>(), null, null, typeof(string), null);
            var expectedOutput = new HtmlString("output");
            _f.Template.Field(labelHtml, elementHtml, validationHtml, metadata, Arg.Any<IReadonlyFieldConfiguration>(), isValid).Returns(expectedOutput);
            var s = Arrange(false);

            var config = s.Field(labelHtml, elementHtml, validationHtml, metadata, isValid: isValid);

            Assert.That(config.ToHtmlString(), Is.EqualTo(expectedOutput.ToHtmlString()));
        }
    }
}
