package extra;

public class Incliment02 {

	public static void main(String[] args) {
		int a = 10;
		do{
			if(a++ < 11){
				a++;
			}
			a++;
		}while(14 >= ++a);

		System.out.println(a);

	}

}
