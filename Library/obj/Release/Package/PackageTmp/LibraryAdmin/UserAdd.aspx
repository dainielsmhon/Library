<%@ Page Title="" Language="C#" MasterPageFile="~/LibraryAdmin/NewAdminMaster.Master" AutoEventWireup="true" CodeBehind="UserAdd.aspx.cs" Inherits="Library.LibraryAdmin.UserAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
     <div class="card shadow mb-4">
   <div class="card-header">
     <strong class="card-title">הוספת / עריכת משתמשים</strong>
   </div>
   <div class="card-body">
       <div class="form-row">
         <div class="col-md-6 mb-3">
             <asp:HiddenField ID="HidUserId" runat="server" Value="-1" />
           <label for="TxtUserId">שם משתמש</label>
             <asp:TextBox ID="TxtUserId" runat="server" CssClass="from-control" placeholder="שם משתמש נא הזן "/>
         </div>
            <div class="col-md-6 mb-3">
              <label for="TxtName">שם מלא </label>
               <asp:TextBox ID="TxtName" runat="server"  CssClass="from-control" placeholder="נא הזן שם מלא " />
         </div>
           </div>
           <div class="col-md-6 mb-3">
            <label for="TxtEmail">מייל </label>
             <asp:TextBox ID="TxtEmail" runat="server" TextMode="Email" CssClass="from-control " placeholder="נא הזן כתובת מייל" />
           </div>
            
           </div>
            <div class="col-md-6 mb-3">
             <label for="TxtUserPass">סיסמה </label>
              <asp:TextBox ID="TxtUserPass" runat="server" TextMode="Password" CssClass="from-control" placeholder="נא הזן סיסמה "/>
            </div>

           
           </div>
            <div class="col-md-4 mb-3">
             <label for="TxtPhone">פלאפון </label>
               <asp:TextBox ID="TxtPhone" runat="server" TextMode="Phone" CssClass="from-control" placeholder="נא הזן מספר נייד " />
           </div>
          
               <div class="col-md-4 mb-3">
                 <label for="TxtAdress">כתובת</label>
                   <asp:DropDownList ID="TxtAdress" runat="server" CssClass="from-control" placeholder="נא הזן כתובת  " />
           </div>
          
             <div class="col-md-4 mb-3">
               <label for="TxtJoinDate">תאריך תחילת התחברות </label>
                <asp:TextBox ID="TxtJoinDate" runat="server" TextMode="Date" CssClass="from-control" placeholder=" נא הזן תחילת הצטרפות " />
         </div>
          <asp:Button ID="BtnSave" runat="server" Text="שמירה"  class="btn btn-success" OnClick="BtnSave_Click"/>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooter" runat="server">
</asp:Content>
