using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class SuppliersDAL
    {

        public static Suppliers GetById(int id)
        {
            Suppliers Tmp = new Suppliers();
            return Tmp;
        }
        public static List<Suppliers> Get()
        {
            List<Suppliers> LstTmp = new List<Suppliers>();
            return LstTmp;
        }
        public static int Delete(int id)
        {
            return 1;
        }
        public static int Save(Suppliers Tmp)
        {
            return 1;
        }

    }
}