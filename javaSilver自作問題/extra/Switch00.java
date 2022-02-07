package extra;

public class Switch00 {

	public static void main(String[] args) {
		String str = "四";
		int count = 0;

		switch(str){
		default :
			count++;
		case "壱":
			count++;
		case "":
			count += 2;
			break;
		case "参":
			count++;

		}
		System.out.println(count);
	}

}