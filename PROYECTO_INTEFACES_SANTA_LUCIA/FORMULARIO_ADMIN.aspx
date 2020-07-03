<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FORMULARIO_ADMIN.aspx.cs" Inherits="login.FORMULARIO_ADMIN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="Bootstrap/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="gtco-container">
            <div class="row">
                <div class="col-md-12 col-md-offset-0 text-left">
                    <div class="row row-mt-15em">
                        <div class="col-md-4">
                            <asp:Label ID="Label1" runat="server" Text="CN SANTA LUCIA"></asp:Label>
                            <asp:Menu ID="Menu1" runat="server">
                                <Items>
                                    <asp:MenuItem Text="Perfil" Value="perfil"></asp:MenuItem>
                                    <asp:MenuItem Text="Registrar Usuario" Value="r_Usuario"></asp:MenuItem>
                                    <asp:MenuItem Text="Registrar Matricula" Value="r_Matricula"></asp:MenuItem>
                                    <asp:MenuItem Text="Reporte Matricula" Value="reportMatricula"></asp:MenuItem>
                                </Items>
                            </asp:Menu>
                        </div>
                        
                        <div class="col-md-7">
                            <h1>ohla</h1>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>  

        <%--<div class="container">
            <asp:Panel ID="pmenu" runat="server" Height="331px" Width="289px" BackColor="Yellow">
            <asp:Label ID="santa" runat="server" Text="CN.SANTA LUCIA" BorderStyle="None"></asp:Label>
            </asp:Panel>
            </div>
             <div class="container">
            <asp:Panel ID="Panel1" runat="server" BackColor="red" >dd</asp:Panel>
            </div> --%>
    </form>
</body>
</html>
