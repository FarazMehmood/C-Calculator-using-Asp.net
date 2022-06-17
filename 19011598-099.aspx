<%@ Page Language="C#" AutoEventWireup="true" CodeFile="19011598-099.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link  href="Stylesheet.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .auto-style1 {
            width: 425px;
        }
        .auto-style2 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            padding: 5px;
            border-radius: 20px;
            font-size: 20px;
        }
    </style>

</head>

<body style="height: 334px" >
    <form id="form1" runat="server" class="auto-style1"   >
        <asp:Label ID="Label2" runat="server" Font-Size="Larger" Text="Simple Calculator" CssClass="auto-style2"></asp:Label>
        <br />
        &nbsp;
        <asp:Label ID="Label1" runat="server" Text="0" BorderStyle="Ridge" style="margin-left: 0px" Width="342px" CssClass="input" BorderColor="#999966" Font-Bold="True" Font-Size="Larger" Height="36px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="btntest1" runat="server" Visible="False"></asp:Label>
        <asp:Label ID="btntest2" runat="server" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />

&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblerror" runat="server" BorderColor="Black" style="margin-left: 0px" Width="358px"></asp:Label>
        <br />
        <br />
        &nbsp;
        <asp:Button ID="btnred" runat="server" CssClass="auto-style2" OnClick="btnred_Click1" Text="red" Font-Size="Small" Height="32px" Width="72px" BorderStyle="Dotted" />
&nbsp;
        <asp:Button ID="btngreen" runat="server" CssClass="auto-style2" OnClick="btngreen_Click" Text="green" Font-Size="Small" Height="29px" Width="78px" BorderStyle="Dotted" />
&nbsp;<asp:Button ID="btnblue" runat="server" CssClass="auto-style2" OnClick="btnblue_Click" Text="blue" Font-Size="Small" Height="28px" Width="81px" BorderStyle="Dotted" />

        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnrevert" runat="server" CssClass="auto-style2" OnClick="btnrevert_Click" Text="White Theme" Font-Size="Small" Height="33px" Width="102px" BorderStyle="Dotted" />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <br />
        &nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="btn7" runat="server" OnClick="btn7_Click" Text="7" CssClass="Button" BackColor="#999966" />
&nbsp;<asp:Button ID="btn8" runat="server" OnClick="btn8_Click" Text="8" CssClass="Button" BackColor="#999966" />
&nbsp;<asp:Button ID="btn9" runat="server" OnClick="btn9_Click" Text="9" CssClass="Button" BackColor="#999966" />
&nbsp;<asp:Button ID="btnplus" runat="server" OnClick="btnplus_Click" Text="+" CssClass="Button" BackColor="#669999"/>
&nbsp;<asp:Button ID="btndone" runat="server" OnClick="btndone_Click" Text="Calculate" Width="179px" CssClass="auto-style2" BackColor="#3399FF" Font-Size="Medium" />
        <br />
        <br />
        <asp:Button ID="btn4" runat="server" OnClick="btn4_Click" Text="4" CssClass="Button" BackColor="#999966" />
&nbsp;<asp:Button ID="btn5" runat="server" OnClick="btn5_Click" Text="5" CssClass="Button" BackColor="#999966"/>
&nbsp;<asp:Button ID="btn6" runat="server" OnClick="btn6_Click" Text="6" CssClass="Button" BackColor="#999966" />
&nbsp;<asp:Button ID="btnminus" runat="server" OnClick="btnminus_Click" Text="-" CssClass="Button" BackColor="#669999" />
        <asp:Button ID="btnbackspace" runat="server" OnClick="btnbackspace_Click" style="margin-left: 8px" Text="Backspace " Width="172px" CssClass="auto-style2" BackColor="#3399FF" Font-Size="Medium" />
        <br />
        <br />
        <asp:Button ID="btn3" runat="server" OnClick="btn3_Click" Text="3" CssClass="Button" BackColor="#999966" />
&nbsp;<asp:Button ID="btn2" runat="server" OnClick="btn2_Click" Text="2" CssClass="Button" BackColor="#999966" BorderColor="#CC9900" />
        &nbsp;<asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="1" CssClass="Button" BackColor="#999966"/>
&nbsp;<asp:Button ID="btnmultiply" runat="server" OnClick="btnmultiply_Click" Text="*" CssClass="Button" BackColor="#669999" />
        &nbsp;<asp:Button ID="btnup" runat="server" OnClick="btnup_Click" Text="Checkup" CssClass="auto-style2" BackColor="#3399FF" Font-Size="Small" Width="77px" />
&nbsp;<asp:Button ID="btndown" runat="server" OnClick="btndown_Click" Text="Check Down" CssClass="auto-style2" Width="99px" BackColor="#3399FF" Font-Size="Small"/>
        <br />
        <br />
        <asp:Button ID="btndecimal" runat="server" OnClick="btndecimal_Click" Text="." CssClass="Button" BackColor="#669999"/>
&nbsp;<asp:Button ID="btn0" runat="server" OnClick="btn0_Click" Text="0" CssClass="Button" BackColor="#999966" BorderColor="#FF9900" />
&nbsp;<asp:Button ID="btnmod" runat="server" Text="%" CssClass="Button" OnClick="btnmod_Click" BackColor="#669999" />
&nbsp;<asp:Button ID="btndivide" runat="server" OnClick="btndivide_Click" Text="/" CssClass="Button" BackColor="#669999"/>
        &nbsp;
        <asp:Button ID="btnclear" runat="server" OnClick="btnclear_Click" Text="clear" Width="172px" CssClass="auto-style2" BackColor="#3399FF" Font-Size="Medium" Height="31px"/>
        <br />
        <br />
    </form>
</body>
</html>
