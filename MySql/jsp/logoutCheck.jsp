<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    <%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
	<head>
		<meta charset=UTF-8>
		<title>ログアウト確認</title>
	</head>
	<body>
		<p><c:out value="${userId}"/>さん</p>
		<p>ログアウトしてもよろしいですか？</p>
		<br>
		<a href="/sukkiriShop/LogoutServlet">はい</a>
		<a href="/sukkiriShop/MainServlet">いいえ</a>
	</body>
</html>