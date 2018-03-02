using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Wuyiju.Core;
using Wuyiju.IService;

namespace Wuyiju.Web.Utils.Controls
{
    public class Loop : Repeater
    {
        public LoopType LoopType
        {
            get { return (LoopType)ViewState["LoopType"]; }
            set { ViewState["LoopType"] = value; }
        }

        public int? CatId
        {
            get { return ViewState["CatId"] == null ? null : (int?)ViewState["CatId"]; }
            set { ViewState["CatId"] = value; }
        }

        public int? UserId
        {
            get { return ViewState["UserId"] == null ? null : (int?)ViewState["UserId"]; }
            set { ViewState["UserId"] = value; }
        }

        public int? Position
        {
            get { return ViewState["Position"] == null ? null : (int?)ViewState["Position"]; }
            set { ViewState["Position"] = value; }
        }

        public BoolType? IsHot
        {
            get { return ViewState["IsHot"] == null ? null : (BoolType?)ViewState["IsHot"]; }
            set { ViewState["IsHot"] = value; }
        }

        public int? IsNew
        {
            get { return (int?)ViewState["IsNew"]; }
            set { ViewState["IsNew"] = value; }
        }
        public int? Limit
        {
            get { return ViewState["Limit"] == null ? null : (int?)ViewState["Limit"]; }
            set { ViewState["Limit"] = value; }
        }

        public int? Start
        {
            get { return ViewState["Start"] == null ? null : (int?)ViewState["Start"]; }
            set { ViewState["Start"] = value; }
        }

        public string OrderBy
        {
            get { return ViewState["OrderBy"] == null ? null : (string)ViewState["OrderBy"]; }
            set { ViewState["OrderBy"] = value; }
        }

        public BoolType? Recommend
        {
            get { return ViewState["Recommend"] == null ? null : (BoolType?)ViewState["Recommend"]; }
            set { ViewState["Recommend"] = value; }
        }

        public BoolType? IsBest
        {
            get { return ViewState["IsBest"] == null ? null : (BoolType?)ViewState["IsBest"]; }
            set { ViewState["IsBest"] = value; }
        }

        public string AdType
        {
            get { return ViewState["AdType"] == null ? null : (string)ViewState["AdType"]; }
            set { ViewState["AdType"] = value; }
        }

        public string Type
        {
            get { return ViewState["Type"] == null ? null : (string)ViewState["Type"]; }
            set { ViewState["Type"] = value; }
        }



        protected override void OnLoad(EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            var unity = new UnityContext();

            if (this.LoopType == LoopType.Article)
            {
                var svr = unity.GetInstance<IArticleService>();
                this.DataSource = svr.GetList(new Model.Article.Query { Cate_Id = CatId, Status = 1 }, Limit);
                this.DataBind();
            }
            else if (this.LoopType == LoopType.Advertisement)
            {
                var svr = unity.GetInstance<IAdService>();
                this.DataSource = svr.GetList(new Model.Ad.Query { Position_Id = Position, Status = 1, Ad_Type = AdType, Type = this.Type }, Limit);
                this.DataBind();
            }
            else if (this.LoopType == LoopType.Link)
            {
                var svr = unity.GetInstance<ILinksService>();

                //int? isRecommend = null;

                //if (this.IsHot != null)
                //{
                //    isRecommend = this.Recommend.Value ? 1 : 0;
                //}

                this.DataSource = svr.GetList(new Model.Links.Query { Recommend = (int?)Recommend, Status = 1 }, Limit);
                this.DataBind();
            }
            else if (this.LoopType == LoopType.Title)
            {
                var svr = unity.GetInstance<ITitleService>();

                //int? isHots = null;

                //if (this.IsHot != null)
                //{
                //    isHots = this.IsHot.Value ? 1 : 0;
                //}

                //int? isRecommend = null;

                //if (this.IsHot != null)
                //{
                //    isRecommend = this.Recommend.Value ? 1 : 0;
                //}

                this.DataSource = svr.GetList(new Model.Title.Query { Recommend = (int?)Recommend, Parent_Id = CatId, Status = 1 }, Limit);
                this.DataBind();
            }
            else if (this.LoopType == LoopType.Category)
            {
                var svr = unity.GetInstance<ICategoryService>();

                IList<int> limits = new List<int>();

                if (Start != null && Start.HasValue)
                    limits.Add(Start.Value);

                if (Limit != null && Limit.HasValue)
                    limits.Add(Limit.Value);

                int[] newLimit = limits.ToArray<int>();

                this.DataSource = svr.GetList(new Model.Category.Query { Parent_Id = CatId, Recommend = (int?)Recommend, Status = 1 }, newLimit);
                this.DataBind();
            }
            else if (this.LoopType == LoopType.Attribute)
            {
                var svr = unity.GetInstance<IAttributeService>();
                this.DataSource = svr.GetList(new Model.Attribute.Query { Recommend = (int?)Recommend, Pid = CatId, Status = 1 }, Limit);
                this.DataBind();
            }
            else if (this.LoopType == LoopType.Question)
            {
                var svr = unity.GetInstance<IQuestionService>();
                this.DataSource = svr.GetList(new Model.Question.Query { Is_Best = (int?)IsBest, Type_Id = CatId, Status = 1, User_Id = UserId }, Limit);
                this.DataBind();
            }
            else if (this.LoopType == LoopType.QuestionType)
            {
                var svr = unity.GetInstance<IQuestionTypeService>();
                this.DataSource = svr.GetList(new Model.QuestionType.Query { }, Limit);
                this.DataBind();
            }
            else if (this.LoopType == LoopType.Region)
            {
                var svr = unity.GetInstance<IRegionService>();
                this.DataSource = svr.GetList(new Model.Region.Query { Parent_Id = CatId });
                this.DataBind();

            }
            else if (this.LoopType == LoopType.Product)
            {
                var svr = unity.GetInstance<IProductService>();
                this.DataSource = svr.GetList(new Model.Product.Query { Cat_Id = CatId.TryParseToString(null), Best = (int?)IsBest, Hot = (int?)IsHot, New = IsNew, Status = 1, Sales = 0 }, Limit);
                this.DataBind();

            }


        }

    }

    public enum LoopType
    {
        /// <summary>
        /// 文章
        /// </summary>
        Article = 1,

        /// <summary>
        /// 友情链接
        /// </summary>
        Link = 2,

        /// <summary>
        /// 广告
        /// </summary>
        Advertisement = 3,

        /// <summary>
        /// 网店
        /// </summary>
        Product = 4,

        /// <summary>
        /// 网店分类
        /// </summary>
        Category = 5,
        /// <summary>
        /// 
        /// </summary>
        Title = 6,
        /// <summary>
        /// 额外信息
        /// </summary>
        Attribute = 7,

        /// <summary>
        /// 问题
        /// </summary>
        Question = 8,

        /// <summary>
        /// 问题类型
        /// </summary>
        QuestionType = 9,

        Region = 10

    }

    public enum BoolType
    {
        True = 1,
        False = 0
    }
}
