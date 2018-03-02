using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Model;

namespace Wuyiju.Web
{
    public partial class Interview : BasePage
    {
        public Model.Article Model;
        public IList<Model.Article> ModelList;

        protected void Page_Load(object sender, EventArgs e)
        {
            var articleService = unity.GetInstance<IArticleService>();

            ModelList = articleService.GetList(new Wuyiju.Model.Article.Query { Cate_Id = 46 });

            ModelList = ModelList.OrderByDescending(d => d.Add_Time).ToList();

            int id = 0;

            try
            {

                id = Convert.ToInt32(Request.QueryString["id"]);

            }
            catch
            {
                Response.Redirect("/");
            }

            if (ModelList == null || ModelList.Count == 0)
                Response.Redirect("/");

            if (id > 0)
            {
                Model = articleService.GetArticle(id);
                if (Model.Cate_Id != 46)
                {
                    Model = ModelList[0];
                }
            }
            else
            {
                Model = ModelList[0];
            }

        }
    }
}