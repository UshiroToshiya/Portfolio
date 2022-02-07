package extra3;

public class Array01 {

	public static void main(String[] args) {
		int[][][] a = { {{1,9},{4,6},{8,2}} , {{5,5},{7,3}} };
		int[][][] b = a.clone();
		int total = 0;

		for(int[][] e : b){
			for(int[] c : e){
				for(int d : c){
					total += d;
				}
			}
		}
		System.out.println(total);
	}

}
