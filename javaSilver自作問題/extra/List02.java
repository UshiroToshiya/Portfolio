package extra;

import java.util.ArrayList;

public class List02 {

	public static void main(String[] args) {
		ArrayList<String> list = new ArrayList<>();
		list.add("A");
		list.add("B");
		list.add("C");
		list.add("D");


		for(String str: list ){
			if("C".equals(str)){
				list.remove(str);
			}else{
				System.out.println(str);
			}
		}

	}
}
