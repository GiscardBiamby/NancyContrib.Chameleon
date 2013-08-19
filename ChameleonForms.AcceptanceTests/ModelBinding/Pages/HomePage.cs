using OpenQA.Selenium;
using TestStack.Seleno.PageObjects;

namespace NancyContrib.Chameleon.AcceptanceTests.ModelBinding.Pages
{
    public class HomePage : Page
    {
        public ModelBindingExamplePage GoToModelBindingExamplePage()
        {
            return Navigate().To<ModelBindingExamplePage>(By.LinkText("Model Binding Example"));
        }

        public ModelBindingExamplePage GoToModelBindingExamplePage2()
        {
            return Navigate().To<ModelBindingExamplePage>(By.LinkText("Model Binding Example with lists"));
        }
    }
}
