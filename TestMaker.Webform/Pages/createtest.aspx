<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeBehind="createtest.aspx.cs" Inherits="TestMaker.Webform.Pages.createtest" %>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="iso-8859-9">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
        <link rel="stylesheet" href="css/style.css">
        <title>Test Maker</title>
    </head>
<body>
    <form id="form1" runat="server">

<!-- navbar -->
<div class="container">  
    <div class="row">
        <div class="col-md-10 mx-auto">
            <nav class="navbar navbar-expand-lg navbar-light bg-light">
                <div class="container-fluid">
                    <img src="https://www.konusarakogren.com/images/assets/img/logo.png" alt="Alternate Text" />
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse"
                        data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent"
                        aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarSupportedContentt">
                        <ul class="navbar-nav ml-auto mb-2 mb-lg-0">
                            <li class="nav-item">
                                <h5><a class="nav-link active m-2" aria-current="page"> Hoş Geldin <asp:Label ID="welcomeL" runat="server" Text="Label"></asp:Label></a></h5> 
                            </li>
                        </ul>
                    </div>
                    <div class="collapse navbar-collapse" id="navbarSupportedContent">
                        <ul class="navbar-nav ml-auto mb-2 mb-lg-0">
                            <li class="nav-item">
                                <asp:Button ID="logoutB" CssClass="btn btn-link" runat="server" Text="Oturum Kapat" OnClick="logoutB_Click" UseSubmitBehavior="False" />
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
    </div>
</div>


<!-- başlıklar -->
<div class="container">
    <div class="row">
        <div class="col-md-9 mx-auto bg-white">
            <div class="row">
                <div class="w-100">
                    <br>
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                          <label class="input-group-text" for="inputGroupSelect01">Wired.com Başlıklar</label>
                        </div>
                        <asp:DropDownList ID="TitleDDL" runat="server" CssClass="custom-select" OnSelectedIndexChanged="TitleDDL_SelectedIndexChanged" AutoPostBack="True">

                        </asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- başlık metni -->
<div class="container">
    <div class="row">
        <div class="col-md-9 mx-auto bg-white">
            <div class="card w-100" style="width: 18rem;">
                <div class="card-body">
                    <asp:Label ID="TextL" CssClass="card-text" runat="server" Text="Lorem ipsum dolor sit amet consectetur adipisicing elit. Vero magnam enim at modi placeat ea? Autem, perspiciatis sint, omnis, architecto recusandae eaque voluptates dolorum voluptatem rem corrupti iste consequuntur sapiente.Lorem ipsum dolor sit amet consectetur adipisicing elit. Vero magnam enim at modi placeat ea? Autem, perspiciatis sint, omnis, architecto recusandae eaque voluptates dolorum voluptatem rem corrupti iste consequuntur sapiente."></asp:Label>
                    
                    </div>
                  </div>
              </div>
              <br>
        </div>
    </div>
</div>
    
<!-- soru 1 -->
<div class="container">
    <div class="row">
        <div class="col-md-9 mx-auto bg-white">

            <div class="card w-100" style="width: 18rem;">
                <div class="card-body">

                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                          <span class="input-group-text">Soru 1</span>
                        </div>
                        <asp:TextBox ID="Q1TB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                    </div>
              
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">A</span>
                        </div>
                        <asp:TextBox ID="Q1AnswerATB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                        <div class="input-group-prepend">
                            <span class="input-group-text">B</span>
                        </div>
                        <asp:TextBox ID="Q1AnswerBTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                    </div>

                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">C</span>
                        </div>
                        <asp:TextBox ID="Q1AnswerCTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                        <div class="input-group-prepend">
                            <span class="input-group-text">D</span>
                        </div>
                        <asp:TextBox ID="Q1AnswerDTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                    </div>

                    <div class="input-group mb-3 w-50 mx-auto">
                        <div class="input-group-prepend">
                          <label class="input-group-text" for="inputGroupSelect01">Doğru Cevap</label>
                        </div>
                        <asp:DropDownList ID="Q1AnswersDDL" runat="server" CssClass="custom-select">
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                </div>
            </div>

        </div>
    </div>
</div>

<!-- soru 2 -->
<div class="container">
    <div class="row">
        <div class="col-md-9 mx-auto bg-white">

            <div class="card w-100" style="width: 18rem;">
                <div class="card-body">

                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                          <span class="input-group-text">Soru 2</span>
                        </div>
                        <asp:TextBox ID="Q2TB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                    </div>
              
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">A</span>
                        </div>
                        <asp:TextBox ID="Q2AnswerATB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                        <div class="input-group-prepend">
                            <span class="input-group-text">B</span>
                        </div>
                        <asp:TextBox ID="Q2AnswerBTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                    </div>

                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">C</span>
                        </div>
                        <asp:TextBox ID="Q2AnswerCTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                        <div class="input-group-prepend">
                            <span class="input-group-text">D</span>
                        </div>
                        <asp:TextBox ID="Q2AnswerDTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                    </div>

                    <div class="input-group mb-3 w-50 mx-auto">
                        <div class="input-group-prepend">
                          <label class="input-group-text" for="inputGroupSelect01">Doğru Cevap</label>
                        </div>
                        <asp:DropDownList ID="Q2AnswersDDL" runat="server" CssClass="custom-select">
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                </div>
            </div>

        </div>
    </div>
</div>

<!-- soru 3 -->
<div class="container">
    <div class="row">
        <div class="col-md-9 mx-auto bg-white">

            <div class="card w-100" style="width: 18rem;">
                <div class="card-body">

                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                          <span class="input-group-text">Soru 3</span>
                        </div>
                        <asp:TextBox ID="Q3TB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                    </div>
              
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">A</span>
                        </div>
                        <asp:TextBox ID="Q3AnswerATB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                        <div class="input-group-prepend">
                            <span class="input-group-text">B</span>
                        </div>
                        <asp:TextBox ID="Q3AnswerBTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                    </div>

                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">C</span>
                        </div>
                        <asp:TextBox ID="Q3AnswerCTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                        <div class="input-group-prepend">
                            <span class="input-group-text">D</span>
                        </div>
                        <asp:TextBox ID="Q3AnswerDTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                    </div>

                    <div class="input-group mb-3 w-50 mx-auto">
                        <div class="input-group-prepend">
                          <label class="input-group-text" for="inputGroupSelect01">Doğru Cevap</label>
                        </div>
                        <asp:DropDownList ID="Q3AnswersDDL" runat="server" CssClass="custom-select">
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                </div>
            </div>

        </div>
    </div>
</div>

<!-- soru 4 -->
<div class="container">
    <div class="row">
        <div class="col-md-9 mx-auto bg-white">

            <div class="card w-100" style="width: 18rem;">
                <div class="card-body">

                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                          <span class="input-group-text">Soru 4</span>
                        </div>
                        <asp:TextBox ID="Q4TB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                    </div>
              
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">A</span>
                        </div>
                        <asp:TextBox ID="Q4AnswerATB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                        <div class="input-group-prepend">
                            <span class="input-group-text">B</span>
                        </div>
                        <asp:TextBox ID="Q4AnswerBTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                    </div>

                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">C</span>
                        </div>
                        <asp:TextBox ID="Q4AnswerCTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                        <div class="input-group-prepend">
                            <span class="input-group-text">D</span>
                        </div>
                        <asp:TextBox ID="Q4AnswerDTB" runat="server" CssClass="form-control" required="required"></asp:TextBox>
                    </div>

                    <div class="input-group mb-3 w-50 mx-auto">
                        <div class="input-group-prepend">
                          <label class="input-group-text" for="inputGroupSelect01">Doğru Cevap</label>
                        </div>
                        <asp:DropDownList ID="Q4AnswersDDL" runat="server" CssClass="custom-select">
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                </div>
            </div>

        </div>
    </div>
</div>

<%--sınav oluştur--%>
<div class="container">
    <div class="row mb-3 ">
        <div class="col-md-9 mx-auto bg-white">
            <br>
                <div class="d-flex justify-content-center">
                    <asp:Button ID="CancelB" runat="server" Text="İptal" CssClass="btn btn-warning w-50" UseSubmitBehavior="False" OnClick="CancelB_Click" />
                    <asp:Button ID="CreateB" runat="server" Text="Sınav Oluştur" CssClass="btn btn-primary w-50" OnClick="CreateB_Click" UseSubmitBehavior="False" />
                </div>
            <br>
            <br>
        </div>
    </div>
</div>



    </form>
</body>
</html>
