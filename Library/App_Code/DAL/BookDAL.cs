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
                    BookId = int.Parse(Dt.Rows[0]["BookIdId"] + ""),
                    BookName = Dt.Rows[0]["BookName"] + "",
                    BookAuthor = Dt.Rows[0]["BookAuthor"] + "",
                    Year = DateTime.Parse(Dt.Rows[0]["Year"] + ""),
                    BookDescription = Dt.Rows[0]["BookDescription"] + "",
                    BookLang = Dt.Rows[0]["BookLang"] + "",
                    Location = Dt.Rows[0]["Location"] + "",
                    Status = Dt.Rows[0]["Status"] + "",
                    Added = DateTime.Parse(Dt.Rows[0]["Added"] + ""),
                    TakenDate = DateTime.Parse(Dt.Rows[0]["TakenDate"] + ""),
                    ReturnDate = DateTime.Parse(Dt.Rows[0]["ReturnDate"] + "")

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
                    BookId = int.Parse(Dt.Rows[0]["BookIdId"] + ""),
                    BookName = Dt.Rows[0]["BookName"] + "",
                    BookAuthor = Dt.Rows[0]["BookAuthor"] + "",
                    Year = DateTime.Parse(Dt.Rows[0]["Year"] + ""),
                    BookDescription = Dt.Rows[0]["BookDescription"] + "",
                    BookLang = Dt.Rows[0]["BookLang"] + "",
                    Location = Dt.Rows[0]["Location"] + "",
                    Status = Dt.Rows[0]["Status"] + "",
                    Added = DateTime.Parse(Dt.Rows[0]["Added"] + ""),
                    TakenDate = DateTime.Parse(Dt.Rows[0]["TakenDate"] + ""),
                    ReturnDate = DateTime.Parse(Dt.Rows[0]["ReturnDate"] + "")

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

                Sql = $"INSERT INTO t_Agent (BookId,BookName,BookAuthor,Year,BookDescription,BookLang,Location,Status,Added,TakenDate,ReturnDate) Values ";
                Sql += $" (N'{Tmp.BookId}',N'{Tmp.BookName}',N'{Tmp.BookAuthor}',N'{Tmp.Year}',N'{Tmp.BookDescription}',N'{Tmp.BookLang}',N'{Tmp.Location},'{Tmp.Added.ToString("yyyy-MM-dd")}''{Tmp.TakenDate.ToString("yyyy-MM-dd")}''{Tmp.ReturnDate.ToString("yyyy-MM-dd")}')";
            }
            else
            {
                Sql = $"UPDATE T_Agent set ";
                Sql += $"BookId=N'{Tmp.BookId}', ";
                Sql += $"BookName=N'{Tmp.BookName}', ";
                Sql += $"BookAuthor=N'{Tmp.BookAuthor}', ";
                Sql += $"Year=N'{Tmp.Year}', ";
                Sql += $"BookDescription=N'{Tmp.BookDescription}', ";
                Sql += $"BookLang=N'{Tmp.BookLang}', ";
                Sql += $"Location={Tmp.Location}, ";
                Sql += $"Status={Tmp.Status}, ";
                Sql += $"Added='{Tmp.Added.ToString("yyyy-MM-dd")}' ";
                Sql += $"TakenDate='{Tmp.TakenDate.ToString("yyyy-MM-dd")}' ";
                Sql += $"ReturnDate='{Tmp.ReturnDate.ToString("yyyy-MM-dd")}' ";
                Sql += $" WHERE BookId={Tmp.BookId}";
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