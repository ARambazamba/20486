<%@ Page Title="" Language="C#" MasterPageFile="~/VouchersWeb.Master" AutoEventWireup="true" CodeBehind="voucherList.aspx.cs" Inherits="SimpleWebForms.voucherList" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" runat="server">
    <asp:GridView ID="gvVouchers" runat="server" DataSourceID="odsVouchers" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="RowSelected" DataKeyNames="ID">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Date" HeaderText="Date" DataFormatString="{0:d}" />
            <asp:BoundField DataField="Text" HeaderText="Text" />
            <asp:BoundField DataField="Amount" HeaderText="Amount" />
            <asp:BoundField DataField="Paid" HeaderText="Paid" />
            <asp:CommandField SelectText="Details" ShowSelectButton="True" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:ObjectDataSource ID="odsVouchers" TypeName="SimpleWebForms.Models.VouchersRepository" SelectMethod="GetVouchers"  runat="server"  ></asp:ObjectDataSource>

    </asp:Content>

