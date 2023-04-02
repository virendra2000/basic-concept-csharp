using System;
class exp1 {
	public static void Main() {
		double pi = 3.14;
		int ch;
		Console.WriteLine("1. Area of Triangle\n 2. Area of Circle\n 3. Area of Rectangle\n");
		Console.WriteLine("Enter your Choice : ");
		ch = int.Parse(Console.ReadLine());
		switch(ch) {
			case 1: Console.WriteLine("Enter the value of Base and Height : ");
				  double b = Double.Parse(Console.ReadLine());
				  double h = Double.Parse(Console.ReadLine());
				  double aot = b * h;
				  Console.WriteLine("Area of Triangle : "+aot);
				  break;
			case 2: Console.WriteLine("Enter the Radius : ");
				 double r = Double.Parse(Console.ReadLine());
				 double aoc = pi * r * r;
				 Console.WriteLine("Area of Circle : "+aoc);
				 break;
			case 3: Console.WriteLine("Enter the Value of Length and Breadth : ");
				 double length = Double.Parse(Console.ReadLine());
				 double breadth = Double.Parse(Console.ReadLine());
				 double aor = length * breadth;
				 Console.WriteLine("Area of Rectangle : "+aor);
				 break;
			default: Console.WriteLine("Wrong Input");
				 break;
		}
	}
}