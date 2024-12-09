<%@ Page Title="" Language="C#" MasterPageFile="~/LibraryAdmin/NewAdminMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Library.LibraryAdmin.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainCnt" runat="server">
    <div class="container mt-5">
        <!-- הודעת קבלת פנים -->
        <div class="row mb-4">
            <div class="col">
                <asp:Label ID="lblWelcome" runat="server" CssClass="h2"></asp:Label>
            </div>
        </div>

        <!-- חיפוש ספרים -->
        <div class="row mb-4">
            <div class="col">
                <h3>חיפוש ספרים</h3>
                <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" Placeholder="חפש ספר..."></asp:TextBox>
                <asp:Button ID="btnSearch1" runat="server" Text="חיפוש" CssClass="btn btn-primary mt-2" Onclick="btnSearch1_Click" />
                <asp:Label ID="lblSearchResult" runat="server" CssClass="text-success mt-2"></asp:Label>
            </div>
        </div>

        <!-- ספרים פופולריים -->
        <div class="row mb-4">
            <div class="col">
                <h3>ספרים פופולריים</h3>
                <div class="card-deck">
                    <asp:Repeater ID="rptPopularBooks" runat="server">
                        <ItemTemplate>
                            <div class="card">
                                <img src='<%# Eval("ImageUrl") %>' class="card-img-top" alt="ספר">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Title") %></h5>
                                    <p class="card-text"><%# Eval("Description") %></p>
                                    <a href='<%# Eval("DetailsUrl") %>' class="btn btn-primary">קרא עוד</a>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
        <!-- קטגוריות ספרים -->
        <div class="row mb-4">
            <div class="col">
                <h3>קטגוריות ספרים</h3>
                <div class="list-group">
                    <asp:Repeater ID="rptCategories" runat="server">
                        <ItemTemplate>
                            <a href='<%# Eval("CategoryUrl") %>' class="list-group-item list-group-item-action"><%# Eval("CategoryName") %></a>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>

        <!-- חדשות והמלצות קריאה -->
        <div class="row mb-4">
            <div class="col">
                <h3>חדשות והמלצות קריאה</h3>
                <ul class="list-group">
                    <asp:Repeater ID="rptNews" runat="server">
                        <ItemTemplate>
                            <li class="list-group-item"><%# Eval("NewsTitle") %>: <%# Eval("NewsDescription") %></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
        </div>

        <!-- סקירת ספרים והמלצות משתמשים -->
        <div class="row mb-4">
            <div class="col">
                <h3>סקירת ספרים</h3>
                <asp:Repeater ID="rptReviews" runat="server">
                    <ItemTemplate>
                        <div class="media mb-4">
                            <img src='<%# Eval("UserImageUrl") %>' class="mr-3" alt="User" width="64" height="64">
                            <div class="media-body">
                                <h5 class="mt-0"><%# Eval("UserName") %></h5>
                                <p><%# Eval("ReviewText") %></p>
                                <small class="text-muted">דירוג: <%# Eval("Rating") %>/5</small>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
    <footer class="bg-dark text-white mt-5 p-4 text-center">
        כל הזכויות שמורות לספרייה הדיגיטלית © 2024
    </footer>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="UnderFooter" runat="server">
</asp:Content>
