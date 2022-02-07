package extra2;

import java.util.ArrayList;

public class Lamda01 {

	public static void main(String[] args) {
		ArrayList<Integer> list = new ArrayList<>();
		list.add(Math.min((int)Math.pow(2, 2),5));
		list.add(Math.max(10 / 5 - 1, 2 * 3 / (9 - 8) - 6));
		list.add(10 % 4);

		list.sort((a,b) -> -a.compareTo(b));

		for(int n:list){
			System.out.println(n);
		}

	}

}
