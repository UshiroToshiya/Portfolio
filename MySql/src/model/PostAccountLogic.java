package model;

import dao.AccountDAO;

public class PostAccountLogic {
	public boolean execute(Account account){
		AccountDAO dao = new AccountDAO();
		boolean AccountSucessResult = dao.createAccount(account);

		return AccountSucessResult;
	}
}
