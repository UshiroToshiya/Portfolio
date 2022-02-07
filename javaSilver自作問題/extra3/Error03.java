package extra3;

import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;

public class Error03 {

	public static void main(String[] args) {
		try{
			FileWriter fw = new FileWriter("/あの辺の/この辺のファイル");
		}catch(FileNotFoundException f){
			System.out.println("あるわけない");

		}catch(IOException i){
			System.out.println("ないけどね");
		}finally {
			System.out.println("そんな感じのファイル探して！");
		}


	}

}
