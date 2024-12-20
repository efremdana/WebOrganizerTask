<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddResourse.ascx.cs" Inherits="WebOrganizerTask.AddResourse1" %>

<div>
    <div class="sm-1">
        <asp:Label CssClass="form-label" ID="ResourceNameLabel" runat="server" Text="Название ресурса:"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="ResourceNameText" runat="server" type="text" name="ResourseName"></asp:TextBox>
    </div>
    <div class="sm-1">
        <asp:Label CssClass="form-label" ID="QuantityLabel" runat="server" Text="Количество:"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="QuantityText" runat="server" type="number" name="Quantity"></asp:TextBox>
    </div>
    <div class="sm-1">
        <asp:Button ID="ButtonAddResourse" runat="server" Text="Добавить ресурс" OnClick="ButtonAddResourse_Click" />
    </div>
</div>
