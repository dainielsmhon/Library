using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Xml.Linq;

namespace DAL
{
    public class UserDAL
    {


        public static User GetById(int id)
        {
            User Tmp = null;
            DbContext Db = new DbContext();
            string Sql = $" SELECT * FROM T_Users WHERE UserId={id}";
            DataTable Dt = Db.Execute(Sql);
            if (Dt.Rows.Count > 0)

            {
               
                Tmp = new User()
                {
                    UserId = int.Parse(Dt.Rows[0]["UserId"] + ""),
                    UserName = Dt.Rows[0]["UserName"] + "",
                    Name = Dt.Rows[0]["Name"] + "",
                    UserPass = Dt.Rows[0]["UserPass"] + "",
                    Email = Dt.Rows[0]["Email"] + "",
                    Phone = Dt.Rows[0]["Phone"] + "",
                    Adress = Dt.Rows[0]["Adress"] + "",
                    JoinDate = DateTime.Parse(Dt.Rows[0]["JoinDate"] + "")
                    

                };
            }


            return Tmp;//אם לא מצא כלום מחזיר כלום
        }
        public static List<User> Get()
        {
            List<User> LstTmp = new List<User>();
            DbContext Db = new DbContext();
            string Sql = $" SELECT * FROM T_Users ";
            DataTable Dt = Db.Execute(Sql);
            for (int i = 0; i < Dt.Rows.Count; i++)//עובר על כל השורות שחזרו
            {
                User Tmp = new User()
                {
                    UserId = int.Parse(Dt.Rows[0]["UserId"] + ""),
                    UserName = Dt.Rows[0]["UserName"] + "",
                    Name = Dt.Rows[0]["Name"] + "",
                    UserPass = Dt.Rows[0]["UserPass"] + "",
                    Email = Dt.Rows[0]["Email"] + "",
                    Phone = Dt.Rows[0]["Phone"] + "",
                    Adress = Dt.Rows[0]["Adress"] + "",
                    JoinDate = DateTime.Parse(Dt.Rows[0]["JoinDate"] + "")

                };//מוסיף לרשימה 
                LstTmp.Add(Tmp);
            }


            return LstTmp;



        }
        public static int Delete(int id)
        {
            User Tmp = null;
            DbContext Db = new DbContext();
            string Sql = $" DELETE FROM T_Users WHERE UserId={id}";
            int RecCount = 0;
            RecCount = Db.ExecuteNonQuery(Sql);

            return RecCount;
        }
        public static int Save(User Tmp)
        {

            int RecCount = 0;
            DbContext Db = new DbContext();
            string Sql = "";
            if (Tmp.UserId == -1)
            {

                Sql = $"INSERT INTO T_Users (UserId,Name,UserName,UserPass,Email,Phone,Adress,JoinDate) Values ";
                Sql += $" (N'{Tmp.UserId}',N'{Tmp.Name}',N'{Tmp.UserName}',N'{Tmp.UserPass}',N'{Tmp.Email}',N'{Tmp.Phone}',N'{Tmp.Adress}','{Tmp.JoinDate.ToString("yyyy-MM-dd")}')";
            }
            else
                
            {
                Sql = $"UPDATE T_Users set ";
                Sql += $"UserId=N'{Tmp.UserId}', ";
                Sql += $"UserName=N'{Tmp.UserName}', ";
                Sql += $"Name=N'{Tmp.Name}', ";
                Sql += $"UserPass=N'{Tmp.UserPass}', ";
                Sql += $"Email=N'{Tmp.Email}', ";
                Sql += $"Phone=N'{Tmp.Phone}', ";
                Sql += $"Adress=N'{Tmp.Adress}', ";
                Sql += $"JoinDate='{Tmp.JoinDate.ToString("yyyy-MM-dd")}' ";
                Sql += $" WHERE UserId={Tmp.UserId}";
            }

            RecCount = Db.ExecuteNonQuery(Sql);

            if (Tmp.UserId == -1)
            {
                Tmp.UserId = Db.GetMaxId("T_Users", "UserId");
            }


            return RecCount;
        }
    }

}