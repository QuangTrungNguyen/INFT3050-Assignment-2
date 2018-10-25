<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="ManageCharacter.aspx.cs" Inherits="BattlingElementalTitans.ManageCharacter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        h3 {text-align: center}
        .align {text-align: center}
        p {text-align: center}
        .auto-style18 {
            color: #FF9900;
        }
        .auto-style19 {
            font-size: xx-large;
        }
        .auto-style20 {
            color: #000066;
        }
        .auto-style21 {
            color: #000066;
            font-weight: bold;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table class="MainForm">
                <tr>
                    <td class="MainTitle">
                        <strong><span class="auto-style18"><span class="auto-style19">Manage Your Titans</span></span><span class="auto-style19"><br class="auto-style18" />
                        </span></strong>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                       
                        
                        <table border="1" style="width: 100%">
                            <tr>
                                <td colspan="3">
                                    <h3 class="auto-style18">Please Select A Titan</h3>
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
                                <td rowspan="9">
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
                                    <div class="align">
                                        <input type="submit" value="CHANGE NAME" class="auto-style21" /></div>
                                </td>
                                <td>
                                    <div class="align">
                                        <input name="change_titan_name" type="text" class="auto-style21" /></div>
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
                       
                        
                    </td>
                </tr>
            </table>

</asp:Content>
