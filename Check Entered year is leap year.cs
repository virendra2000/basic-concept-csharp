using System;
class exp2 {
	public static void Main() {
		int yr;
		Console.WriteLine("Enter Year : ");
		yr = int.Parse(Console.ReadLine());
		if(yr % 4 == 0) {
			Console.WriteLine(yr+" is an Leap Year");
		}
		else if(yr % 400 == 0) {
			Console.WriteLine(yr+" is an Leap Year");
		}
		else {
			Console.WriteLine(yr+" is not an Leap Year");
		}
	}
}