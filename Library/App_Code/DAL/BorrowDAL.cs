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
                        BorrowId = int.Parse(Dt.Rows[0]["BorrowId"] + ""),
                        BookId = int.Parse(Dt.Rows[0]["BookId"] + ""),
                        BorrowName = Dt.Rows[0]["BorrowName"] + "",
                        UserId = int.Parse(Dt.Rows[0]["UserId"] + ""),
                        BorrowDate = DateTime.Parse(Dt.Rows[0]["BorrowDate"] + ""),
                        ReturnDatePlan = DateTime.Parse(Dt.Rows[0]["ReturnDatePlan"] + ""),
                        ActualReturnDate = DateTime.Parse(Dt.Rows[0]["ActualReturnDate"] + ""),
                        Notse = Dt.Rows[0]["Notse"] + "",
                        Status = Dt.Rows[0]["Status"] + "",
                        Added = DateTime.Parse(Dt.Rows[0]["Added"] + ""),
                        TakenDate = DateTime.Parse(Dt.Rows[0]["TakenDate"] + ""),
                        ReturnDate = DateTime.Parse(Dt.Rows[0]["ReturnDate"] + ""),
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
                        BorrowId = int.Parse(Dt.Rows[0]["BorrowId"] + ""),
                        BookId = int.Parse(Dt.Rows[0]["BookId"] + ""),
                        BorrowName = Dt.Rows[0]["BorrowName"] + "",
                        UserId = int.Parse(Dt.Rows[0]["UserId"] + ""),
                        BorrowDate = DateTime.Parse(Dt.Rows[0]["BorrowDate"] + ""),
                        ReturnDatePlan = DateTime.Parse(Dt.Rows[0]["ReturnDatePlan"] + ""),
                        ActualReturnDate = DateTime.Parse(Dt.Rows[0]["ActualReturnDate"] + ""),
                        Notse = Dt.Rows[0]["Notse"] + "",
                        Status = Dt.Rows[0]["Status"] + "",
                        Added = DateTime.Parse(Dt.Rows[0]["Added"] + ""),
                        TakenDate = DateTime.Parse(Dt.Rows[0]["TakenDate"] + ""),
                        ReturnDate = DateTime.Parse(Dt.Rows[0]["ReturnDate"] + ""),
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

                    Sql = $"INSERT INTO t_Agent (BorrowId,BookId,BorrowName,UserId,BorrowDate,ReturnDatePlan,ActualReturnDate,Notse,Status,Added,TakenDate,ReturnDate) Values ";
                    Sql += $" (N'{Tmp.BorrowId}',N'{Tmp.BookId}',N'{Tmp.UserId}',N'{Tmp.BorrowName}',N'{Tmp.Notse}',N'{Tmp.Status},{Tmp.Added.ToString("yyyy-MM-dd")}''{Tmp.BorrowDate.ToString("yyyy-MM-dd")}''{Tmp.ReturnDatePlan.ToString("yyyy-MM-dd")}''{Tmp.ActualReturnDate.ToString("yyyy-MM-dd")}''{Tmp.TakenDate.ToString("yyyy-MM-dd")}''{Tmp.ReturnDate.ToString("yyyy-MM-dd")}')";
                }
                else 
                {
                    Sql = $"UPDATE T_Agent set ";
                    Sql += $"BorrowId=N'{Tmp.BorrowId}', ";
                    Sql += $"BookId=N'{Tmp.BookId}', ";
                    Sql += $"BorrowName=N'{Tmp.BorrowName}', ";
                    Sql += $"UserId=N'{Tmp.UserId}', ";
                    Sql += $"BorrowDate='{Tmp.BorrowDate.ToString("yyyy-MM-dd")}' ";
                    Sql += $"ReturnDatePlan='{Tmp.ReturnDatePlan.ToString("yyyy-MM-dd")}' ";
                    Sql += $"ActualReturnDate='{Tmp.ActualReturnDate.ToString("yyyy-MM-dd")}' ";
                    Sql += $"Notse={Tmp.Notse}, ";
                    Sql += $"Status={Tmp.Status}, ";
                    Sql += $"Added='{Tmp.Added.ToString("yyyy-MM-dd")}' ";
                    Sql += $"TakenDate='{Tmp.TakenDate.ToString("yyyy-MM-dd")}' ";
                    Sql += $"ReturnDate='{Tmp.ReturnDate.ToString("yyyy-MM-dd")}' ";
                    Sql += $" WHERE BorrowId={Tmp.BorrowId}";
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