<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="votes.aspx.cs" Inherits="ICT713_Lab2_LoganFidler.votes" %>

<asp:Content ID="votes" ContentPlaceHolderID="mainPlaceHolder" runat="server">
    <asp:Label ID="lblDayOne" runat="server" Text="Day 1"></asp:Label><asp:TextBox ID="txtDayOne" runat="server" ReadOnly="True"></asp:TextBox>
    <asp:Label ID="lblDayTwo" runat="server" Text="Day 2"></asp:Label><asp:TextBox ID="txtDayTwo" runat="server" ReadOnly="True"></asp:TextBox>
    <asp:Label ID="lblDayThree" runat="server" Text="Day 3"></asp:Label><asp:TextBox ID="txtDayThree" runat="server" ReadOnly="True"></asp:TextBox>
    <asp:Button ID="btnCalReturn" runat="server" Text="Back to Calendar" PostBackUrl="~/calendar.aspx" />
</asp:Content>