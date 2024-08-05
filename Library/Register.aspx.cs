using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            {
             

            }


         
        }

        protected void BtnRagister_Click(object sender, EventArgs e)
        {
            string Msg = "";
            if (TxtFullName.Text.Length < 3)
                Msg += "עליך להזמין שם מלא <br/> ";
            if (TxtPass.Text.Length < 6 || TxtPass.Text.Contains(" "))
                Msg += "סיסמה לא תקינה מינימום 6 תווים ללא רווחים <br/>";
            if (ChkTerm.Checked == false)
                Msg += " אני מאשר את תנאי השימוש <br/>";
            if (RdFemale.Checked == false && RdMale.Checked == false)
                Msg += "חובה לסמן /> ";

            if (Msg != "")
            {
                TextMail.Text = Msg;
                //לא תקין
            }
            else
            {
                LtlMsg.Text = "נרשמת בהצלחה ברוך הבא";
                //תקין
                Session["Login"] = true;
                Response.Redirect("/Defalut");
            }
        }
    }
}