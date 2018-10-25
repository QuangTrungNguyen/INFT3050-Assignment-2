<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="BattlingElementalTitans.Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 400px;
            height: 250px;
        }
        .auto-style18 {
            font-size: x-large;
        }
        .auto-style19 {
            width: 397px;
        }
        .auto-style20 {
            color: #000066;
            font-size: large;
        }
        .auto-style21 {
            color: #000066;
            font-weight: bold;
            font-size: large;
        }
        .auto-style22 {
            color: #FF9900;
        }
        .auto-style23 {
            color: #FF9900;
            font-size: xx-large;
            font-family: Arial;
        }
    </style>
    <script>
        function hide() {
            popCheckTitans.hide();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1" style="width: 80%" align="center">
        <tr>
            <td style="color: #996600">
                <h3 class="auto-style23">Your Exercise Points Balance</h3>
            </td>
        </tr>
        <tr>
            <td class="align"><strong>
                <asp:Label ID="lblExercisePoints" runat="server" CssClass="auto-style18"></asp:Label>
                <br />
                <br />
                </strong></td>
        </tr>
    </table>

    <table border="1" style="width: 80%" align="center">
        <tr>
            <td colspan="3">
                <h3 class="auto-style22">Your Titan&#39;s Information</h3>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <div class="align">
                    <select name="D1">
                        <option value="fire_king">The Fire King</option>
                        <option value="destroyer">The Destroyer</option>
                        <option value="lava_knight">The Lava Knight</option>
                    </select>
                </div>
            </td>
        </tr>
        <tr>
            <td rowspan="8" class="auto-style19">
                <div class="align">
                    <img src="http://i.imgur.com/ZA7y1Js.jpg" />
                </div>
            </td>
            <td class="auto-style21">
                <h3 class="auto-style20">Character Name:</h3>
            </td>
            <td>
                <p class="auto-style21">
                                        The Fire King</p>
            </td>
        </tr>
        <tr>
            <td class="auto-style21">
                <h3 class="auto-style20">Elemental Class:</h3>
            </td>
            <td>
                <p class="auto-style21">
                                        Fire</p>
            </td>
        </tr>
        <tr>
            <td class="auto-style21">
                <h3 class="auto-style20">Level:</h3>
            </td>
            <td>
                <p class="auto-style21">
                                        1</p>
            </td>
        </tr>
        <tr>
            <td class="auto-style21">
                <h3 class="auto-style20">Step:</h3>
            </td>
            <td>
                <p class="auto-style21">
                                        2</p>
            </td>
        </tr>
        <tr>
            <td class="auto-style21">
                <h3 class="auto-style20">Experience Points:</h3>
            </td>
            <td>
                <p class="auto-style21">
                                        80</p>
            </td>
        </tr>
        <tr>
            <td class="auto-style21">
                <h3 class="auto-style20">Battles:</h3>
            </td>
            <td>
                <p class="auto-style21">
                                        5</p>
            </td>
        </tr>
        <tr>
            <td class="auto-style21">
                <h3 class="auto-style20">Wins:</h3>
            </td>
            <td>
                <p class="auto-style21">
                                        3</p>
            </td>
        </tr>
        <tr>
            <td class="auto-style21">
                <h3 class="auto-style20">Losses:</h3>
            </td>
            <td>
                <p class="auto-style21">
                                        2</p>
            </td>
        </tr>
    </table>
    </asp:Content>
