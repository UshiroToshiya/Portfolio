package extra3;

public class Reigai01 {

	public static void main(String[] args) {
		try{
			String[] array = {};
			System.out.println(array[0]);
		}catch(IndexOutOfBoundsException e){
			System.out.println("A");

		}finally {
			System.out.println("B");

		}

	}

}
