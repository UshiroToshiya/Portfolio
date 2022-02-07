package extra2;

public class StringBuilder01 {

	public static void main(String[] args) {
		StringBuilder str = new StringBuilder();
		str.append("ABC");
		str.append("DEF");
		str.replace(2,4,"X");
		System.out.println(str);


	}

}
