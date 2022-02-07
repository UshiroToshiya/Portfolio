package extra2;

import java.time.LocalDate;

public class Time01 {

	public static void main(String[] args) {
		LocalDate t = LocalDate.now();
		LocalDate p = LocalDate.of(0, 2, 1);

		int a = p.getDayOfMonth() - t.getDayOfMonth();

		System.out.println(a);

	}

}
