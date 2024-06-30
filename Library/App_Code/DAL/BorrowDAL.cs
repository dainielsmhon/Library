using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class BorrowDAL
    {

        public static Borrow GetById(int id)
        {
            Borrow Tmp = null;
            DbContext Db = new DbContext();
            string Sql = $" SELECT * FROM T_Borrow WHERE BorrowId={id}";
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count > 0)
            {
                Tmp = new Borrow()
                {
                    BorrowId = int.Parse(Dt.Rows[0]["BorrowId"] + ""),//תווים מהשורה הראשונה
                    BorrowName = Dt.Rows[0]["BorrowName"] + "",
                    Added = DateTime.Parse(Dt.Rows[0]["Added"] + "")

                };
            }


            return Tmp;//אם לא מצא כלום מחזיר כלום
        }
        public static List<Borrow> Get()
        {
            List<Borrow> LstTmp = new List<Borrow>();
            DbContext Db = new DbContext();
            string Sql = $" SELECT * FROM T_Borrow ";
            DataTable Dt = Db.Execute(Sql);
            for (int i = 0; i < Dt.Rows.Count; i++)//עובר על כל השורות שחזרו
            {
                Borrow Tmp = new Borrow()
                {
                    BorrowId = int.Parse(Dt.Rows[i]["BorrowId"] + ""),
                    BorrowName = Dt.Rows[i]["BorrowName"] + "",
                    Added = DateTime.Parse(Dt.Rows[i]["Added"] + "")

                };//מוסיף לרשימה 
                LstTmp.Add(Tmp);
            }


            return LstTmp;



        }
        public static int Delete(int id)
        {
            Borrow Tmp = null;
            DbContext Db = new DbContext();
            string Sql = $" DELETE FROM T_Borrow WHERE BorrowId={id}";
            int RecCount = 0;
            RecCount = Db.ExecuteNonQuery(Sql);

            return RecCount;
        }
        public static int Save(Borrow Tmp)
        {

            int RecCount = 0;
            DbContext Db = new DbContext();
            string Sql = "";
            if (Tmp.BorrowId == -1)
            {
                Sql = $"INSERT INTO t_Borrow (CitiName) Values(N'{Tmp.BorrowName}')";
            }
            else
            {
                Sql = $"UPDATE T_Borrow set BorrowName=N'{Tmp.BorrowName}' WHERE BorrowId={Tmp.BorrowId}";
            }

            RecCount = Db.ExecuteNonQuery(Sql);

            if (Tmp.BorrowId == -1)
            {
                Tmp.BorrowId = Db.GetMaxId("T_Borrow", "BorrowId");
            }


            return RecCount;
        }
    }

}