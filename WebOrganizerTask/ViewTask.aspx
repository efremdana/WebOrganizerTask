<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTask.aspx.cs" Inherits="WebOrganizerTask.ViewTask" MasterPageFile="~/Layout.Master" %>


<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="container">
        <div class="row justify-content-sm-center">
            <div class="col col-2">
                <h2>Задача</h2>
            </div>
            <div class="col col-2">
                <asp:Button ID="ButtonTask" runat="server" Text="" OnClick="ButtonTask_Click" />
            </div>
        </div>
        <div class="row">
            <asp:DetailsView CssClass="table table-striped" ID="DetailsViewTask" runat="server" AutoGenerateRows="false">
                <Fields>
                    <asp:BoundField DataField="Name" HeaderText="Название" />
                    <asp:BoundField DataField="DateStart" HeaderText="Дата начала" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="DateEnd" HeaderText="Дедлайн" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="Progress" HeaderText="Прогресс" />
                    <asp:BoundField DataField="Periodicity" HeaderText="Переодичность" />
                    <asp:BoundField DataField="Importance" HeaderText="Важность" />
                </Fields>
            </asp:DetailsView>
        </div>
        <div class="row">
            <div class="col">
                <h3>Ресурсы</h3>
                <asp:GridView CssClass="table table-striped" AutoGenerateColumns="false" ID="GridViewResources" runat="server">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Название" />
                        <asp:BoundField DataField="Quantity" HeaderText="Количество" />
                    </Columns>
                </asp:GridView>
            </div>
            <div class="col">
                <h3>Люди</h3>
                <asp:GridView CssClass="table table-striped" AutoGenerateColumns="false" ID="GridViewPersons" runat="server">
                    <Columns>
                        <asp:BoundField DataField="FirstName" HeaderText="Имя" />
                        <asp:BoundField DataField="LastName" HeaderText="Фамилия" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>

