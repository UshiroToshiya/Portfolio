package extra;

public class Switch02 {

	public static void main(String[] args) {
		String strs []= {"A","B","C","D"};
		int count = 0;
		for(String str : strs){
			switch(str){
			case "D":
				count++;
			case "B":
				count ++;
				break;
			case "A":
				count--;
			case "C":
				count += 3;
			}
		}
		System.out.println(count);

	}

}
