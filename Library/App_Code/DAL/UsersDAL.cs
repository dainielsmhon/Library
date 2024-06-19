using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class UsersDAL
    {
        public static Users GetById(int id)
        {
            Users Tmp = new Users();
            return Tmp;
        }
        public static List<Users> Get()
        { 
         List<Users>LstTmp = new List<Users>();
            return LstTmp;
        }
        public static int Delete(int id)
        {
            return 1;
        }
        public static int Save(Users Tmp)
        {
            return 1;
        }

    }
}