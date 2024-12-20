<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListTask.aspx.cs" Inherits="WebOrganizerTask.ListTask" MasterPageFile="~/Layout.Master" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div>
        <h1>Отслеживание задач и прогресса</h1>
        <p>Здесь вы можете отслеживать выполнение ваших задач.</p>
        <div>
            <asp:GridView CssClass="table table-hover" CellPadding="8" ID="GridViewTasks" AutoGenerateColumns="false" runat="server"
                OnRowDataBound="GridViewTasks_RowDataBound">
                <Columns>
                    <asp:TemplateField HeaderText="">
                        <ItemTemplate>
                            <asp:HyperLink ID="DetailsLink" runat="server" Text="Подбробнее" NavigateUrl='<%# "ViewTask.aspx?IDTask=" + Eval("ID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Name" HeaderText="Название" />
                    <asp:BoundField DataField="DateStart" HeaderText="Дата начала" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="DateEnd" HeaderText="Дедлайн" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="Progress" HeaderText="Прогресс" />
                    <asp:BoundField DataField="Periodicity" HeaderText="Переодичность" />
                    <asp:BoundField DataField="Importance" HeaderText="Важность" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
