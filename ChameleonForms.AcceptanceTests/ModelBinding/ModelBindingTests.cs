﻿using NancyContrib.Chameleon.AcceptanceTests.Helpers;
using NancyContrib.Chameleon.AcceptanceTests.ModelBinding.Pages;
using NUnit.Framework;
using TestStack.Seleno.Configuration;

namespace NancyContrib.Chameleon.AcceptanceTests.ModelBinding
{
    [TestFixture]
    class ModelBindingShould
    {
        [Test]
        public void Function_correctly_with_default_form()
        {
            var enteredViewModel = ObjectMother.ModelBindingViewModels.BasicValid;

            var page = SelenoHost.NavigateToInitialPage<HomePage>()
                .GoToModelBindingExamplePage()
                .Submit(enteredViewModel);

            Assert.That(page.GetFormValues(), IsSame.ViewModelAs(enteredViewModel));
            Assert.That(page.HasValidationErrors(), Is.False, "There are validation errors on the page");
        }

        [Test]
        public void Function_correctly_with_checkbox_and_radio_lists()
        {
            var enteredViewModel = ObjectMother.ModelBindingViewModels.BasicValid;

            var page = SelenoHost.NavigateToInitialPage<HomePage>()
                .GoToModelBindingExamplePage2()
                .Submit(enteredViewModel);

            Assert.That(page.GetFormValues(), IsSame.ViewModelAs(enteredViewModel));
            Assert.That(page.HasValidationErrors(), Is.False, "There are validation errors on the page");
        }
    }
}
