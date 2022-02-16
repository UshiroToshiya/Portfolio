package sevlet;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import model.Account;
import model.PostAccountLogic;


@WebServlet("/AccountCreateServlet")
public class AccountCreateServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;


	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		//フォワード
		RequestDispatcher dispatcher = request.getRequestDispatcher("/WEB-INF/jsp/accountCreate.jsp");
		dispatcher.forward(request, response);
	}


	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {




		try{
			request.setCharacterEncoding("UTF-8");
			//入力した値を変数へ代入する
			String userId = request.getParameter("userId");
			String pass = request.getParameter("pass");
			String mail = request.getParameter("mail");
			String name = request.getParameter("name");
			int age = Integer.parseInt(request.getParameter("age"));



			if(userId.length() == 0 && pass.length() == 0 && mail.length() == 0 && name.length() == 0){
				//リダイレクト
				response.sendRedirect("/sukkiriShop/AccountCreateServlet");
			}
			//データベースに入力した内容を保存して真偽値を返す
			Account account = new Account(userId, pass, mail, name, age);
			PostAccountLogic postAccountLogic = new PostAccountLogic();
			boolean accountCreateResult = postAccountLogic.execute(account);

			//データベースに登録したらフォワード
			if(accountCreateResult == true){

				RequestDispatcher dispatcher = request.getRequestDispatcher("/WEB-INF/jsp/accountCreateSuccess.jsp");
				dispatcher.forward(request, response);
			}else{
				//リダイレクト
				response.sendRedirect("/sukkiriShop/AccountCreateServlet");
				request.setAttribute("errorMessage", "もう一度入力してください");
			}





		}catch(NumberFormatException n){
			//リダイレクト
			response.sendRedirect("/sukkiriShop/AccountCreateServlet");

			request.setAttribute("errorMessage", "もう一度入力してください");
		}

	}
}
