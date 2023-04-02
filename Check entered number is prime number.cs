using System;
class primenum {
	public static void Main() {
		int num;
		int i,count=0;
		Console.WriteLine("Enter Number to find Prime Number : \n");
		num = int.Parse(Console.ReadLine());
		for(i = 1; i <= num; i++) {
			if(num % i == 0) {
				count++;
			}
		}
		if(count == 2) {
			Console.WriteLine(num+" is a Prime Number");
		}
		else {
			Console.WriteLine(num+" is not a Prime Number");
		}
	}
}