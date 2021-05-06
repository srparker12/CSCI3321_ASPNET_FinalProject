<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookAdded.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.BookAdded" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    Your Book has been added to the database.<br />
    <br />
    <asp:Button ID="btnAddBook" runat="server" OnClick="Button1_Click" Text="Add Another Book" Width="152px" />
    <br />
    <asp:Button ID="btnBookTable" runat="server" OnClick="btnBookTable_Click" Text="View Book Table" />
    <br />
&nbsp;

</asp:Content>
