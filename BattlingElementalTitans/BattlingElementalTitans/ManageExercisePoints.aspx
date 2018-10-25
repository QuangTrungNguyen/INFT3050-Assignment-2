<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="ManageExercisePoints.aspx.cs" Inherits="BattlingElementalTitans.ManageExercisePoints" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style18 {
            text-align: center;
            font-size: large;
        }
        .align {text-align: center}
        p {text-align: center}
        h3 {text-align: center}
        h1 {text-align: center}
        .auto-style20 {
            font-weight: bold;
            color: #000066;
        }
        .auto-style21 {
            color: #FF9900;
        }
        .auto-style22 {
            text-align: center;
            font-size: xx-large;
            font-family: Arial;
        }
        .auto-style23 {
            color: #000066;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
    <table class="MainForm" >
                <tr>
                    <td class="auto-style22">
                        <span class="auto-style21"><strong>
                        Manage Your Exercise Points</strong></span><br />
                        <br />
                    </td>
                </tr>
                </table>
              <table class="MainForm"  border="1">
                <tr>
                    <td class="auto-style18">
                        <strong><span class="auto-style21">&nbsp;Exercise points balance:</span><br />
                        <asp:Label ID="lblExercisePoints" runat="server"></asp:Label>
                        <br />
                        <span class="auto-style21">Select a titan to add exercise points:</span><br />
                        </strong>
                        <select id="sbxTitan" name="D1">
                            <option value="fire_king">The_Fire_King</option>
                            <option value="destroyer">The_Destroyer</option>
                            <option value="lava_knight">The_Lava_Knight</option>
                        </select></td>
                </tr>
                <tr>
                    <td class="auto-style18">
                        <table border="1" style="width:100%">
                            <tr>
                                <td rowspan="6">
                                    <div class="align">
                                        <img src="http://i.imgur.com/ZA7y1Js.jpg" />
                                    </div>
                                </td>
                                <td class="auto-style20">
                                    <p class="auto-style23">
                                        Character Name:</p>
                                </td>
                                <td>
                                    <p class="auto-style20">
                                        The_Fire_King</p>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style20">
                                    <p class="auto-style23">
                                        Level:</p>
                                </td>
                                <td>
                                    <p class="auto-style20">
                                        2</p>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style20">
                                    <p class="auto-style23">
                                        Experience Steps:</p>
                                </td>
                                <td>
                                    <p class="auto-style20">
                                        4</p>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style20">
                                    <p class="auto-style23">
                                        Exercise Points:</p>
                                </td>
                                <td>
                                    <p class="auto-style20">
                                        230</p>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style20">
                                    <h3 class="auto-style23">Enter the amount of points you would like to add to this titan</h3>
                                </td>
                                <td>
                                    <div class="align">
                                        <asp:TextBox ID="tbxAdd" runat="server" TextMode="Number" CssClass="auto-style20"></asp:TextBox>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <div class="align">
                                        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="ADD" />
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
        </table>
</asp:Content>
