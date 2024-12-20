<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddTask.ascx.cs" Inherits="WebOrganizerTask.AddTask1" %>

<div>
    <div class="sm-1">
        <asp:Label CssClass="form-label" ID="TaskNameLabel" runat="server" Text="Название:"></asp:Label>
        <asp:TextBox CssClass="form-control" ID="TaskNameText" type="text" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="TaskNameRequired" runat="server" ControlToValidate="TaskNameText"
            Text="*" ErrorMessage="Название задачи обязательно." ValidationGroup="AddTaskForm"></asp:RequiredFieldValidator>
    </div>
    <div class="sm-1">
        <asp:Label CssClass="form-label" ID="StartDateLable" runat="server" Text="Дата начала:"></asp:Label>
        <asp:TextBox CssClass="form-control text-center" ID="StartDateText" type="date" runat="server"></asp:TextBox>
    </div>
    <div class="sm-1">
        <asp:Label CssClass="form-label" ID="EndDateLabel" runat="server" Text="Дедлайн:"></asp:Label>
        <asp:TextBox CssClass="form-control text-center" ID="EndDateText" type="date" runat="server"></asp:TextBox>
    </div>
    <div class="sm-1">
        <asp:Label CssClass="form-label" ID="FrequencyLabel" runat="server" Text="Периодичность:"></asp:Label>
        <asp:DropDownList CssClass="form-control" ID="FrequencyDownList" runat="server">
            <asp:ListItem Value="Ежедневно" class="text-center"> Ежедневно </asp:ListItem>
            <asp:ListItem Value="Еженедельно" class="text-center"> Еженедельно </asp:ListItem>
            <asp:ListItem Value="Ежемесячно" class="text-center"> Ежемесячно </asp:ListItem>
            <asp:ListItem Value="Ничего" class="text-center"> Ничего </asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="sm-1">
        <asp:Label CssClass="form-label" ID="ImportanceLabel" runat="server" Text="Важность:"></asp:Label>
        <asp:DropDownList CssClass="form-control" ID="ImportanceDownList" runat="server">
            <asp:ListItem Value="Важно" class="text-center"> Важно </asp:ListItem>
            <asp:ListItem Value="Не важно" class="text-center"> Не важно </asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="sm-1">
        <div class="text-start" role="alert">
            <asp:ValidationSummary ID="AddTaskFormValidationSummary" runat="server" ValidationGroup="AddTaskForm"></asp:ValidationSummary>
        </div>
        <asp:Button ID="ButtonAddTask" runat="server" Text="Добавить задачу" OnClick="ButtonAddTask_Click" />
    </div>
</div>
