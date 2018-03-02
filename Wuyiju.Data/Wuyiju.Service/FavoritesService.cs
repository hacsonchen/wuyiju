using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wuyiju.Core;
using Wuyiju.DAL;
using Wuyiju.IDAL;
using Wuyiju.IService;
using Wuyiju.Model;
namespace Wuyiju.Service {
	 	//ec_favorites
		public class FavoritesService: BaseService<IFavoritesDAL>, IFavoritesService
	{
		
		#region  Method
		

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Wuyiju.Model.Favorites obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            dao.Insert(obj);
        }

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Modify(Wuyiju.Model.Favorites obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            var old = dao.Get(obj.Rec_Id);

            if (old == null)
                throw new ApplicationException("非法操作记录不存在");

            dao.Update(obj);
        }

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Remove(Wuyiju.Model.Favorites obj)
        {
            if (obj == null)
                throw new ApplicationException("参数不能为空");

            var old = dao.Get(obj.Rec_Id);

            if (old == null)
                throw new ApplicationException("非法操作记录不存在");

            dao.Delete(obj.Rec_Id);

        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Favorites GetFavorites(int rec_id)
        {
            if (rec_id == null)
                throw new ApplicationException("参数不能为空");

            return dao.Get(rec_id);
        }


		/// <summary>
		/// 获得数据列表
		/// </summary>
		public IList<Wuyiju.Model.Favorites> GetList(Wuyiju.Model.Favorites.Query query)
        {
            return dao.GetList(query);
        }

        
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public IList<Wuyiju.Model.Favorites> GetList(Wuyiju.Model.Favorites.Query query, int? limit = null)
        {
            return dao.GetList(query, limit);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public Paged<Wuyiju.Model.Favorites> GetPaged(PagedQuery<Wuyiju.Model.Favorites.Query> query)
        {
            return dao.GetPaged(query);
        }

#endregion
   
	}
}