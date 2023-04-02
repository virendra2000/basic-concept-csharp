using System;
class palindromenum {
	public static void Main() {
		int rem,number;
		int res = 0;
		Console.WriteLine("Enter Number to find Palindrome : \n");
		number = int.Parse(Console.ReadLine());
		int temp=number;
		while(number!=0) {
			rem = number%10;
			res = res * 10 + rem;
			number = number / 10;
		}
		if(res==temp) {
			Console.WriteLine(temp+" is an Palindrome Number");
		}
		else {
			Console.WriteLine(temp+" is not an Palindrome Number");
		}
	}
}