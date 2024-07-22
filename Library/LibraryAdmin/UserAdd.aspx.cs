using BLL;
using Newtonsoft.Json.Linq;
using System;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using System.Xml.Linq;

namespace Library.LibraryAdmin
{
    public partial class UserAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
                FillData();




            }

        }
        public void FillData()
        {
            User Tmp = null;
            string UserId = Request["UserId"] + "";
            if (string.IsNullOrEmpty(UserId))
            {
                UserId = "-1"; //הוספת משתמש חדש
            }
            else
            {
                Tmp = BLL.User.GetById(int.Parse(UserId));
                if (Tmp == null)
                {
                    UserId = "-1";//הוספת משתמש חדש
                }
            }
            HidUserId.Value = UserId;// שמירת שם משתמש  לעריכה או הוספה בשדה הנסתר
            //נמלא את כל הטופס בנתונים הראשים שלו

            if (Tmp!=null)//אנחנו במצב עריכה של משתמש לכן יש  למלא את הפרטים
            {
                Tmp.UserId = Tmp.UserId;
                TxtName.Text = Tmp.Name;
                TxtEmail.Text = Tmp.Email;
                TxtUserPass.Text = Tmp.UserPass;
                TxtPhone.Text = Tmp.Phone;
                TxtAdress.Text = Tmp.Adress;
                TxtJoinDate.Text = Tmp.JoinDate.ToString("yyyy-MM-dd");

            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            User Tmp = new User()
            {



                UserId = int.Parse(HidUserId.Value),
                Name = TxtName.Text,
                Email = TxtEmail.Text,
                UserPass = TxtUserPass.Text,
                Phone = TxtPhone.Text,
                Adress = TxtAdress.Text,
                JoinDate = DateTime.Parse(TxtJoinDate.Text)
            };
            
            Tmp.Save();
            Response.Redirect("UserList.aspx");
        }
    }
}