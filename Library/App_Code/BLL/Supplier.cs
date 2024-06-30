using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace BLL
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        public string SupplierName { get; set; }

        public string SAddress { get; set; }
        public string SPhone { get; set; }
        public string SWeb { get; set; }
        public string SEmail { get; set; }
        public DateTime Added { get; set; }
        public string Contact { get; set; }


        public int Save()//הוספה/עדכון
        {
            return SupplierDAL.Save(this);
        }
        public static Supplier GetById(int id)//שליפה לפי ID
        {
            return SupplierDAL.GetById(id);
        }
        public static List<Supplier> Get()//שליפת כולם
        {
            return SupplierDAL.Get();
        }
        public static int Delete(int id)//מחיקה לפי ID
        {
            return SupplierDAL.Delete(id);
        }
    }
}
