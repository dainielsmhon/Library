using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class Users
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime JoinDate { get; set; }


        public int Save()//הוספה/עדכון
        {
            return UsersDAL.Save(this);
        }
        public static Users GetById(int id)//שליפה לפי ID
        {
            return UsersDAL.GetById(id);
        }
        public static List<Users> Get()//שליפת כולם
        {
            return UsersDAL.Get();
        }
        public static int Delete(int id)//מחיקה לפי ID
        {
            return UsersDAL.Delete(id);
        }

    }
}
