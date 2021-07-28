<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TeknikServ_Web.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.v21.1, Version=21.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 10px">
        <asp:Label ID="Label1" runat="server" Text="Ürün Seri No: " Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtUrunSeriNo" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Ara" Width="99px" OnClick="Button1_Click" Style="margin-left: 10px" CssClass="btn btn-success" />
    </div>

    <table class="table table-bordered" style="margin-top: 20px">
        <tr>
            <th>Açıklama</th>
            <th>Tarih</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("Aciklama") %></td>
                    <td><%# Eval("Tarih") %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
