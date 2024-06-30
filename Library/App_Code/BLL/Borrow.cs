using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Borrow
    {
        public int BorrowId { get; set; }
        public int BookId { get; set; }
        public string BorrowName { get; set; }

        public int UserId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDatePlan { get; set; }
        public DateTime ActualReturnDate { get; set; }
        public string Notse { get; set; }
        public string Status { get; set; }
        public DateTime Added { get; set; }
        public DateTime TakenDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int Save()//הוספה/עדכון
        {
            return BorrowDAL.Save(this);
        }
        public static Borrow GetById(int id)//שליפה לפי ID
        {
            return BorrowDAL.GetById(id);
        }
        public static List<Borrow> Get()//שליפת כולם
        {
            return BorrowDAL.Get();
        }
        public static int Delete(int id)//מחיקה לפי ID
        {
            return BorrowDAL.Delete(id);
        }
    }
}
    