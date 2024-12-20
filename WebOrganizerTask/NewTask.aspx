<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewTask.aspx.cs" Inherits="WebOrganizerTask.NewTask" MasterPageFile="~/Layout.Master" %>

<%@ Register Src="AddTask.ascx" TagName="AddTask" TagPrefix="uc1" %>
<%@ Register Src="AddResourse.ascx" TagPrefix="uc1" TagName="AddResourse" %>
<%@ Register Src="AddPerson.ascx" TagPrefix="uc1" TagName="AddPerson" %>



<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="container">
        <div class="row">
            <div class="col">
                <h1>Добавление задачи</h1>
                <div class="row">
                    <asp:Label ID="NewTaskLabel" runat="server" Text="Задача:" CssClass="fs-4"></asp:Label>
                </div>
                <div class="row">
                    <asp:Label ID="NewResoursesLabel" runat="server" Text="Ресурсы:" CssClass="fs-4"></asp:Label>
                </div>
                <div class="row">
                    <asp:Label ID="NewPersonsLabel" runat="server" Text="Учавствуют:" CssClass="fs-4"></asp:Label>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <p>
                    <a class="btn btn-primary" data-bs-toggle="collapse" href="#AddTaskTarget" role="button" aria-expanded="false" aria-controls="collapseExample">Добавить задачу
                    </a>
                </p>
                <div class="collapse" id="AddTaskTarget">
                    <div class="card card-body">
                        <uc1:AddTask ID="AddTask" runat="server" />
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <p>
                    <a class="btn btn-primary" data-bs-toggle="collapse" href="#AddResourseTarget" role="button" aria-expanded="false" aria-controls="collapseExample">Добавить ресурс
                    </a>
                </p>
                <div class="collapse" id="AddResourseTarget">
                    <div class="card card-body">
                        <uc1:AddResourse ID="AddResourse" runat="server" />
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <p>
                    <a class="btn btn-primary" data-bs-toggle="collapse" href="#AddPersonTarget" role="button" aria-expanded="false" aria-controls="collapseExample">Добавить человека
                    </a>
                </p>
                <div class="collapse" id="AddPersonTarget">
                    <div class="card card-body">
                        <uc1:AddPerson ID="AddPerson" runat="server" />
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <asp:Button CssClass="btn btn-success" ID="ButtonFinish" runat="server" Text="Завершить" OnClick="ButtonFinish_Click" />
            </div>
        </div>
        <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered">
                <div class="modal-content">
                    <div class="modal-header">
                        <h1 class="modal-title fs-5" id="exampleModalLabel">Заголовок модального окна</h1>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Закрыть"></button>
                    </div>
                    <div class="modal-body">
                        ...
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Закрыть</button>
                        <button type="button" class="btn btn-primary">Сохранить изменения</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        function ShowModalWindow() {
            var myModal = new bootstrap.Modal(document.getElementById('exampleModal'));
            myModal.show();
        }
    </script>
</asp:Content>
