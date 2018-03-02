using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wuyiju.IService;
using Wuyiju.Model;
using Wuyiju.Web.Utils;

namespace Wuyiju.Web.users
{
    public partial class EditInfo : UserPage
    {
        public User Model;
        protected void Page_Load(object sender, EventArgs e)
        {
            Model = ModelBind<User>(Request.Params);
            var svr = unity.GetInstance<IUserService>();

            if (Request.Form.Count > 0 && LoggedUser.Id != 0)
            {
                Model.Id = LoggedUser.Id;
                Model.Name = LoggedUser.Name;

                if (!LoggedUser.Mobile.Equals(Model.Mobile))
                    Model.Is_Mobile_Validated = 0;

                if (!LoggedUser.Email.Equals(Model.Email))
                    Model.Is_Email_Validated = 0;

                svr.ModifyInfo(Model);

                LoggedState.Refresh();

            }
            else
            {
                Model = svr.GetUser(LoggedUser.Name);
            }


        }
    }
}