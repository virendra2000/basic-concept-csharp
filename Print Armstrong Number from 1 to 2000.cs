using System;
class armstrong {
	public static int pow(int x,int y) {
		int i,z=1;
		for(i=1;i<=y;i=i+1) {
			z = z * x;
		}
		return z;
	}
	public static void Main() {
		for(int i=1;i<2000;i++) {
			int number = i;
			int rem;
			int res = 0;
			int num,count=0;
			int temp=number;
			num=number;
			while(number!=0) {
				number/=10;
				count++;
			}
			while(num!=0) {
				rem = num % 10;
				res = res + pow(rem,count);
				num = num/10;
			}
			if(res == temp) {
				Console.WriteLine(res);
			}
		}
	}
}