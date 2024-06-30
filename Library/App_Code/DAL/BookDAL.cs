using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using System.Data;

namespace DAL
{
    public class BookDAL
    {

        public static Book GetById(int id)
        {
            Book Tmp = null;
            DbContext Db = new DbContext();
            string Sql = $" SELECT * FROM T_Book WHERE BookId={id}";
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count > 0)
            {
                Tmp = new Book()
                {
                    BookId = int.Parse(Dt.Rows[0]["BookId"] + ""),//תווים מהשורה הראשונה
                    BookName = Dt.Rows[0]["BookName"] + "",
                    Added = DateTime.Parse(Dt.Rows[0]["Added"] + "")

                };
            }


            return Tmp;//אם לא מצא כלום מחזיר כלום
        }
        public static List<Book> Get()
        {
            List<Book> LstTmp = new List<Book>();
            DbContext Db = new DbContext();
            string Sql = $" SELECT * FROM T_Book ";
            DataTable Dt = Db.Execute(Sql);
            for (int i = 0; i < Dt.Rows.Count; i++)//עובר על כל השורות שחזרו
            {
                Book Tmp = new Book()
                {
                    BookId = int.Parse(Dt.Rows[i]["BookId"] + ""),
                    BookName = Dt.Rows[i]["BookName"] + "",
                    Added = DateTime.Parse(Dt.Rows[i]["Added"] + "")

                };//מוסיף לרשימה 
                LstTmp.Add(Tmp);
            }


            return LstTmp;



        }
        public static int Delete(int id)
        {
            Book Tmp = null;
            DbContext Db = new DbContext();
            string Sql = $" DELETE FROM T_Book WHERE BookId={id}";
            int RecCount = 0;
            RecCount = Db.ExecuteNonQuery(Sql);

            return RecCount;
        }
        public static int Save(Book Tmp)
        {

            int RecCount = 0;
            DbContext Db = new DbContext();
            string Sql = "";
            if (Tmp.BookId == -1)
            {
                Sql = $"INSERT INTO t_Book (CitiName) Values(N'{Tmp.BookName}')";
            }
            else
            {
                Sql = $"UPDATE T_Book set BookName=N'{Tmp.BookName}' WHERE BookId={Tmp.BookId}";
            }

            RecCount = Db.ExecuteNonQuery(Sql);

            if (Tmp.BookId == -1)
            {
                Tmp.BookId = Db.GetMaxId("T_Book", "BookId");
            }


            return RecCount;
        }
    }
}