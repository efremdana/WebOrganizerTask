<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebOrganizerTask.Login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div>
        <h2>Авторизация</h2>
        <div class="text-start">
            <div class="mb-3">
                <asp:Label ID="UserNameLabel" runat="server">Имя пользователя:</asp:Label>
                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                Text="*" ErrorMessage="Имя пользователя обязательно."></asp:RequiredFieldValidator>
            </div>
            <div class="mb-3">
                <asp:Label ID="PasswordLabel" runat="server">Пароль:</asp:Label>
                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                Text="*" ErrorMessage="Имя пользователя обязательно."></asp:RequiredFieldValidator>
            </div>
            <asp:Button ID="LoginButton" runat="server" Text="Войти" OnClick="LoginButton_Click" />
        </div>
        <div class="text-start" role="alert">
            <asp:ValidationSummary ID="LoginValidationSummary" runat="server"></asp:ValidationSummary>
        </div>
    </div>
</asp:Content>
