﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EncryptDecrypt.aspx.cs" Inherits="ISM_Store_HomePage.EncryptDecrypt" %>

<!DOCTYPE html>

<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>Login</title>
    <link rel="icon" href="assets/img/favicon/favicon.png" />
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i&amp;display=swap">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Poppins&amp;display=swap">
    <link rel="stylesheet" href="assets/css/Drag-Drop-File-Input-Upload.css">
</head>

<body class="bg-gradient-primary">
    <form class="user" runat="server">
        <div class="container">
            <div class="row justify-content-center" style="margin-top: 40px;">
                <div class="col-md-9 col-lg-12 col-xl-10">
                    <div class="card shadow-lg o-hidden border-0 my-5">
                        <div class="card-body p-0">
                            <div class="row">
                                <div class="col-lg-6 d-none d-lg-flex">
                                    <div>
                                        <img class="img-fluid" src="assets/img/Material/33.jpg" width="441" height="554" style="width: 450px; height: 591.016px;">
                                    </div>
                                </div>
                                <div class="col-lg-6">
                                    <div class="p-5">
                                        <div id="EncryptDecryptTextShow" runat="server"></div>
                                        <div class="text-center">
                                            <h1 class="text-dark mb-1">Welcome!</h1>
                                            <h4 class="mb-5" style="font-weight: bold; color: var(--bs-primary); font-family: Poppins, sans-serif;">Encryption Decryption Text</h4>
                                        </div>

                                        <div class="mb-3">
                                            <asp:textbox runat="server" class="form-control form-control-user" id="txtEncrypt" type="text" placeholder="Enter Plain Text for Encryption" AutoPostBack="true" autocomplete="off" OnTextChanged="txtEncrypt_TextChanged"></asp:textbox>
                                        </div>
                                        <div class="mb-3">
                                            <asp:textbox runat="server" class="form-control form-control-user" id="txtDecrypt" type="text" placeholder="Enter Encrypted Text for Decryption" AutoPostBack="true" autocomplete="off" OnTextChanged="txtDecrypt_TextChanged"></asp:textbox>

                                        </div>
                                                                                                                    
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <script src="assets/js/jquery.min.js"></script>
        <script src="assets/FormJS/Login.js"></script>
        <script src="assets/js/sweetalert2@11.js"></script>
        <script src="assets/bootstrap/js/bootstrap.min.js"></script>
        <script src="assets/js/bs-init.js"></script>
        <script src="assets/js/theme.js"></script>
    </form>
</body>

</html>
