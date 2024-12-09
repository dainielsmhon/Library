using BLL;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

//namespace DATA
//{
//    public class MongoContext
//    {
//        public string ConnStrMongo { get; set; }
//        public MongoClient Client  { get; set; }

//       // ConnStrMongo= ConfigurationManager.ConnectionStrings["ConnStrMongo"].ConnectionString;

//        public int InsertOne(String CollectionNmae,BsonDocument Tmp)
//        var client = new MongoClient(ConnStrMongo);//הגדרת אובייקט לצורך עבודה עם בסיס הנתונים
//        var Db = client.GetDatabase("Library");//בחירת בסיס הנתונים מולו מעונינים לעבוד
//        Collation.insertOne(Tmp);
//        var LogsB = Db.GetCollection<DbLogs>("DBLogs");
//    }
//}