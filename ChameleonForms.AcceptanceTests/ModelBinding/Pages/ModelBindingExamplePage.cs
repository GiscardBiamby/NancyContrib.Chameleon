using NancyContrib.Chameleon.Example.Controllers;
using OpenQA.Selenium;

namespace NancyContrib.Chameleon.AcceptanceTests.ModelBinding.Pages
{
    public class ModelBindingExamplePage : ChameleonFormsPage<ModelBindingViewModel>
    {
        public ModelBindingExamplePage Submit(ModelBindingViewModel vm)
        {
            InputModel(vm);
            return Navigate().To<ModelBindingExamplePage>(By.CssSelector("button[type=submit]"));
        }
    }
}
