
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }

        public string UserPass { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public DateTime Added { get; set; }
        public DateTime JoinDate { get; set; }

        

        public int Save()//הוספה/עדכון
        {
            return UserDAL.Save(this);
        }
       // public int Save(string ContextNmae)//הוספה/עדכון
       // }
        public static User GetById(int id)//שליפה לפי ID
        {
            return UserDAL.GetById(id);
        }
        public static List<User> Get()//שליפת כולם
        {
            return UserDAL.Get();
        }
        public static int Delete(int id)//מחיקה לפי ID
        {
            return UserDAL.Delete(id);
        }

    }
}
