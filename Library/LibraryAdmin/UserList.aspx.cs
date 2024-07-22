using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

namespace Library.LibraryAdmin
{
    public partial class book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //בעת הטעינה הראשונית נמלא את תוכן העמוד ברשימת המשתמשים
            if (!IsPostBack)
            {
                FillData();
            }

        }
        public void FillData()
        {
            //לשלוף את רשימת המשתמשים ולחבר אותם לרפיטר
            RpUser.DataSource = BLL.User.Get();
            RpUser.DataBind();
        }
    }
}