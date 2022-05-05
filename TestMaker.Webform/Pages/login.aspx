<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TestMaker.Webform.Pages.login" %>

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
        <div class="row"><asp:Label ID="dangerL" CssClass="alert alert-danger btn-block" runat="server" Text="" Visible="false"></asp:Label></div> 
            <div id="logreg-forms">
                    <form class="form-signin" runat="server">
                        <div class="container mx-auto">
                            <div class="row ">
                                    <img class="mx-auto h-100 w-100" src="https://ingilizcekurslari.konusarakogren.com/wp-content/themes/konusarakogren/assets/img/ko-logo-yatay.png" alt="Alternate Text" />
                             
                            </div>

                        </div>
                        <hr>
                        <br>
                        <h4 class="mb-3 font-weight-bold" style="text-align: center"> Kullanıcı Girişi</h4>
                        <asp:TextBox ID="userNameTB" runat="server"  CssClass="form-control" required="required" placeholder="Kullanıcı Adı" TextMode="SingleLine"> </asp:TextBox>
                        <asp:TextBox ID="passwordTB" runat="server" CssClass="form-control" required="required" placeholder="Şifre" TextMode="Password"  ></asp:TextBox>
                        <hr>
                        <asp:Button ID="loginBtn" runat="server" Text="Giriş" CssClass="btn btn-success btn-block" OnClick="loginBtn_Click" />
                        <hr>
                        <a href="#" id="forgot_pswd">Şifremi Unuttum</a>
                        <button class="btn btn-primary btn-block" type="button" id="btn-signup"><i class="fas fa-user-plus"></i> Yeni hesap oluştur</button>
                    </form>

                    <form action="/reset/password/" class="form-reset" >
                        <input type="email" id="resetEmail" class="form-control" placeholder="Email adresi" required="" autofocus="">
                        <button class="btn btn-primary btn-block" type="submit">Şifre Yenile</button>
                        <a href="#" id="cancel_reset"><i class="fas fa-angle-left"></i> Geri</a>
                    </form>
                    

                    <form action="/signup/" class="form-signup" >
                        <h1 class="h3 mb-3 font-weight-normal" style="text-align:center"Kayıt Ol</h1>
                        <input type="text" id="user-name" class="form-control" placeholder="Tam Ad" required="" autofocus="">
                        <input type="email" id="user-email" class="form-control" placeholder="Email adresi" required autofocus="">
                        <input type="password" id="user-pass" class="form-control" placeholder="Şifre" required autofocus="">
                        <input type="password" id="user-repeatpass" class="form-control" placeholder="Şifre Tekrarı" required autofocus="">
                        <button class="btn btn-primary btn-block" type="submit"><i class="fas fa-user-plus"></i> Kayıt Ol</button>
                        <a href="#" id="cancel_signup"><i class="fas fa-angle-left"></i> Geri</a>
                    </form>
                    <br>
                    
            </div>
            <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
            <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
            <script src="js/script.js"></script>
    </body>
</html>