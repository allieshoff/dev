<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1" import="movies.*,java.util.*"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Login</title>
<link href="css/bootstrap.css" rel="stylesheet" type="text/css"/>
</head>
<body>

	<form action="LoginServlet">
	<div class="container">
		<h1>Login</h1>
		
		<input name="username"/>
		<input name="password" type="password"/>
		<button name="action" value="login">Login</button>
		
	</div>
	</form>
	
</body>
</html>