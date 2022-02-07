package extra2;

public class Error {

	public static void main(String[] args) {
		String answer = sample();
		System.out.println(answer);

	}
	public static String sample(){
		try{
			String name = null;
			if(name.isEmpty())
				System.out.println("Enpty");
			else
				System.out.println(name);


		}catch(NullPointerException n){
			return "D";
		}catch(RuntimeException r){
			System.out.println("A");
		}finally {
			System.out.println("B");
		}

		return "C";
	}

}