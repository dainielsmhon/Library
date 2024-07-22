using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;


namespace Library
{
    public partial class Cities : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Search = "תל";
                string EndPoint = "https://data.gov.il/api/3/action/datastore_search";

                //יצירת אובייקט של שליחת בקשות
                var client = new RestClient(EndPoint);
                // יצירת אובייקט מסוג בקשה
                var request = new RestRequest();
                    //הוספת פרמטרים לבקשה
                   request.AddParameter("resource_id", "5c78e9fa-c2e2-4771-93ff-7f400a12f7ba");
                request.AddParameter("q", "Search");
                var res = client.Get(request);
                var x=res.Content.ToLower();
                var obj=JsonConvert.DeserializeObject<dynamic>(x);
                var records = obj.result.Records;
                rptCity.DataSource=records;
                rptCity.DataBind();

            }
        }
    }
}