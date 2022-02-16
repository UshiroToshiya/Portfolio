package test;

import model.Login;
import model.LoginLogic;

public class LoginLogicTest {

	public static void main(String[] args) {
		tesExecute1();
		testExecute2();

	}

	public static void tesExecute1(){
		Login login = new Login("minato","1234");
		LoginLogic bo = new LoginLogic();
		boolean result = bo.execute(login);
		if(result){
			System.out.println("testExecute1: 成功しました");

		}else{
			System.out.println("testExecute1:失敗しました");

		}
	}

	public static void testExecute2(){
		Login login = new Login("minato","12345");
		LoginLogic bo = new LoginLogic();
		boolean result = bo.execute(login);
		if(!result){
			System.out.println("testExecute1: 成功しました");

		}else{
			System.out.println("testExecute1:失敗しました");

		}
	}

}
