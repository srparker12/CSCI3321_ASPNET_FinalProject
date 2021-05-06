<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyBooks.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.MyBooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Build a table to list your book collection -->
    <!-- What server control should you use? -->

    <asp:Panel ID="pnlBookList" runat="server" CssClass="row">
        <asp:Table ID="tblBookList" runat="server" CssClass="table table-striped">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>Book Title</asp:TableHeaderCell>
                <asp:TableHeaderCell>Author's First Name</asp:TableHeaderCell>
                <asp:TableHeaderCell>Author's Last Name</asp:TableHeaderCell>
                <asp:TableHeaderCell>Price</asp:TableHeaderCell>
                <asp:TableHeaderCell>Publish Date</asp:TableHeaderCell>
                <asp:TableHeaderCell>Publisher Name</asp:TableHeaderCell>
                <asp:TableHeaderCell>Genre</asp:TableHeaderCell>
            </asp:TableHeaderRow>
        </asp:Table>
    </asp:Panel>
</asp:Content>
