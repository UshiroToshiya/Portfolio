<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>

<!DOCTYPE html>
<html>
	<head>
		<meta charset=UTF-8>
		<title>ログイン</title>
	</head>
	<body>

		<p>ユーザーIDとパスワードを入力してください</p>
		<br>
		<form action="/sukkiriShop/LoginServlet" method="post">
		ユーザーID:<input type="text" name="userId"><br>
		パスワード:<input type="password" name="pass"><br>
		<input type="submit" value="ログイン">
		</form>
		<br>
		<a href="/sukkiriShop/WelcomeServlet">トップへ</a>

	</body>
</html>