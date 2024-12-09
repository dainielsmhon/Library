using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library.LibraryAdmin
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                FillData();




            }

        }
        public void FillData()
        {
            Book Tmp = null;
            string BookId = HidBookId.Value;


            BookId = Request["BookId"] + "";


            if (string.IsNullOrEmpty(BookId))
            {
                BookId = "-1"; //הוספת משתמש חדש
            }
            else
            {
                Tmp = BLL.Book.GetById(int.Parse(BookId));
                if (Tmp == null)
                {
                    BookId = "-1";//הוספת משתמש חדש
                }
            }
            HidBookId.Value = BookId;// שמירת שם משתמש  לעריכה או הוספה בשדה הנסתר
            //נמלא את כל הטופס בנתונים הראשים שלו

            if (Tmp != null)//אנחנו במצב עריכה של משתמש לכן יש  למלא את הפרטים
            {
                Tmp.BookId = Tmp.BookId;
                TxtName.Text = Tmp.BookName;
                TxtAuthor.Text = Tmp.BookAuthor;
                TxtDescription.Text = Tmp.BookDescription;
                TxtLang.Text = Tmp.BookLang;
                TxtLocation.Text = Tmp.Location;
                TxtStatus.Text = Tmp.Status;
                TextAdded.Text = Tmp.Added.ToString("yyyy-MM-dd");
                TxtTakenDate.Text = Tmp.TakenDate.ToString("yyyy-MM-dd");
                TxtReturnDate.Text = Tmp.ReturnDate.ToString("yyyy-MM-dd");

            }
        }
    

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Book Tmp = new Book()
            {




                BookId = int.Parse(HidBookId.Value),
                BookName = TxtName.Text,
                BookAuthor = TxtAuthor.Text,
                BookDescription = TxtDescription.Text,
                BookLang = TxtLang.Text,
                Location = TxtLocation.Text,
                Status = TxtStatus.Text,
                Added = DateTime.Parse(TextAdded.Text),
                TakenDate = DateTime.Parse(TextAdded.Text),
                ReturnDate = DateTime.Parse(TextAdded.Text)



            };

            Tmp.Save();
            Response.Redirect("ListBook.aspx");
        }
    }
}