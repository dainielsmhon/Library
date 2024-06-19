using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class BooksDAL
    {

        public static Books GetById(int id)
        {
            Books Tmp = new Books();
            return Tmp;
        }
        public static List<Books> Get()
        {
            List<Books> LstTmp = new List<Books>();
            return LstTmp;
        }
        public static int Delete(int id)
        {
            return 1;
        }
        public static int Save(Books Tmp)
        {
            return 1;
        }

    }
}