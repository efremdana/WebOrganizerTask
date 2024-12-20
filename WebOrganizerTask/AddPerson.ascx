<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddPerson.ascx.cs" Inherits="WebOrganizerTask.AddPerson1" %>

<div>
    <div class="sm-1">
        <asp:Label CssClass="form-label" ID="FirstNameLabel" runat="server" Text="Имя:"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="FirstNameText" runat="server" type="text" name="PersonFirstName"></asp:TextBox>
    </div>
    <div class="sm-1">
        <asp:Label CssClass="form-label" ID="LastNameLabel" runat="server" Text="Фамилия:"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="LastNameText" runat="server" type="text" name="PersonLastName"></asp:TextBox>
    </div>
    <div class="sm-1">
        <asp:Label CssClass="form-label" ID="PhoneLabel" runat="server" Text="Телефон:"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="PhoneText" runat="server" type="tel" name="Phone"></asp:TextBox>
    </div>
    <div class="sm-1">
        <asp:Label CssClass="form-label" ID="EmailLabel" runat="server" Text="E-mail:"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="EmailText" runat="server" type="email" name="Email"></asp:TextBox>
    </div>
    <div class="sm-1">
        <asp:Button ID="ButtonAddPerson" runat="server" Text="Добавить человека" OnClick="ButtonAddPerson_Click" />
    </div>
    
</div>
