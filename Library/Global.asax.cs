using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Services.Description;
using System.Web.SessionState;

namespace Library
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            
            User tmp;
            

            string ConnStr;
            string Sql = " select * from t_Users";//הגדרת מחרוזת עם משפט שאילתה 

            //שליפת מחרוזת ההתחברות מתוך קובץ הקופיג
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            //ניצור אובייקט מסוג חיבור /צינור לבסיס הנתונים
            // SqlConnection Conn=new SqlConnection(ConnStr);

            // ניצור אובייקט מסוג חיבור / צינור לבסיס הנתונים
            SqlConnection Conn = new SqlConnection();
            //הגדרת מחרוזת התחברות עבור אובייקט הצינור 
            Conn.ConnectionString = ConnStr;
            Conn.Open(); //פתיחת הצינור /החבירו לבסיס הנתונים

            //הגדרת אובייקט מסוג פקודה של שאילתה
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Conn;   //הגדרת הצינור בו ישתמש אובייקט הפקודה 
            Cmd.CommandText = Sql;// הגדרת השאילתה אותה עלינו לבצע 

            SqlDataReader Dr;// הגדרת קורה נתונים משחזרו משאילתה סלקט

            Dr = Cmd.ExecuteReader();//הפעלת השאילתה והכוונת קורא הנתונים לתוצאות שחזרו

            List<User> LstProd = new List<User>();


            while (Dr.Read())// נבצע לולאה שעוברת רשומה רשומה על התוצאות שחזרו 
                             //אם קיים תחזיר אמת אחרת שקר 
            {
                tmp = new User()//יצירת אובייקט מסוג מוצר מאותחל בערכים של כל אחד מהמוצרים
                {
                    UserId = (int)Dr["UserId"],
                    UserName = Dr["UserName"] + "",
                    UserPass = Dr["UserPass"] + "",
                    Email = Dr["Email"] + ""
                };
                LstProd.Add(tmp);
            }
            Dr.Close();


            {
                //הגדרת אובייקט מסוג פקודה של שאילתה
                Sql = "select * from t_Users";
                Cmd.CommandText = Sql;// הגדרת השאילתה אותה עלינו לבצע 


                Dr = Cmd.ExecuteReader();//הפעלת השאילתה והכוונת קורא הנתונים לתוצאות שחזרו

                List<User> LstUser = new List<User>();


                while (Dr.Read())// נבצע לולאה שעוברת רשומה רשומה על התוצאות שחזרו 
                                 //אם קיים תחזיר אמת אחרת שקר 
                {
                    tmp = new User()//יצירת אובייקט מסוג מוצר מאותחל בערכים של כל אחד מהמוצרים
                    {
                        UserId = (int)Dr["UserId"],
                        Email = Dr["Email"] + "",
                        UserPass = Dr["UserPass"] + "",
                        UserName = Dr["UserName"] + ""

                    };
                    LstProd.Add(tmp);
                }
                Dr.Close();
                Application["User"] = LstUser;
                Conn.Close();
            }


         


          
           

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}