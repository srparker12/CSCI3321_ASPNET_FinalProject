<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddAuthors.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.AddAuthors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Add New Author</h3>
    <div class="row">
        <div class="col-md-3">
            Author Last Name:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtAuthorLastName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        
        <div class="col-md-3">
            Author First Name:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtAuthorFirstName" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="col-md-3">
            Gender:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        </div>

        <div class="col-md-3">
            Author Birthdate:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtBirthdate" runat="server" TextMode="Date"></asp:TextBox>
        </div>

        <div class="col-md-3">
            &nbsp;
        </div>
        <div class="col-md-9">
            <asp:Button ID="btnSubmit" runat="server" Text="Add Author" CssClass="button btn-primary" OnClick="btnSubmit_Click"/>
            <br />
        </div>
    </div>
</asp:Content>
