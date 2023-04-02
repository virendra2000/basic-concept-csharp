using System;
class fibonaccis {
	public static void Main() {
		int i;
		int a=0;
		int b=1;
		Console.WriteLine("Enter n number to find fibonacci series");
		int n = int.Parse(Console.ReadLine());
		Console.Write(a+" "+b);
		for(i = 0;i < n;i++) {
			int c = a + b;
			Console.Write(" "+c);
			a = b;
			b = c;
		}
	}
}