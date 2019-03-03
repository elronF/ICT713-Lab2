<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="calendar.aspx.cs" Inherits="ICT713_Lab2_LoganFidler.Default" %>

<asp:Content ID="calendar" ContentPlaceHolderID="mainPlaceHolder" runat="server">
    <section class="calendar-group">
        <div class="form-group">
            <asp:Calendar ID="calVote" runat="server" OnDayRender="calVote_DayRender" OnSelectionChanged="calVote_SelectionChanged" BackColor="White">
            </asp:Calendar>
        </div>
        <div class="form-group">
            <asp:Button ID="btnVote" runat="server" Text="Vote!" OnClick="btnVote_Click" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblCurrentSelection" runat="server" CssClass="text-danger"></asp:Label>
        </div>
    </section>
</asp:Content>