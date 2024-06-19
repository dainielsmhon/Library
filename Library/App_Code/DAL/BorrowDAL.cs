using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class BorrowDAL
    {

        public static Borrow GetById(int id)
        {
            Borrow Tmp = new Borrow();
            return Tmp;
        }
        public static List<Borrow> Get()
        {
            List<Borrow> LstTmp = new List<Borrow>();
            return LstTmp;
        }
        public static int Delete(int id)
        {
            return 1;
        }
        public static int Save(Borrow Tmp)
        {
            return 1;
        }

    }
}