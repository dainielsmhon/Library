using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class LogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // לסיים את הסשן של המשתמש
            Session.Abandon();

            // לנקות את הקוקיות הנוגעות לסשן
            if (Request.Cookies["ASP.NET_SessionId"] != null)
            {
                HttpCookie sessionCookie = new HttpCookie("ASP.NET_SessionId", string.Empty);
                sessionCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(sessionCookie);
            }

            // הפניה לדף הראשי או לדף אחר לאחר ההתנתקות
            Response.Redirect("Default1.aspx");
        }
    }
}