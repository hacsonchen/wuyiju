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
    public partial class Detail : BasePage
    {
        public Model.Article Model;

        protected void Page_Load(object sender, EventArgs e)
        {
            var articleService = unity.GetInstance<IArticleService>();

            int id = 0;

            try
            {

                id = Convert.ToInt32(Request.QueryString["id"]);
            }
            catch
            {
                Response.Redirect("/");
            }

            Model = articleService.GetArticle(id);



            if (Model == null)
            {
                Response.Redirect("/");
            }
            else
            {
                Model.Click += 1;
                articleService.Modify(Model);
            }

            //获取顶置文章
            var articles2 = articleService.GetList(new Model.Article.Query { Cate_Id = Model.Cate_Id, Is_Hot = 1, Status = 1 }, 5);

        }
    }
}