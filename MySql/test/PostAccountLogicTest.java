package test;

import model.Account;
import model.PostAccountLogic;

public class PostAccountLogicTest {

	public static void main(String[] args) {
		testExecute();

	}

	public static void testExecute(){
		Account account = new Account("yamato", "1234", "yamato@sukkiri", "大和", 25);
		PostAccountLogic postAccountLogic = new PostAccountLogic();
		boolean AccountSuccessResult = postAccountLogic.execute(account);
		if(AccountSuccessResult == true){
			System.out.println("成功しました");
		}else{
			System.out.println("失敗しました");
		}

	}

}
