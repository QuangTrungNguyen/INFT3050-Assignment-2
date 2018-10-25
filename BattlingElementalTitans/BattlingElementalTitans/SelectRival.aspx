<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="SelectRival.aspx.cs" Inherits="BattlingElementalTitans.SelectRival" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style23 {
            color: #000066;
        }
        .auto-style22 {
            height: 39px;
        }
        .auto-style19 {
            text-align: center;
            font-size: medium;
            font-family: Arial;
            height: 172px;
        }
        .auto-style18 {
            color: #FF9900;
            font-size: xx-large;
        }
        .auto-style24 {
            height: 39px;
            text-align: center;
        }
        .newStyle1 {
            background-color: #FFFFFF;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="MainForm" >
                <tr>
                    <td class="auto-style19">
                        <span class="auto-style18"><strong>Select Your Rival</strong></span></td>
                </tr>
                </table>
    <table border="1" style="width:80%" align="center">
        <tr class="newStyle1">
            <td>
                <h3 class="auto-style23"><strong>Character</strong></h3>
            </td>
            <td>
                <h3 class="auto-style23"><strong>User</strong></h3>
            </td>
            <td>
                <h3 class="auto-style23">Element</h3>
            </td>
            <td>
                <h3 class="auto-style23">Level</h3>
            </td>
            <td>
                <h3 class="auto-style23">Steps</h3>
            </td>
            <td>
                <h3 class="auto-style23">Select</h3>
            </td>
        </tr>
        <tr>
            <td class="auto-style22">
                <p class="auto-style23">
                    <strong>Dark_Knight</strong></p>
            </td>
            <td class="auto-style22">
                <p class="auto-style23">
                    <strong>TitanGod</strong></p>
            </td>
            <td class="auto-style22">
                <p class="auto-style23">
                    <strong>Fire</strong></p>
            </td>
            <td class="auto-style22">
                <p class="auto-style23">
                    <strong>4</strong></p>
            </td>
            <td class="auto-style22">
                <p class="auto-style23">
                    <strong>1</strong></p>
            </td>
            <td class="auto-style24">
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="rival"/>
            </td>
        </tr>
        <tr>
            <td>
                <p class="auto-style23">
                    <strong>Hero_of_Fire</strong></p>
            </td>
            <td>
                <p class="auto-style23">
                    <strong>SampleUser</strong></p>
            </td>
            <td>
                <p class="auto-style23">
                    <strong>Fire</strong></p>
            </td>
            <td>
                <p class="auto-style23">
                    <strong>4</strong></p>
            </td>
            <td>
                <p class="auto-style23">
                    <strong>3</strong></p>
            </td>
            <td class="align">
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="rival" />
            </td>
        </tr>
        <tr>
            <td>
                <p class="auto-style23">
                    <strong>SixPathsSage</strong></p>
            </td>
            <td>
                <p class="auto-style23">
                    <strong>Ninja04</strong></p>
            </td>
            <td>
                <p class="auto-style23">
                    <strong>Air</strong></p>
            </td>
            <td>
                <p class="auto-style23">
                    <strong>2</strong></p>
            </td>
            <td>
                <p class="auto-style23">
                    <strong>2</strong></p>
            </td>
            <td class="align">
                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="rival" />
            </td>
        </tr>
    </table>
    <table style="width:80%" align="center">
        <tr>
            <td class="align" colspan="6">
                <br />
                <br />
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/button/btnFight.png" OnClick="ImageButton1_Click" />
            </td>
        </tr>
    </table>
    </asp:Content>
