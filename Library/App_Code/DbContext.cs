using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;



namespace DATA
{
    public class DbContext
    {
        public string ConnStr { get; set; } 
        public SqlConnection Conn { get; set; }
        public DbContext() {
            ConnStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            //ניצור אובייקט מסוג חיבור /צינור לבסיס הנתונים
            // SqlConnection Conn=new SqlConnection(ConnStr);

            // ניצור אובייקט מסוג חיבור / צינור לבסיס הנתונים
            Conn = new SqlConnection();
            //הגדרת מחרוזת התחברות עבור אובייקט הצינור 
            Conn.ConnectionString = ConnStr;
            Conn.Open(); //פתיחת הצינור /החבירו לבסיס הנתונים

        }
        public DbContext(string ConnStr)
        {
            this.ConnStr = ConnStr;
            Conn = new SqlConnection(ConnStr);
            Conn.ConnectionString = ConnStr;//שולחים
            Conn.Open(); //יוצרים חיבור

        }
        public void Close()
        {
            Conn.Close();
        }
        public int ExecuteNonQuery(String Sql)//שאילתות שלא מחזירות ערך כמו עדכון מחיקה אינסרט
        {
            
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Connection = Conn;   //הגדרת הצינור בו ישתמש אובייקט הפקודה 
            Cmd.CommandText = Sql;// הגדרת השאילתה אותה עלינו לבצע 

            int RetVal = Cmd.ExecuteNonQuery();//פונקציה משמשת שאילתה שלא מושכונות נתונים כמו הוספה עדכון מחיקה 
            Cmd.Dispose();//משמש לשחרור הזיכרון
            return RetVal;//החזרת מספר הרשומות שהושפעו מהשאילתה 
        }
        public int GetMaxId(string TableName, string PrimaryKeyName)//מזינים שם טבלה ומפתח ראשי וזה נותן את הID הגדול
        {
            int MaxId = -1;
            string Sql = $"SELECT MAX( {PrimaryKeyName}) FROM {TableName} ";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            MaxId = (int)Cmd.ExecuteScalar();
            Cmd.Dispose();
            //   Close();
            return MaxId;
        }
        public DataTable ExecuteWithParams(string Sql, List<SqlParameter> Params)
        {
            DataTable Dt = new DataTable();
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            for (int i = 0; i < Params.Count; i++)
            {
                Cmd.Parameters.Add(Params[i]);
            }
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            Da.Fill(Dt);
            Cmd.Dispose();
            //  Close();
            return Dt;
        }
        public int ExecuteNonQueryWithParams(string Sql, List<SqlParameter> Params)
        {
            int RecCount = 0;
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            for (int i = 0; i < Params.Count; i++)
            {
                Cmd.Parameters.Add(Params[i]);
            }
            RecCount = Cmd.ExecuteNonQuery();
            Cmd.Dispose();
            //  Close();
            return RecCount;
        }
        public string GetValueByKey(string TableName, string KeyName, string ValueName, string KeyValue)
        {
            string RetValue = null;
            string Sql = $"SELECT top 1 {ValueName} FROM {TableName} where {KeyName}='{KeyValue}'  ";
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            RetValue = (string)(Cmd.ExecuteScalar() + "");
            Cmd.Dispose();
            //   Close();
            return RetValue;
        }

        public static List<SqlParameter> CreateParameters(object parametersObject)
        {
            var parameters = new List<SqlParameter>();

            foreach (PropertyInfo property in parametersObject
                .GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                parameters.Add(new SqlParameter($"@{property.Name}", property.GetValue(parametersObject, null)));
            }

            return parameters;
        }

        public object ExecuteScalar(string Sql)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Conn;   //הגדרת הצינור בו ישתמש אובייקט הפקודה 
            Cmd.CommandText = Sql;// הגדרת השאילתה אותה עלינו לבצע 
            object RetVal = Cmd.ExecuteScalar();//פונקציה משמשת שאילתה שלא מושכונות נתונים כמו הוספה עדכון מחיקה 
            Cmd.Dispose();//משמש לשחרור הזיכרון
            return RetVal;//החזרת מספר הרשומות שהושפעו מהשאילתה
        }
        public DataTable Execute(String Sql)//פונקציה זו תשמש לשליפה של הנתונים
        {
            SqlCommand Cmd = new SqlCommand(Sql, Conn);
            Cmd.Connection = Conn;   //הגדרת הצינור בו ישתמש אובייקט הפקודה 
            Cmd.CommandText = Sql;// הגדרת השאילתה אותה עלינו לבצע 
            DataTable Dt = new DataTable();//יצירת אובייקט מסוג טבלת נתונים
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);//הגדרת אובייקט מסוג מתאם נתונים
            Da.SelectCommand = Cmd;//הגדרת תותח השאילתות אותו יתפעל המתאם
            Da.Fill(Dt);//מילוי טבלת הנתונים בתוצאות שחזרו מהשאילתה
            Cmd.Dispose();
            return Dt;//החזרת טבלת הנתונים שחזרה מהשאילתה 
        }
    }
}