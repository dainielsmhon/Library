using BLL;
using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class SupplierDAL
    {

        public static Supplier GetById(int id)
        {
            Supplier Tmp = null;
            DbContext Db = new DbContext();
            string Sql = $" SELECT * FROM T_Supplier WHERE SupplierId={id}";
            DataTable Dt = Db.Execute(Sql);

            if (Dt.Rows.Count > 0)
            {
                Tmp = new Supplier()
                {
                    SupplierId = int.Parse(Dt.Rows[0]["SupplierId"] + ""),//תווים מהשורה הראשונה
                    SupplierName = Dt.Rows[0]["SupplierName"] + "",
                    Added = DateTime.Parse(Dt.Rows[0]["Added"] + "")

                };
            }


            return Tmp;//אם לא מצא כלום מחזיר כלום
        }
        public static List<Supplier> Get()
        {
            List<Supplier> LstTmp = new List<Supplier>();
            DbContext Db = new DbContext();
            string Sql = $" SELECT * FROM T_Supplier ";
            DataTable Dt = Db.Execute(Sql);
            for (int i = 0; i < Dt.Rows.Count; i++)//עובר על כל השורות שחזרו
            {
                Supplier Tmp = new Supplier()
                {
                    SupplierId = int.Parse(Dt.Rows[i]["SupplierId"] + ""),
                    SupplierName = Dt.Rows[i]["SupplierName"] + "",
                    Added = DateTime.Parse(Dt.Rows[i]["Added"] + "")

                };//מוסיף לרשימה 
                LstTmp.Add(Tmp);
            }


            return LstTmp;



        }
        public static int Delete(int id)
        {
            Supplier Tmp = null;
            DbContext Db = new DbContext();
            string Sql = $" DELETE FROM T_Supplier WHERE SupplierId={id}";
            int RecCount = 0;
            RecCount = Db.ExecuteNonQuery(Sql);

            return RecCount;
        }
        public static int Save(Supplier Tmp)
        {

            int RecCount = 0;
            DbContext Db = new DbContext();
            string Sql = "";
            if (Tmp.SupplierId == -1)
            {
                Sql = $"INSERT INTO t_Supplier (CitiName) Values(N'{Tmp.SupplierName}')";
            }
            else
            {
                Sql = $"UPDATE T_Supplier set SupplierName=N'{Tmp.SupplierName}' WHERE SupplierId={Tmp.SupplierId}";
            }

            RecCount = Db.ExecuteNonQuery(Sql);

            if (Tmp.SupplierId == -1)
            {
                Tmp.SupplierId = Db.GetMaxId("T_Supplier", "SupplierId");
            }


            return RecCount;
        }
    }

}