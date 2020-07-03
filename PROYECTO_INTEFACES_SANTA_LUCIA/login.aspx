<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="Bootstrap/Style.css" rel="stylesheet" />
</head>
<body>
	<div class="container h-100">
		<div class="d-flex justify-content-center h-100">
			<div class="user_card">
				<div class="d-flex justify-content-center">
					<div class="brand_logo_container">
                        <asp:Image ID="imgLogo" class="brand_logo" src="img/isSantaLucia.png" runat="server" />
						<%--<img src="img/isSantaLucia.png" class="brand_logo" alt="Logo">--%>
					</div>
				</div>
				<div class="d-flex justify-content-center form_container">
					<form runat="server">
						<div class="input-group mb-3">
							<div class="input-group-append">
								<span class="input-group-text"><i class="fas fa-user"></i></span>
							</div>
                            <asp:TextBox ID="txtUsers" class="form-control input_user" placeholder="username" runat="server"></asp:TextBox>
						</div>
						<div class="input-group mb-2">
							<div class="input-group-append">
								<span class="input-group-text"><i class="fas fa-key"></i></span>
							</div>
                            <asp:TextBox ID="txtpass" type="password" class="form-control input_pass" value="" placeholder="password" runat="server"></asp:TextBox>
							<%--<input type="password" name="" class="form-control input_pass" value="" placeholder="password"/>--%>
						</div>
						<div class="d-flex justify-content-center mt-3 login_container">
                            <asp:Button ID="btnIngresar" class="btn login_btn" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
				 			<%--<button type="button" name="button" class="btn login_btn">Ingresar</button>--%>
						</div>
					</form>
				</div>
			</div>
		</div>
	</div>
	<footer id="sticky-footer" class="py-4 text-white-50">
		<div class="container text-center">
			<small>Av.André Avelino Cáseres</small>
		</div>
	</footer>
</body>

</html>
