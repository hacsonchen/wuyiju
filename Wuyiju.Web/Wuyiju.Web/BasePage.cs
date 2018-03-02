using Wuyiju.Core;

namespace Wuyiju.Web
{
    public class BasePage : System.Web.UI.Page
    {
        protected UnityContext unity;


        public string Keyword;

        public string Description;

        public BasePage()
        {
            if (unity == null)
            {
                unity = new UnityContext();
            }

        }

    }
}