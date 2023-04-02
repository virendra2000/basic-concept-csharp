using System;
class armstrong {
	public static int pow(int x,int y) {
		int i,z=1;
		for(i=1;i<=y;i++) {
			z = z * x;
		}
		return z;
	}
	public static void Main() {
		int rem,number;
		int res = 0;
		int num,count=0;
		Console.WriteLine("Enter Number to find Armstrong : \n");
		number = int.Parse(Console.ReadLine());
		num=number;
		int temp=number;
		while(num!=0) {
			num/=10;
			count++;
		}
		while(number!=0) {
			rem = number%10;
			res = res + pow(rem,count);
			number = number / 10;
		}
		if(res==temp) {
			Console.WriteLine(temp+" is an Armstrong Number");
		}
		else {
			Console.WriteLine(temp+" is not an Armstrong Number");
		}
	}
}