package extra;

public class Reigai {

	public static void main(String[] args) {

		try{
			String[] a = new String[]{};
		}catch(NullPointerException n){
			System.out.println("C");
		}catch(Exception e){
			System.out.println("B");
		}finally {
			System.out.println("A");
		}
	}

}
