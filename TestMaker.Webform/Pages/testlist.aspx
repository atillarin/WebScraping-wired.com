<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeBehind="testlist.aspx.cs" Inherits="TestMaker.Webform.Pages.testlist" %>

<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
        <link rel="stylesheet" href="css/style.css">
        <title>Test Maker</title>
    </head>
<body>
    <form id="form1" runat="server">

     <%--navbar--%>
    <div class="container">
        <div class="row">
            <div class="col-md-10 mx-auto">
                <nav class="navbar navbar-expand-lg navbar-light bg-light" >
                    <div class="container-fluid">
                        <img src="https://www.konusarakogren.com/images/assets/img/logo.png" alt="Alternate Text" />
                        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                            <span class="navbar-toggler-icon"></span>
                        </button>
                        <div class="collapse navbar-collapse" id="navbarSupportedContentt">
                            <ul class="navbar-nav ml-auto mb-2 mb-lg-0">
                                <li class="nav-item">
                                    <h5><a class="nav-link active m-2" aria-current="page"> Hoş Geldin <asp:Label ID="welcomeL" runat="server" Text="Admin"></asp:Label> </a></h5>
                                </li>
                            </ul>
                        </div>
                       
                        
                        <div class="collapse navbar-collapse" id="navbarSupportedContent">
                            <ul class="navbar-nav ml-auto mb-2 mb-lg-0">
                                <li class="nav-item">
                                    <asp:Button ID="logoutB" CssClass="btn btn-link " runat="server" Text="Oturumu Kapat" OnClick="logoutB_Click" UseSubmitBehavior="False" />
                                    
                                </li>
                            </ul>
                        </div>
                    </div>
                </nav>
            </div>
        </div>
    </div>

        <%--Sınav oluştur düğmesi ve tablo--%>
        <div class="container">
            <div class="row">
                <div class="col-md-9 mx-auto bg-white">
                    <div class="row">
                        <div class="w-100">
                                <asp:Button CssClass="btn btn-primary" ID="createtestB" runat="server" Text="+ Sınav Oluştur" OnClick="createtestB_Click" />


                                <asp:GridView ID="testlistgrid" CssClass="table table-striped table-hover table-bordered " runat="server" AutoGenerateColumns="False" OnRowDeleting="testlistgrid_RowDeleting" OnSelectedIndexChanged="testlistgrid_SelectedIndexChanged" >
                                    <Columns>
                                        <asp:TemplateField HeaderText="#">
                                            <ItemTemplate>
                                                <%# Container.DataItemIndex + 1 %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="TestId" HeaderText="TestId" Visible ="false" />
                                        <asp:BoundField DataField="Title" HeaderText="Başlık" />
                                        <asp:BoundField DataField="Date" HeaderText="Tarih" />
                                        <asp:CommandField ShowDeleteButton="True" />
                                    </Columns>
                                </asp:GridView>

                        </div>
                    </div>
                </div>
            </div>
        </div>

    </form>

</body>
</html>
