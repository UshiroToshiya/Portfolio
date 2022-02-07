package extra;

public class Array02 {

	public static void main(String[] args) {
		String[] array = new String[5];
		array[0] = "A";
		array[2] = "B";
		array[4] = "C";

		for(String str : array){
			System.out.print(str + ",");
		}
		//1. A,B,C,	 	2.A,null,B,null,C, 	3.実行時エラー
	}

}
