<%@ Page Title="" Language="C#" MasterPageFile="~/VouchersWeb.Master" AutoEventWireup="true" CodeBehind="voucherDetails.aspx.cs" Inherits="SimpleWebForms.Pages.voucherDetails" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cpContent" runat="server">
     <fieldset>
        <legend>Voucher Data</legend>
         <div class="tbl">
             <div class="tblRow">
                 <div style="width: 5%" ><asp:Label ID="Label3" runat="server" Text="Text:" ></asp:Label></div>
                 <div style="width: 40%" ><asp:TextBox ID="txtVoucherText" runat="server"></asp:TextBox></div>
                 <div style="width: 5%" ><asp:Label ID="Label4" runat="server" Text="Date:" ></asp:Label></div>
                 <div style="width: 15%"><asp:TextBox ID="txtDate" runat="server" TextMode="Date" AutoPostBack="True"></asp:TextBox></div>
                 <div style="width: 30%" ><asp:RadioButtonList ID="rblType" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" Width="100%">
                     <asp:ListItem Value="0" Selected="True">Expense</asp:ListItem>
                     <asp:ListItem Value="1">Income</asp:ListItem>
                     </asp:RadioButtonList>
                 </div>
                 <div style="width: 5%" ><asp:Label ID="Label6" runat="server" Text="Paid:" ></asp:Label></div>
                 <div style="padding-top: 4px">
                     <asp:CheckBox ID="chkPaid" runat="server" />
                 </div>
             </div>
         </div>
    </fieldset>
    <fieldset>
        <legend>Details</legend>
        <div>
            <div class="tbl" style="padding-bottom: 10px">
                <div class="tblRow">
                    <div style="width: 400px">
                        <asp:Label ID="Label2" runat="server" Text="Text:"></asp:Label></div>
                    <div style="width: 100px">
                        <asp:Label ID="Label5" runat="server" Text="Amount:"></asp:Label></div>
                    <div style="width: 300px">
                        <asp:Label ID="Label1" runat="server" Text="Acct:"></asp:Label></div>
                </div>
                <div class="tblRow">
                    <div>
                        <asp:TextBox ID="txtVDText" runat="server" ></asp:TextBox></div>
                    <div>
                        <asp:TextBox ID="txtVDAmount" runat="server" TextMode="Number" ></asp:TextBox>
                    </div>
                    <div>
                        <asp:DropDownList ID="ddAccount" runat="server" DataSourceID="odsAccounts" DataTextField="Name" DataValueField="ID" ></asp:DropDownList></div>
                </div>
            </div>
            <div>
                <div class="tbl" style="padding-bottom: 10px">
                    <div class="tblRow">
                        <div style="width: 100%">
                            <asp:Label ID="Label7" runat="server" Text="Comment:"></asp:Label></div>
                    </div>
                    <div class="tblRow">
                        <div style="width: 100%">
                            <asp:TextBox ID="txtComment" runat="server" Rows="4" TextMode="MultiLine" Width="99.5%"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>  
            <div style="border: 1px solid black; padding-top: 5px; padding-bottom: 5px; margin-left: 10px; margin-right: 10px">
                Here we will add an Uploader for pictures in Mobile Client later on</div>          
            <div class="div-left-margin">
                <div>
                    <ul class="action-nav">
                        <li>
                            <asp:LinkButton ID="lbAdd" runat="server" OnClick="lbAdd_Click">Add</asp:LinkButton>
                        </li>
                    </ul>
                </div>
            </div>
            <div class="div-left-margin">
                <asp:GridView ID="gvVoucherDetails" runat="server" AutoGenerateColumns="False" DataSourceID="odsVoucherDetails" Width="100%" CellPadding="4" DataKeyNames="ID" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="detailChanged">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" Visible="False" />
                        <asp:BoundField DataField="VoucherID" HeaderText="VoucherID" SortExpression="VoucherID" Visible="False" />
                        <asp:BoundField DataField="Text" HeaderText="Text" SortExpression="Text">
                            <HeaderStyle HorizontalAlign="Left" />
                            <ItemStyle Width="40%" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount">
                            <ItemStyle Width="15%" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="AccountID" SortExpression="AccountID">
                            <ItemTemplate>
                                <asp:DropDownList ID="DropDownList2" DataSourceID="odsAllAccounts" DataValueField="ID" DataTextField="Name" runat="server" Enabled="False" Width="100%"></asp:DropDownList>
                            </ItemTemplate>
                            <ItemStyle Width="40%" />
                        </asp:TemplateField>
                        <asp:CommandField ShowSelectButton="True" ShowDeleteButton="True">
                            <ItemStyle Width="5%" />
                        </asp:CommandField>
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#ececec" Font-Bold="False" ForeColor="Black" />
                    <HeaderStyle BackColor="#ececec" Font-Bold="False" ForeColor="Black" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="False" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </div>
        </div>
    </fieldset>
        <asp:ObjectDataSource ID="odsAccounts" runat="server" SelectMethod="GetAccountsByType" TypeName="SimpleWebForms.Models.VouchersRepository">
            <SelectParameters>
                <asp:ControlParameter ControlID="rblType" DefaultValue="0" Name="Type" PropertyName="SelectedValue" Type="Int32" ConvertEmptyStringToNull="False"  />
            </SelectParameters>
        </asp:ObjectDataSource>
      <asp:ObjectDataSource ID="odsAllAccounts" runat="server" SelectMethod="GetAllAcccounts" TypeName="SimpleWebForms.Models.VouchersRepository"></asp:ObjectDataSource>
      <asp:ObjectDataSource ID="odsVoucherDetails" runat="server" SelectMethod="GetVoucherDetails" TypeName="SimpleWebForms.Models.VouchersRepository" DataObjectTypeName="SimpleWebForms.Models.VoucherDetails" DeleteMethod="RemoveDetail" InsertMethod="AddDetail" UpdateMethod="AddDetail">
                    <SelectParameters>
                        <asp:QueryStringParameter DbType="Guid" Name="ID" QueryStringField="ID" />
                    </SelectParameters>
                </asp:ObjectDataSource>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpSidebar" runat="server">
    <div>
        Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of &quot;de Finibus Bonorum et Malorum&quot; (The Extremes of Good and Evil) by Cicero, written 
        in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, &quot;Lorem ipsum dolor sit amet..&quot;, comes from a line in section 1.10.32.</div>
</asp:Content>
