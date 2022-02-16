<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    <%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
	<head>
		<meta charset=UTF-8>
		<title>ログアウト</title>
	</head>
	<body>
		<p>ログアウトしました</p>
		<p>ユーザーID:<c:out value="${userId}"/>さん</p>
		<br>
		<a href="/sukkiriShop/WelcomeServlet">トップへ</a>
	</body>
</html>