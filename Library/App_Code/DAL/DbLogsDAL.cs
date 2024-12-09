//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Linq;
//using System.Web;
//using BLL;
//using DATA;
//using MongoDB.Bson;
//using MongoDB.Driver;

//namespace DAL
//{
//    public class DbLogsDAL
//    {
//        public static int Save(DbLogs Tmp)
//        {
//            try
//            {
//                // string ConnStrMongo = "mongodb://localhost:27017/";//הגדרת משתנה עם מחזרות התחברות לבסיס הנתונים
//                string ConnStrMongo = ConfigurationManager.ConnectionStrings["ConnStrMongo"].ConnectionString;
//                var client = new MongoClient(ConnStrMongo);//הגדרת אובייקט לצורך עבודה עם בסיס הנתונים
//                var Db = client.GetDatabase("Library");//בחירת בסיס הנתונים מולו מעונינים לעבוד

//                var Logs = Db.GetCollection<DbLogs>("DBLogs");

//                var LogsB = Db.GetCollection<BsonDocument>("DBLogs");//יוצר חיבור לקולקשן בשיטת ביסון

//                var LogB = new BsonDocument()
//                {
//                    //{"_id","abc333" },
//                    { "operation", Tmp.operation },
//                    { "user", Tmp.user },
//                    { "date", Tmp.data }

//                };
//                LogsB.InsertOne(LogB);
//            }
//            catch (Exception ex)
//            {
               

//            }
//            return 1;
//        }
//    }
//}