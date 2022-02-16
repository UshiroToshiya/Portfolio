<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<% String errorMessage = (String) request.getAttribute("errorMessage"); %>
<!DOCTYPE html>
<html>
	<head>
		<meta charset=UTF-8>
		<title>アカウント作成</title>
	</head>
	<body>

		<h1>新規アカウント作成</h1>
		<br>
		<p>フォームに情報を入力してください
		<br>
		<form action="/sukkiriShop/AccountCreateServlet" method="post">
			USER_ID：<input type="text" name="userId">半角10文字<br>
			PASSWORD:<input type="text" name="pass">半角10文字<br>
			MAIL_ADDRESS：<input type="text" name="mail">半角100文字<br>
			NAME：<input type="text" name="name">半角40文字<br>
			AGE：<input type="text" name="age"><br>
			<input type="submit" value="登録">
			<% if(errorMessage != null){%>
			<p><%= errorMessage %></p>
			<% } %>
		</form>
		<br>
		<a href="/sukkiriShop/WelcomeServlet">トップへ</a>
	</body>
</html>