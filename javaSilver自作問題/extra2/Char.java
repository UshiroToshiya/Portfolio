package extra2;

public class Char {

	public static void main(String[] args) {
		char ch = '0';
		int i = (int) ch;
		if(Character.isDigit(i)){
			System.out.println("A");
		}else{
			System.out.println("B");
		}
		
		if(Character.isAlphabetic(i)){
			System.out.println("C");
		} else {
			System.out.println("D");
		}

	}

}
