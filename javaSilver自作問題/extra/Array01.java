package extra;

import java.util.ArrayList;

public class Array01 {

	public static void main(String[] args) {
		ArrayList<String> strList = new ArrayList<>();

		for(String str : strList){
			str += "ABC";
			str += " DEF";
		}
		//System.out.println(strList.size());
//1.ABCDEF 2.ABC DEF 3.何も表示しない 4.例外エラー
	}

}
