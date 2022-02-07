package extra;

import java.util.ArrayList;

public class List01 {

	public static void main(String[] args) {
		ArrayList<String> list = new ArrayList<>();
		list.add("ゼウス");
		list.add("ヘラ");
		list.add("アレス");

		for(String str : list){
			System.out.println(str);
			list.remove("ヘラ");

		}

	}

}
