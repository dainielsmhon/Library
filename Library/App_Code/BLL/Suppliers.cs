using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace BLL
{
    public class Suppliers
    {
        public int SId { get; set; }
        public string SName { get; set; }
        public string SAddress { get; set; }
        public string SPhone { get; set; }
        public string SWeb { get; set; }
        public string SEmail { get; set; }
        public string Contact { get; set; }


        public int Save()//הוספה/עדכון
        {
            return SuppliersDAL.Save(this);
        }
        public static Suppliers GetById(int id)//שליפה לפי ID
        {
            return SuppliersDAL.GetById(id);
        }
        public static List<Suppliers> Get()//שליפת כולם
        {
            return SuppliersDAL.Get();
        }
        public static int Delete(int id)//מחיקה לפי ID
        {
            return SuppliersDAL.Delete(id);
        }
    }
}
