<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="calendar.aspx.cs" Inherits="ICT713_Lab2_LoganFidler.Default" %>

<asp:Content ID="calendar" ContentPlaceHolderID="mainPlaceHolder" runat="server">
    <asp:Calendar ID="calVote" runat="server" OnDayRender="calVote_DayRender" OnSelectionChanged="calVote_SelectionChanged"></asp:Calendar>
    <asp:Label ID="lblCurrentSelection" runat="server"></asp:Label>
    <asp:Button ID="btnVote" runat="server" Text="Vote!" OnClick="btnVote_Click" />
</asp:Content>