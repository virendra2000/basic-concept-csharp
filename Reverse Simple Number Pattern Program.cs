using System;
class forloopexp {
	public static void Main() {
		int i,j;
		for(i=5;i>=1;i--) {
			for(j=1;j<=i;j++) {
				Console.Write(j);
			}
			Console.WriteLine(" ");
		}
	}
}