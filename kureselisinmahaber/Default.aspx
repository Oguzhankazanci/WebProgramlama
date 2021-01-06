<%@ Page Title="" Language="C#" MasterPageFile="~/anasablon.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="kureselisinmahaber.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="rptIcerik" runat="server" DataSourceID="dsIcerik">
        <ItemTemplate>
            <h3>
                <%#Eval("sayfa_basligi") %>
            </h3>
            <div>
                <%#Eval("sayfa_icerigi") %>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <asp:SqlDataSource ID="dsIcerik" runat="server" ConnectionString="<%$ ConnectionStrings:WebHaberSayfaConnectionString %>" SelectCommand="SELECT * FROM [sayfalar] WHERE (([sayfa_id] = @sayfa_id) AND ([aktif] = @aktif) AND ([silindi] = @silindi))">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="1" Name="sayfa_id" QueryStringField="id" Type="Int32" />
            <asp:Parameter DefaultValue="True" Name="aktif" Type="Boolean" />
            <asp:Parameter DefaultValue="False" Name="silindi" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
