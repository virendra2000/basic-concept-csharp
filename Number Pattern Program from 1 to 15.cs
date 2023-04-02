using System;
class forloopexp {
	public static void Main() {
		int i,j,t=1;
		for(i=1;i<=5;i++) {
			for(j=1;j<=i;j++) {
				Console.Write("\t"+t);
				t++;
			}
			Console.WriteLine(" ");
		}
	}
}