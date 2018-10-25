<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="UploadExercisePoints.aspx.cs" Inherits="BattlingElementalTitans.ExerciseUpload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style23 {
            text-align: center;
            font-size: x-large;
        }
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }

        .auto-style7 {
            text-align: right;
            width: 136px;
        }
        .auto-style21 {
            text-align: center;
        }
        .auto-style9 {
            font-size: small;
        }
        .auto-style10 {
           width:50%;
           margin:0px auto;
        }
        .auto-style24 {
            text-align: left;
        }
        .auto-style25 {
            font-size: xx-large;
        }
        .auto-style26 {
            color: #FF9900;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style10">
        <tr class="newStyle1">
            <td class="auto-style23" colspan="2"><strong><span class="auto-style25"><span class="auto-style26">Upload Exercise Points</span><br class="auto-style26" />
                </span></strong>
                <br />
                <span class="auto-style9">Sample parent&#39;s email: czxbnb@gmail.com<br />
                password: cheng2277980</span></td>
        </tr>
        <tr>
            <td class="auto-style7">Steps:</td>
            <td class="auto-style24">&nbsp;<asp:TextBox ID="tbxSteps" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style21" colspan="2">100 Steps = 1 exercise points<br />
                Minimum 150 points, maximun 500 points per day.<br />
                </td>
        </tr>
        <tr>
            <td class="auto-style21" colspan="2">
                
                <asp:ImageButton ID="btnSubmitRecord" runat="server" ImageUrl="~/images/button/btnSubmit.png" OnClick="btnSubmitRecord_Click" />
                
            </td>
        </tr>
    </table>
</asp:Content>
