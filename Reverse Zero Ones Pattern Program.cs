using System;
class forloopexp {
	public static void Main() {
		int i,j;
		for(i=1;i<=5;i++) {
			for(j=i;j>=1;j--) {
				Console.Write("\t"+j%2);
			}
			Console.WriteLine(" ");
		}
	}
}