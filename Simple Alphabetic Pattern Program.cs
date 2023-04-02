using System;
class forloopexp {
	public static void Main() {
		int i,j;
		for(i=65;i<=65+4;i++) {
			for(j=65;j<=i;j++) {
				Console.Write((char)j);
			}
			Console.WriteLine(" ");
		}
	}
}