package extra3;

public class Switch01 {

	public static void main(String[] args) {

		int a = Math.min(2, 4);
		int  count = 0;

		switch(a){

		case 5 % 3:
			count++;
		case 6 / 2:
			count += 3;
		case 1 * 8:
			count--;
		case 6:
			count *= 2;
		default:
			count /= 2;
		}
		System.out.println(count);
	}

}
