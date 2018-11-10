<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ThirdDatabaseHandin.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Find a movie using a webservice. Remember to have SmallService Application running.<br />
            <br />
            <asp:Label ID="LabelPort" runat="server" Text="Port"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBoxPort" runat="server">60276</asp:TextBox>
&nbsp;(60276)<br />
            <br />
            <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelFileMade" runat="server" Text="Is file made?"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Text="Message"></asp:Label>
            <br />
            <asp:Button ID="BtnMovie" runat="server" OnClick="BtnMovie_Click" Text="Find Movie" />
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBoxResult" runat="server" Height="189px" Width="647px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelResult" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Image ID="ImagePoster" runat="server" />
        </div>
    </form>
</body>
</html>
