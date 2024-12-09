<%@ Page Title="" Language="C#" MasterPageFile="~/LibraryAdmin/NewAdminMaster.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="Library.LibraryAdmin.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
     <div class="card shadow mb-4">
   <div class="card-header">
     <strong class="card-title">הוספת / עריכת ספרים</strong>
   </div>


               
                  




   <div class="card-body">
       <div class="form-row">
         <div class="col-md-6 mb-3">
             <asp:HiddenField ID="HidBookId" runat="server" Value="-1" />
           <label for="TxtBookId">שם ספר</label>
             <asp:TextBox ID="TxtBookId" runat="server" CssClass="from-control" placeholder="נא הזן שם ספר "/>
         </div>
            <div class="col-md-6 mb-3">
              <label for="TxtName">שם מלא </label>
               <asp:TextBox ID="TxtName" runat="server"  CssClass="from-control" placeholder="נא הזן שם מלא " />
         </div>
           </div>
           <div class="col-md-6 mb-3">
            <label for="TxtAuthor">מחבר הספר </label>
             <asp:TextBox ID="TxtAuthor" runat="server"  CssClass="from-control " placeholder="נא הזן שם מחבר" />
           </div>
            
           </div>
            <div class="col-md-6 mb-3">
             <label for="TxtDescription">תאור הספר </label>
              <asp:TextBox ID="TxtDescription" runat="server"  CssClass="from-control" placeholder="נא הזן תיאור  "/>
            </div>

           
           </div>
            <div class="col-md-4 mb-3">
             <label for="TxtLang">אורך הספר </label>
               <asp:TextBox ID="TxtLang" runat="server"  CssClass="from-control" placeholder="נא הזן אורך הספר " />
           </div>
          
               <div class="col-md-4 mb-3">
                 <label for="TxtLocation">מיקום הספר </label>
                   <asp:TextBox ID="TxtLocation" runat="server" CssClass="from-control" placeholder="נא הזן מיקום הספר  " />
           </div>
          
             <div class="col-md-4 mb-3">
               <label for="TxtStatus">מצב הספר קיים/ הושאל </label>
                <asp:TextBox ID="TxtStatus" runat="server"  CssClass="from-control" placeholder=" נא הזן אם במלאי או שהושאל " />
         </div>

        <div class="col-md-4 mb-3">
      <label for="TxtAdded">הוספת ספר </label>
        <asp:TextBox ID="TextAdded" TextMode="Date" runat="server" CssClass="from-control" placeholder="הוספה למאגר  " />
</div>
    
        <div class="col-md-4 mb-3">
      <label for="TxtTakenDate">זמן השאלת הספר </label>
        <asp:TextBox ID="TxtTakenDate" TextMode="Date" runat="server" CssClass="from-control" placeholder=" זמן השאלה    " />
</div>
    
        <div class="col-md-4 mb-3">
      <label for="TxtReturnDate">זמן החזרת הספר </label>
        <asp:TextBox ID="TxtReturnDate" TextMode="Date" runat="server" CssClass="from-control" placeholder=" זמן החזרה   " />
</div>
          
          <asp:Button ID="BtnSave" runat="server" Text="שמירה"  class="btn btn-success" Onclick="BtnSave_Click"/>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooter" runat="server">
</asp:Content>