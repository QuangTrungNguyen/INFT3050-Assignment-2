<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="HallOfFame.aspx.cs" Inherits="BattlingElementalTitans.HallOfFame" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style18 {
            color: #FF9900;
            font-size: xx-large;
        }
        .auto-style19 {
            text-align: center;
            font-size: medium;
            font-family: Arial;
            height: 172px;
        }
        .auto-style21 {
            color: #000066;
            height: 39px;
        }
        .auto-style22 {
            height: 39px;
        }
        .auto-style23 {
            color: #000066;
        }
        .newStyle1 {
            background-color: #FFFFFF;
        }
        .auto-style25 {
            height: 39px;
            width: 185px;
        }
        .auto-style26 {
            width: 185px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="MainForm" >
                <tr>
                    <td class="auto-style19">
                        <span class="auto-style18"><strong>~ Hall Of Fame ~</strong></span><br />
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="">
                        <table border="1" style="width:100%">
            <tr class="newStyle1">    
                <td class="auto-style23"><h3 class="auto-style23"><strong>Rank</strong></h3></td>
                <td><h3 class="auto-style23">Titan</h3></td>
                <td class="auto-style26"><h3 class="auto-style23"><strong>User</strong></h3></td>
                <td><h3 class="auto-style23"><strong>Battle Count</strong></h3></td>
                <td><h3 class="auto-style23"><strong>Wins</strong></h3></td>
                <td><h3 class="auto-style23"><strong>Losses</strong></h3></td>
                <td><h3 class="auto-style23"><strong>Date Created</strong></h3></td>
            </tr>
            <tr>
                <td class="auto-style21"><p class="auto-style23"><strong>1</strong></p></td>
                <td class="auto-style22"><p class="auto-style23"><strong>Dark_Knight</strong></p></td>
                <td class="auto-style25"><p class="auto-style23"><strong>TitanGod</strong></p></td>
                <td class="auto-style22"><p class="auto-style23"><strong>580</strong></p></td>
                <td class="auto-style22"><p class="auto-style23"><strong>470</strong></p></td>
                <td class="auto-style22"><p class="auto-style23"><strong>110</strong></p></td>
                <td class="auto-style22"><p class="auto-style23"><strong>02-03-2016</strong></p></td>
            </tr>
            <tr>
                <td class="auto-style23"><p class="auto-style23"><strong>2</strong></p></td>
                <td><p class="auto-style23"><strong>Hero_of_Fire</strong></p></td>
                <td class="auto-style26"><p class="auto-style23"><strong>Anonymous</strong></p></td>
                <td><p class="auto-style23"><strong>650</strong></p></td>
                <td><p class="auto-style23"><strong>370</strong></p></td>
                <td><p class="auto-style23"><strong>280</strong></p></td>
                <td><p class="auto-style23"><strong>25-02-2016</strong></p></td>
            </tr>
            <tr>
                <td class="auto-style23"><p class="auto-style23"><strong>3</strong></p></td>
                <td><p class="auto-style23"><strong>SixPathsSage</strong></p></td>
                <td class="auto-style26"><p class="auto-style23"><strong>Ninja04</strong></p></td>
                <td><p class="auto-style23"><strong>460</strong></p></td>
                <td><p class="auto-style23"><strong>200</strong></p></td>
                <td><p class="auto-style23"><strong>260</strong></p></td>
                <td><p class="auto-style23"><strong>08-02-2016</strong></p></td>
            </tr>
        </table>  </td>
                </tr>
                </table>
</asp:Content>
