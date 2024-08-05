<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Library.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl" lang="he">
<head runat="server">
   
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
   
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.rtl.min.css" integrity="sha384-nU14brUcp6StFntEOOEBvcJm4huWjB0OcIeQ3fltAfSmuZFrkAif0T+UtNGlKKQv" crossorigin="anonymous"/>
     <title>הרשמה לאתר</title>
    <link rel="stylesheet" href="/css/style.css" />
        
</head>
<body>
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">סרגל </a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Dropdown
          </a>
          <ul class="dropdown-menu">
            <li><a class="dropdown-item" href="#">Action</a></li>
            <li><a class="dropdown-item" href="#">Another action</a></li>
            <li><hr class="dropdown-divider"/></li>
            <li><a class="dropdown-item" href="#">Something else here</a></li>
          </ul>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled" aria-disabled="true">Disabled</a>
        </li>
      </ul>
      <form class="d-flex" role="search">
        <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search"/>
        <button class="btn btn-outline-success" type="submit">Search</button>
      </form>
    </div>
  </div>
</nav>
    <form id="form1" runat="server">
           <div class="container text-center">
  <div class="row p-2">
    <div class="col-md-2 col-sm-3">
      שם מלא 
    </div>
    <div class="col-md-4 col-sm-6">
     <asp:TextBox ID="TxtFullName" runat="server" Class="form-control" placeholder="נא הזן שם מלא" />
        <asp:RequiredFieldValidator ID="RqFullName" runat="server" ErrorMessage="נא הזן שם מלא " ControlToValidate="TxtFullName" />

    </div>  

      </div>
  </div>
                 <div class="row p-2">
    <div class="col-md-2 col-sm-3">
     כתובת  
    </div>
    <div class="col-md-4 col-sm-6">
     <asp:TextBox ID="TexAddress"  runat="server" Class="form-control" placeholder="נא הזן כתובת" />
    </div>  


  </div>
  <div class="row p-2">
    <div class="col-md-2 col-sm-3">
         </div>
      </div> 
  <div class="row p-2">

    <div class="col-md-2 col-sm-3">
      עיר
    </div>
    <div class="col-md-4 col-sm-6">
     <asp:DropDownList ID="DDLCity"  runat="server" Class="form-control" >
         <asp:ListItem Text ="בחר מהרשימה" Value="-1" />
         <asp:ListItem Text ="אשדוד" Value="11" />
         <asp:ListItem Text ="ירושלים" Value="12" />
         <asp:ListItem Text ="חיפה" Value="13" />
         <asp:ListItem Text ="אילת" Value="14" />
         </asp:DropDownList>

       
    </div>  

       </div>
  <div class="row p-2">
    <div class="col-md-2 col-sm-3">
      מגזר
    </div>
    <div class="col-md-4 col-sm-6">
     <asp:DropDownList ID="DDLDat"  runat="server" Class="form-control"  >
         <asp:ListItem Text ="בחר מהרשימה" Value="-1" />
         <asp:ListItem Text ="חרדי" Value="1" />
         <asp:ListItem Text ="חילוני" Value="2" />
         <asp:ListItem Text ="נוצרי" Value="3" />
         <asp:ListItem Text ="מוסלמי" Value="4" />
         </asp:DropDownList>

       
    </div>  


  </div>
  <div class="row p-2">
    <div class="col-md-2 col-sm-3">
     טלפון
    </div>
    <div class="col-md-4 col-sm-6">
     <asp:TextBox ID="TextPhone" TextMode="Phone" runat="server" Class="form-control" placeholder="נא הזן טלפון" />
        <asp:RegularExpressionValidator ID="RePhone" runat="server" ErrorMessage="נייד לא תקין" ControlToValidate="TextPhone" ValidationExpression="05[0-8][-]?[1-9]{6}"/>
    </div>  


  </div>
  <div class="row p-2">
    <div class="col-md-2 col-sm-3">
     מייל
    </div>
    <div class="col-md-4 col-sm-6">
     <asp:TextBox ID="TextMail" TextMode="Email" runat="server" Class="form-control" placeholder="נא הזן כתובת מייל" />
    </div>  


  </div>
  <div class="row p-2">
    <div class="col-md-2 col-sm-3">
      סיסמה 
    </div>
    <div class="col-md-4 col-sm-6">
     <asp:TextBox ID="TxtPass" TextMode="Password" runat="server" Class="form-control" placeholder="נא הזן סיסמה" />
    </div>  


  </div>
  <div class="row p-2">
    <div class="col-md-2 col-sm-3">
      אימות סיסמה 
    </div>
    <div class="col-md-4 col-sm-6">
     <asp:TextBox ID="TextPass2" TextMode="Password" runat="server" Class="form-control" placeholder="נא הזן אימות סיסמה" OnClick="BtnRagister_Click" />
        <asp:CompareValidator ID="CustomValidator1" runat="server" ErrorMessage="סיסמה ואימות סיסמה לא תואמים"  ControlToValidate="TextPass2" ControlToCompare="TxtPass" />
    </div>  




  </div>
  <div class="row p-2">
    <div class="col-md-2 col-sm-3">
     תז
    </div>
    <div class="col-md-4 col-sm-6">
     <asp:TextBox ID="TextId" runat="server" Class="form-control" placeholder="נא הזן מספר תז" />
    </div>  


      </div>
  <div class="row p-2">
    <div class="col-md-2 col-sm-3">
     מגדר
    </div>
    <div class="col-md-4 col-sm-6">
     <asp:RadioButton  ID="RdMale"  runat="server"  GroupName="Gender" Text="זכר"/>
     <asp:RadioButton  ID="RdFemale"  runat="server"  GroupName="Gender" Text="נקבה"/>
    </div>  


      
  </div>
  <div class="row p-2">
    <div class="col-md-2 col-sm-3">
     הערות
    </div>
    <div class="col-md-4 col-sm-6">
     <asp:TextBox ID="TextRemarks" TextMode="MultiLine" runat="server" Class="form-control" placeholder="הערות" Rows="5" Columns="40" />
    </div>  

      
      <div class="row p-2">
    <div class="col-md-2 col-sm-3">
        אישור
        </div>
    <div class="col-md-4 col-sm-6">
        <asp:CheckBox ID="ChkTerm" runat="server" Text=" אני מאשר את תנאי השימוש " Class="form-control"  />
        </div>
          </div>
  </div>
  <div class="row p-2">
    <div class="col-md-2 col-sm-3">
      הרשמה
    </div>
    <div class="col-md-4 col-sm-6">
     <asp:Button  ID="BtnRagister" runat="server"  Text="הרשמה" CssClass="btn btn-success" OnClick="BtnRagister_Click" />
    </div>  
  </div>

 
  <div class="row p-2">
    <div class="col-md-2 col-sm-3">
        <asp:Literal ID="LtlMsg" runat="server" />
        </div>
</div>
      
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
  
</body>
</html>
