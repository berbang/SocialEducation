<%@ Page Language="C#" EnableEventValidation="true" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SocialEducation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ui kits Website Template | Home :: w3layouts</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
    <link href="web/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href="web/css/nav.css" rel="stylesheet" type="text/css" media="all" />
    <link href='http://fonts.googleapis.com/css?family=Carrois+Gothic+SC' rel='stylesheet' type='text/css' />
    <script type="text/javascript" src="web/js/jquery.js"></script>
    <script type="text/javascript" src="web/js/login.js"></script>
    <script type="text/javascript" src="web/js/Chart.js"></script>
    <script type="text/javascript" src="web/js/jquery.easing.js"></script>
    <script type="text/javascript" src="web/js/jquery.ulslide.js"></script>
    <!----Calender -------->
    <link rel="stylesheet" href="web/css/clndr.css" type="text/css" />
    <script src="web/js/underscore-min.js"></script>
    <script src="web/js/moment-2.2.1.js"></script>
    <script src="web/js/clndr.js"></script>
    <script src="web/js/site.js"></script>
    <script>
        function validation() {
            var val = true;

            var name = document.getElementById('txtName');
            var surname = document.getElementById('txtSurname');
            var password1 = document.getElementById('txtPassword3');
            var password2 = document.getElementById('txtPassword2');
            var email = document.getElementById('txtEmail');
            var username = document.getElementById('txtUserName');
            var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;

            if (!filter.test(email.value)) {
                email.style.color = 'Red';
                alert('*Geçerli bir email adresi giriniz');
                email.focus;
                // return false;
                val = false;
            }
            if (name.value == 'Adınızı Giriniz') {
                name.style.color = 'Red';
                val = false;

            }
            if (email.value == 'Email Adresinizi Giriniz') {
                email.style.color = 'Red';
                val = false;
            }
            if (username.value == 'Kullanıcı Adınızı Giriniz') {
                username.style.color = 'Red';
                val = false;

            }
            if (surname.value == 'Soyadınızı Giriniz') {
                surname.style.color = 'Red';
                val = false;
            }
            if (password1.value == 'Şifrenizi Giriniz' || password2.value == 'Şifrenizi Doğrulayınız' || password1.value != password2.value) {
                password1.style.color = 'Red';
                password2.style.color = 'Red';
                val = false;
            }
            if (!val) {
                document.getElementById('valText').style.display ='block';
                return false;
            }
            return val;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrap">
            <div class="column_left">
                <div class="column_right_grid sign-in">
                    <div class="sign_in">
                        <h3>Sign in to your account</h3>

                        <span>
                            <i>
                                <img src="web/images/mail.png" alt="" /></i><input type="text" value="Enter your email" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Enter your email';}"/>
                        </span>
                        <span>
                            <i>
                                <img src="web/images/lock.png" alt="" /></i>

                            <input type="password" placeholder="password" onclick=""/>
                        </span>

                        <asp:Button runat="server" ID="btnLogin" Text="Giriş Yap" OnClick="btnLogin_Click" />

                        <h4><a href="#">Forget Password?</a></h4>
                    </div>
                    <div class="signin_facebook">
                        <p>
                            <a href="#"><i>
                                <img src="web/images/facebook.png" alt="" /></i>Sign in with facebook</a>
                        </p>
                    </div>
                </div>
            </div>
            <div class="column_middle">
                <div class="column_right_grid sign-in">
                    <div class="sign_in">
                        <h3>Üye Ol</h3>

                        <span>
                            <i>
                                <img src="web/images/mail.png" alt="" /></i><input type="text" value="Email Adresinizi Giriniz" runat="server" id="txtEmail" onfocus="if (this.value == 'Email Adresinizi Giriniz'){  this.value = ''};" onblur="if (this.value == '') {this.value = 'Email Adresinizi Giriniz';}" />
                        </span>
                        <span>
                            <i>
                                <img src="web/images/lock.png" alt="" /></i>

                            <input type="text" id="txtPassword3" runat="server" value="Şifrenizi Giriniz" onfocus="if (this.value == 'Şifrenizi Giriniz'){  this.value = ''; this.type='password'; };" onblur="if (this.value == '') {this.value = 'Şifrenizi Giriniz'; this.type='text'}" />
                        </span>
                        <span>
                            <i>
                                <img src="web/images/lock.png" alt="" /></i>
                            <input type="text" id="txtPassword2" runat="server" value="Şifrenizi Doğrulayınız" onfocus="if (this.value == 'Şifrenizi Doğrulayınız'){  this.value = ''; this.type='password'; };" onblur="if (this.value == '') {this.value = 'Şifrenizi Doğrulayınız'; this.type='text'}" />
                        </span>
                        <span>
                            <i>
                                <img src="web/images/user.png" alt="" /></i>
                            <input type="text" id="txtUserName" runat="server" value="Kullanıcı Adınızı Giriniz" onfocus="if (this.value == 'Kullanıcı Adınızı Giriniz'){  this.value = ''; };" onblur="if (this.value == '') {this.value = 'Kullanıcı Adınızı Giriniz';}" />
                        </span>
                        <span>
                            <i>
                                <img src="web/images/user.png" alt="" /></i>
                            <input type="text" id="txtName" runat="server" value="Adınızı Giriniz" onfocus="if (this.value == 'Adınızı Giriniz'){  this.value = ''; };" onblur="if (this.value == '') {this.value = 'Adınızı Giriniz';}" />
                        </span>
                        <span>
                            <i>
                                <img src="web/images/user.png" alt="" /></i>
                            <input type="text" id="txtSurname" runat="server" value="Soyadınızı Giriniz" onfocus="if (this.value == 'Soyadınızı Giriniz'){  this.value = ''; };" onblur="if (this.value == '') {this.value = 'Soyadınızı Giriniz';}" />
                        </span>
                        <asp:Button ID="btnLogon" Text="KAYDOL" OnClientClick="return validation()" OnClick="btnLogon_Click" runat="server" />
                        <div style="display:none" id="valText"><span>
                            <label style="color:red"> *Tüm Alanların Doldurulması Zorunludur<br /></label>
                        </span>

                        </div>
                        

                    </div>
                    <div class="signin_facebook">
                        <p>
                            <a href="#"><i>
                                <img src="web/images/facebook.png" alt="" /></i>Sign in with facebook</a>
                        </p>
                    </div>
                </div>
            </div>
            <div class="column_right">
                <div class="column_right_grid sign-in">
                    <div class="sign_in">
                        <h3>Sign in to your account</h3>

                        <span>
                            <i>
                                <img src="web/images/mail.png" alt="" /></i><input type="text" value="Enter your email" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Enter your email';}" />
                        </span>
                        <span>
                            <i>
                                <img src="web/images/lock.png" alt="" /></i>
                            <input type="password" placeholder="password" />
                        </span>
                        <input type="submit" class="my-button" value="Sign In" />

                        <h4><a href="#">Forget Password?</a></h4>
                    </div>
                    <div class="signin_facebook">
                        <p>
                            <a href="#"><i>
                                <img src="web/images/facebook.png" alt="" /></i>Sign in with facebook</a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
