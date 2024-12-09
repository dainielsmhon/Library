//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using Amazon.Runtime.SharedInterfaces;
//using BLL;
//using MongoDB.Bson;
//using MongoDB.Driver;

//namespace Library
//{
//    public partial class Mongo : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            if (!IsPostBack)
//            {
//                string ConnStr = "mongodb://localhost:27017/";//הגדרת משתנה עם מחזרות התחברות לבסיס הנתונים
//                var client = new MongoClient(ConnStr);//הגדרת אובייקט לצורך עבודה עם בסיס הנתונים
//                var Db = client.GetDatabase("Library");//בחירת בסיס הנתונים מולו מעונינים לעבוד
//                var Logs = Db.GetCollection<DbLogs>("DBLogs");
//                var Log = new DbLogs()
//                {
//                    _id ="abcd123",
//                    user = 5,
//                    operation = "delete",
//                    data = DateTime.Now//ToString(

//                };
//                  LogsB.InsertOne(LogB);
//                vavar r LogsB = Db.GetCollection<BsonDocument>("DBLogs");//יוצר חיבור לקולקשן בשיטת ביסון
//                var LogeB = new BsonDocument()
//                {
//                    {"_id","abc1233" },
//                    { "operation", "update" },
//                    { "user", 18 },
//                    { "date", DateTime.Now }

//                };
//                LogsB.InsertOne(LogeB);

//            }
//        }
//    }
//}