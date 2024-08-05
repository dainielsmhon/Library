using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //יצירת אובייקט מסוג לקוח עם שם משתמש והסיסמה שהוזנו 
            
                var LstUser=(List<User>)Application["User"];
                for (int i = 0; i < LstUser.Count; i++) 
            { 
            
                if (TxtEmail.Text == LstUser[i].Email && TxtPass.Text == LstUser[i].UserPass + "")
                {
                    Session["Login"] = true;
                    Response.Redirect("/Defalut");
                }
                else
                {
                    LtMsg2.Text = "שם וססמה אינם נכונים";
                    Response.Redirect("Register.aspx");
                }
            }
           
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}