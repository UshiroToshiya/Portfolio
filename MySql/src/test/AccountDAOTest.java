package test;

import dao.AccountDAO;
import model.Account;
import model.Login;

public class AccountDAOTest {
	public static void main(String[] args){
		testFindByLoginSuccess();
		testFindByLoginError();
		testAccountCreateSuccess();
		/*Login login = new Login("minato", "1234");
		AccountDAO dao = new AccountDAO();
		Account result = dao.findByLogin(login);
		System.out.println(result.getUserId() + result.getMail() + result.getName() + result.getPass() + result.getAge());*/

	}

	public static void testFindByLoginSuccess(){
		Login login = new Login("minato", "1234");
		AccountDAO dao = new AccountDAO();
		Account result = dao.findByLogin(login);
		if(result != null &&
				result.getUserId().equals("minato") &&
				result.getPass().equals("1234") &&
				result.getMail().equals("minato@sukkiri.com") &&
				result.getName().equals("湊 雄輔") &&
				result.getAge() == 23){
			System.out.println("testAccountCreateSuccess:成功しました");

		}else{
			System.out.println("testAccountCreateSuccess:失敗しました");
		}
	}

	public static void testFindByLoginError(){
		Login login = new Login("minato","12345");
		AccountDAO dao = new AccountDAO();
		Account result = dao.findByLogin(login);
		if(result == null){
			System.out.println("testFindByLoginError: 成功しました");
		}else{
			System.out.println("testFindByLoginError: 失敗しました");
		}
	}

	public static void testAccountCreateSuccess(){
		Account account = new Account("asaka", "4567", "asaka@sukkiri", "アサカ", 19);
		AccountDAO dao = new AccountDAO();
		boolean result = dao.createAccount(account);
		if(result == true){
			System.out.println("testAccountCreateSuccess:成功しました");

		}else{
			System.out.println("testAccountCreateSuccess:失敗しました");
		}
	}

}
