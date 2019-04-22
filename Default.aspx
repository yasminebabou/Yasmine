<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="test._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1><strong>Motor Winding Temperature Calculation</strong></h1>
        <p class="lead">Input your data and then Run </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Input Data </h2>
            <p>Motor Series :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ListBox ID="ListBox1" runat="server" Height="18px" Width="79px" required="yes">
                    <asp:ListItem Value="350"></asp:ListItem>
                    <asp:ListItem Value="380"></asp:ListItem>
                    <asp:ListItem Value="450"></asp:ListItem>
                    <asp:ListItem Value="450E"></asp:ListItem>
                    <asp:ListItem Value="550"></asp:ListItem>
                    <asp:ListItem>650</asp:ListItem>
                    <asp:ListItem>740</asp:ListItem>
                </asp:ListBox>
            </p>
            <p>Motor HP : <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="74px" required="yes"></asp:TextBox>
&nbsp;HP</p>
            <p>Pump HP :
                <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="74px" required="yes"></asp:TextBox>
&nbsp;HP</p>
            <p>Bottom Hole Temperature :
                <asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="74px" required="yes"></asp:TextBox>
&nbsp;°F</p>
            <p>Pumping Flow Rate :
                <asp:TextBox ID="TextBox4" runat="server" Height="16px" Width="74px" required="yes" ></asp:TextBox>
&nbsp;</p>
            <p>Well Casing ID :
                <asp:TextBox ID="TextBox5" runat="server" Height="16px" Width="74px" required="yes"></asp:TextBox>
&nbsp;Inch</p>
            <p>Water cut :
                <asp:TextBox ID="TextBox6" runat="server" Height="16px" Width="74px" required="yes"></asp:TextBox>
&nbsp;%</p>
            <p>API :
                <asp:TextBox ID="TextBox7" runat="server" Height="16px" Width="74px" required="yes"></asp:TextBox>
&nbsp;</p>
            <p>Pump Intake Pressure PSI :
                <asp:TextBox ID="TextBox8" runat="server" Height="16px" Width="74px" required="yes"></asp:TextBox>
&nbsp;Psi</p>
            <p>Bubble Point PSI :
                <asp:TextBox ID="TextBox9" runat="server" Height="16px" Width="74px" required="yes"></asp:TextBox>
&nbsp;Psi</p>
            <p>Solution Gas-Oil-Ratio at the intake SCF/STB :
                <asp:TextBox ID="TextBox10" runat="server" Height="16px" Width="74px" required="yes"></asp:TextBox>
            </p>
            <p>Surface Gas-Oil-Ratio SCF/STB :&nbsp;
                <asp:TextBox ID="TextBox11" runat="server" Height="16px" Width="74px" required="yes"></asp:TextBox>
            </p>
            <p>Motor Running Frequency :
                <asp:TextBox ID="TextBox12" runat="server" Height="16px" Width="74px" required="yes"></asp:TextBox>
&nbsp; Hz</p>
        
            <asp:Button ID="button_Click" runat="server" type="submit" Height="16px" Text="Run" Width="40px" OnClick="button_Click_Click" />
            
            &nbsp;</p>
        </div>
    </div>

</asp:Content>
