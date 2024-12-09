using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using DAL;

namespace BLL
{
    public class Book
    {
     
        public int  BookId { get; set; }       
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public DateTime Year { get; set; }
        public string BookDescription { get; set; }
        public string BookLang { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public DateTime Added { get; set; }

        public DateTime TakenDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public int Save()//הוספה/עדכון
        {
            return BookDAL.Save(this);
        }

        public static Book GetById(int id)//שליפה לפי ID
        {
            return BookDAL.GetById(id);
        }
        public static List<Book> Get()//שליפת כולם
        {
            return BookDAL.Get();
        }
        public static int Delete(int id)//מחיקה לפי ID
        {
            return BookDAL.Delete(id);
        }

    }
}