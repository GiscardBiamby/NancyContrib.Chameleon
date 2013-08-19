using System.Web;
using NancyContrib.Chameleon.Templates;

namespace NancyContrib.Chameleon.Example.Forms.Templates
{
    public class RandomFormTemplate : DefaultFormTemplate
    {
        public string RandomComponent()
        {
            return "RANDOM unencoded string &\"<g>!";
        }

        public Nancy.ViewEngines.Razor.IHtmlString RandomComponent2()
        {
            return new HtmlString("<p>Some encoded HTML</p>");
        }
    }
}