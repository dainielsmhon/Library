<%@ Page Title="" Language="C#" MasterPageFile="~/LibraryAdmin/NewAdminMaster.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="Library.LibraryAdmin.book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="css/dataTables.bootstrap4.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <h1>רשימת משתמשים</h1>
                        <div class="card-body">
                      <!-- table -->
                      <table class="table datatables" id="MainTbl">
                        <thead>
                          <tr>
                            <th>קוד משתמש</th>
                            <th>שם מלא </th>
                            <th>שם</th>
                            <th>תעודת זהות</th>
                            <th>סיסמה</th>
                            <th>פלאפון</th>
                            <th>מייל</th>
                            <th>תאריך התחברות </th>//
                            <th>כתובת</th>
                            <th>פעולה</th>
                          </tr>
                        </thead>
                        <tbody>
                           <asp:Repeater ID="RpUser" runat="server">
                               <ItemTemplate>
                               <tr>
                            <th><%#Eval("UserId")%></th>
                            <th><%#Eval("Name")%></th>
                            <th><%#Eval("UserName")%></th>
                            <th><%#Eval("UserPass")%></th>
                            <th><%#Eval("Email")%></th>
                            <th><%#Eval("Phone")%></th>
                            <th><%#Eval("Adress")%></th>
                            <th><%#Eval("JoinDate")%></th>
                            
                            <td><button class="btn btn-sm dropdown-toggle more-horizontal" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                <span class="text-muted sr-only">פרטים נוספים</span>
                              </button>
                              <div class="dropdown-menu dropdown-menu-right">
                                <a class="dropdown-item" href="UserAdd.aspx?UserId=<%#Eval("UserId")%>">עריכה</a>   
                                <a class="dropdown-item" href="#">כרטיס משתמש</a>
                                <asp:Button ID="BtnRemove" runat="server" Text="הסרה" OnClick="BtnRemove_Click" CommandArgument='<%#Eval("UserId") %>' OnClientClick="ComfirmDelete();return ans;" />

                              </div>
                            </td>
                          </tr>

                               </ItemTemplate>
                           </asp:Repeater>
                          <tr>
                            <td>
                              <div class="custom-control custom-checkbox">
                                <input type="checkbox" class="custom-control-input">
                                <label class="custom-control-label"></label>
                              </div>
                            </td>
                            <td>323</td>
                            <td>Walter Sawyer</td>
                            <td>(671) 969-1704</td>
                            <td>Tech Support</td>
                            <td>Macromedia</td>
                            <td>Ap #708-5152 Cursus. Ave</td>
                            <td>Bath</td>
                            <td>May 8, 2020</td>
                            <td><button class="btn btn-sm dropdown-toggle more-horizontal" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                <span class="text-muted sr-only">Action</span>
                              </button>
                              <div class="dropdown-menu dropdown-menu-right">
                                <a class="dropdown-item" href="#">Edit</a>
                                <a class="dropdown-item" href="#">Remove</a>
                                <a class="dropdown-item" href="#">Assign</a>
                              </div>
                            </td>
                          </tr>
                          <tr>
                            <td>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
    <script src='js/jquery.dataTables.min.js'></script>
   <script src='js/dataTables.bootstrap4.min.js'></script>
    <script>
        var ans = true;
        function ComfirmDelete() {
            ans = confirm("האם אתה בטוח שברצונך למחוק קטגוריה זו?");
            return ans;
        }
    </script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooter" runat="server">
       <script>
           $('#MainTbl').DataTable(
           {
            autoWidth: true,
            "lengthMenu": [
              [16, 32, 64, -1]
              [16, 32, 64, "All"]
                ],
                 
            
                   language: {
                       url: '//cdn.datatables.net/plug-ins/2.0.8/i18n/he.json'
                   }
           }); 
            
       </script>
</asp:Content>
