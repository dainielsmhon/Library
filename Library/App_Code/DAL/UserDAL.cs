using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class UserDAL
    {

        public static User GetById(int id)
        {
            User Tmp = null;
            DbContext Db = new DbContext();
            string Sql = $" SELECT * FROM T_User WHERE UserId={id}";
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count > 0)
            {
                Tmp = new User()
                {
                    UserId = int.Parse(Dt.Rows[0]["UserId"] + ""),//תווים מהשורה הראשונה
                    UserName = Dt.Rows[0]["UserName"] + "",
                    Added = DateTime.Parse(Dt.Rows[0]["Added"] + "")

                };
            }


            return Tmp;//אם לא מצא כלום מחזיר כלום
        }
        public static List<User> Get()
        {
            List<User> LstTmp = new List<User>();
            DbContext Db = new DbContext();
            string Sql = $" SELECT * FROM T_User ";
            DataTable Dt = Db.Execute(Sql);
            for (int i = 0; i < Dt.Rows.Count; i++)//עובר על כל השורות שחזרו
            {
                User Tmp = new User()
                {
                    UserId = int.Parse(Dt.Rows[i]["UserId"] + ""),
                    UserName = Dt.Rows[i]["UserName"] + "",
                    Added = DateTime.Parse(Dt.Rows[i]["Added"] + "")

                };//מוסיף לרשימה 
                LstTmp.Add(Tmp);
            }


            return LstTmp;



        }
        public static int Delete(int id)
        {
            User Tmp = null;
            DbContext Db = new DbContext();
            string Sql = $" DELETE FROM T_User WHERE UserId={id}";
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
                Sql = $"INSERT INTO t_User (CitiName) Values(N'{Tmp.UserName}')";
            }
            else
            {
                Sql = $"UPDATE T_User set UserName=N'{Tmp.UserName}' WHERE UserId={Tmp.UserId}";
            }

            RecCount = Db.ExecuteNonQuery(Sql);

            if (Tmp.UserId == -1)
            {
                Tmp.UserId = Db.GetMaxId("T_User", "UserId");
            }


            return RecCount;
        }
    }

}