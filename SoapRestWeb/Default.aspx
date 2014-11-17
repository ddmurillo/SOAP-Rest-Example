<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SoapRestWeb._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        input[type='text']
        {
            width: 82px;
            margin-left: 2px;
        }
    </style>
    <script type="text/javascript">
        var url_rest = 'http://localhost:61001/Math.svc/';
        $(document).ready(function () {
            btn = $("[id *= 'restBtn']");

            btn.click(function (e) {
                e.preventDefault();
                if (Page_ClientValidate()) {
                    $.ajax({
                        url: url_rest + "resta/" + $("[id *= 'val1']").val() + "/" + $("[id *= 'val2']").val(),
                        //data: "{}",
                        type: "GET",
                        //jsonpCallback: "result",
                        contentType: "application/json",
                        dataType: "jsonp"
                    }).done(function (data) {
                        $("[id *= 'result']").val(data.result);
                    }).fail(function (data) {
                        alert("Ajax Error");
                    });
                }
            });
        });

        function Result(data) { alert("ja"); }
    </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List"
        ShowSummary="false" ShowMessageBox="true" />
    <div class="u4 display">
        <div class="display-inner">
            <div class="display-text">
                Resultado&nbsp;<asp:TextBox ID="result" runat="server" MaxLength="10"></asp:TextBox>
            </div>
        </div>
        <div class="display-inner">
            <div class="display-text">
                Valor 1&nbsp;<asp:TextBox ID="val1" runat="server" MaxLength="8"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Escriba el primer valor"
                    ControlToValidate="val1" Display="None"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="El primer valor debe ser entero"
                    ControlToValidate="val1" ValidationExpression="[0-9]+" Display="None"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="display-inner">
            <div class="display-text">
                Valor 2&nbsp;<asp:TextBox ID="val2" runat="server" MaxLength="8"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Escriba el segundo valor"
                    ControlToValidate="val2" Display="None"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="El segundo valor debe ser entero"
                    ControlToValidate="val2" ValidationExpression="[0-9]+" Display="None"></asp:RegularExpressionValidator>
            </div>
        </div>
    </div>
    <asp:Button ID="addBtn" runat="server" Text="Sumar" CssClass="u1 button button-blue"
        OnClick="addBtn_Click" />
    <asp:Button ID="restBtn" runat="server" Text="Restar" CssClass="u1 button button-red"
        CausesValidation="false" />
</asp:Content>
