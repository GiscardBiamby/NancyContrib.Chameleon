﻿using System.Web;
using System.Web.Mvc;
using Autofac;
using AutofacContrib.NSubstitute;
using NancyContrib.Chameleon.Enums;
using NancyContrib.Chameleon.FieldGenerators;
using NancyContrib.Chameleon.Templates;
using NancyContrib.Chameleon.Tests.Helpers;
using NSubstitute;
using NUnit.Framework;
using Nancy.ViewEngines.Razor;

namespace NancyContrib.Chameleon.Tests
{
    [TestFixture]
    class FormShould
    {
        public class TestFieldViewModel
        {
            public string SomeProperty { get; set; }
        }

        #region Setup
        private AutoSubstitute _autoSubstitute;
        private HtmlHelpers<TestFieldViewModel> _h;
        private IFormTemplate _t;

        private readonly Nancy.ViewEngines.Razor.IHtmlString _beginHtml = new HtmlString("");
        private readonly Nancy.ViewEngines.Razor.IHtmlString _endHtml = new HtmlString("");

        private const string Action = "/";
        private const FormMethod Method = FormMethod.Post;
        private const EncType Enctype = EncType.Multipart;
        private readonly HtmlAttributes _htmlAttributes = new HtmlAttributes();

        [SetUp]
        public void Setup()
        {
            _autoSubstitute = AutoSubstituteContainer.Create();
            _h = _autoSubstitute.ResolveAndSubstituteFor<HtmlHelpers<TestFieldViewModel>>();
            _t = _autoSubstitute.Resolve<IFormTemplate>();
            _t.BeginForm(Action, Method, _htmlAttributes, Enctype).Returns(_beginHtml);
            _t.EndForm().Returns(_endHtml);
        }

        private Form<TestFieldViewModel, IFormTemplate> CreateForm()
        {
            return _autoSubstitute.Resolve<Form<TestFieldViewModel, IFormTemplate>>(
                new NamedParameter("action", Action),
                new NamedParameter("method", Method),
                new NamedParameter("htmlAttributes", _htmlAttributes),
                new NamedParameter("enctype", Enctype)
            );
        }
        #endregion

        [Test]
        public void Store_html_helper()
        {
            var f = CreateForm();

            Assert.That(f.HtmlHelper, Is.EqualTo(_h));
        }

        [Test]
        public void Store_template()
        {
            var f = CreateForm();

            Assert.That(f.Template, Is.EqualTo(_t));
        }

        [Test]
        public void Write_start_of_form_on_construction()
        {
            CreateForm();

            _h.ViewContext.Writer.Received().Write(_beginHtml);
            _h.ViewContext.Writer.DidNotReceive().Write(_endHtml);
        }

        [Test]
        public void Write_end_of_form_on_disposal()
        {
            var f = CreateForm();

            f.Dispose();

            _h.ViewContext.Writer.Received().Write(_endHtml);
        }

        [Test]
        public void Construct_form_via_extension_method()
        {
            var t = new DefaultFormTemplate();

            var f2 = _h.BeginChameleonForm(Action, Method, new HtmlAttributes(), Enctype);

            Assert.That(f2, Is.Not.Null);
            _h.ViewContext.Writer.Received().Write(Arg.Is<Nancy.ViewEngines.Razor.IHtmlString>(h => h.ToHtmlString() == t.BeginForm(Action, Method, _htmlAttributes, Enctype).ToHtmlString()));
        }

        [Test]
        public void Give_a_field_generator()
        {
            var f = CreateForm();

            var g = f.GetFieldGenerator(m => m.SomeProperty);

            Assert.That(g, Is.TypeOf<DefaultFieldGenerator<TestFieldViewModel, string>>());
        }
    }
}
