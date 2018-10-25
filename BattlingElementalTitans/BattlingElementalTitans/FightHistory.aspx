<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="FightHistory.aspx.cs" Inherits="BattlingElementalTitans.FightHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style23 {
            color: #000066;
        }
        .auto-style22 {
            height: 39px;
            text-align: center;
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
        .auto-style26 {
            height: 42px;
            text-align: center;
        }
        .auto-style28 {
            text-align: center;
            color: #000066;
            width: 200px;
        }
        .auto-style29 {
            height: 39px;
            text-align: center;
            color: #000066;
            width: 200px;
        }
        .auto-style30 {
            height: 42px;
            text-align: center;
            color: #000066;
            width: 200px;
        }
        .newStyle1 {
            background-color: #FFFFFF;
        }
        .auto-style31 {
            width: 171px;
            height: 42px;
            text-align: center;
            color: #000066;
        }
        .auto-style32 {
            height: 39px;
            width: 171px;
            text-align: center;
            color: #000066;
        }
        .auto-style33 {
            width: 171px;
            text-align: center;
            color: #000066;
        }
        .auto-style34 {
            width: 234px;
            height: 42px;
            text-align: center;
            color: #000066;
        }
        .auto-style35 {
            height: 39px;
            width: 234px;
            text-align: center;
            color: #000066;
        }
        .auto-style36 {
            width: 234px;
            text-align: center;
            color: #000066;
        }
        .auto-style37 {
            height: 42px;
            text-align: center;
            width: 93px;
        }
        .auto-style38 {
            height: 39px;
            text-align: center;
            width: 93px;
        }
        .auto-style39 {
            text-align: center;
            width: 93px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="MainForm">
                <tr>
                    <td class="auto-style19">
                        <span class="auto-style18"><strong>Fight Summary<br />
                        <br />
                        </strong></span></td>
                </tr>
                <tr>
                    <td class="">
                        <table border="1" style="width:100%">
            <tr class="newStyle1">    
                <td class="auto-style30"><h3 class="auto-style23"><strong>Titan</strong></h3></td>
                <td class="auto-style34"><strong>Rival Player</strong></td>
                <td class="auto-style31"><strong>Rival Titan</strong></td>
                <td class="auto-style37"><h3 class="auto-style23"><strong>Result</strong></h3>
                </td>
                <td class="auto-style26"><h3 class="auto-style23"><strong>Date</strong></h3></td>
            </tr>
            <tr>
                <td class="auto-style29"><p class="auto-style23"><strong>Dark_Knight</strong></p></td>
                <td class="auto-style35"><strong>SampleRivalOne </strong></td>
                <td class="auto-style32"><strong>King of Seas</strong></td>
                <td class="auto-style38"><p class="auto-style23"><strong>Win</strong></p>
                </td>
                <td class="auto-style22"><p class="auto-style23"><strong>02-03-2016</strong></p></td>
            </tr>
            <tr>
                <td class="auto-style28"><p class="auto-style23"><strong>Hero_of_Fire</strong></p></td>
                <td class="auto-style36"><strong>SampleRivalTwo</strong></td>
                <td class="auto-style33"><strong>Wind Cutter</strong></td>
                <td class="auto-style39"><p class="auto-style23"><strong>Lose</strong></p>
                </td>
                <td class="align"><p class="auto-style23"><strong>25-02-2016</strong></p></td>
            </tr>
            <tr>
                <td class="auto-style28"><p class="auto-style23"><strong>SixPathsSage</strong></p></td>
                <td class="auto-style36"><strong>SampleRivalThree</strong></td>
                <td class="auto-style33"><strong>Lava Knight</strong></td>
                <td class="auto-style39"><p class="auto-style23"><strong>Lose</strong></p>
                </td>
                <td class="align"><p class="auto-style23"><strong>08-02-2016</strong></p></td>
            </tr>
        </table>  </td>
                </tr>
                </table>
</asp:Content>
