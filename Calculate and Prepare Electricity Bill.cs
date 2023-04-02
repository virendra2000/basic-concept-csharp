using System;
class billing {
	public static void Main() {
		string custname;
		float bill,billunit,units,billamount;
		Console.WriteLine("Enter Customer Name : ");
		custname = Console.ReadLine();
		Console.WriteLine("Enter your Billing Unit : ");
		int unit = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Customer Name : {0}",custname);
		Console.WriteLine("Customer Bill Unit : {0}",unit);
		if(unit>0&&unit<=100) {
			billamount = unit * 3;
			Console.WriteLine("Bill Amount : {0}",billamount);
		}
		else if(unit>100&&unit<=200) {
			units = 100 * 3;
			billunit = unit - 100;
			bill = billunit * 5;
			billamount = units + bill;
			Console.WriteLine("Bill Amount : {0}",billamount);
		}
		else if(unit>200&&unit<=300) {
			units = 100 * 3;
			float unit1 = 100 * 5;
			billunit = unit - 200;
			bill = billunit * 10;
			billamount = units + unit1 + bill;
			Console.WriteLine("Bill Amount : {0}",billamount);
		}
		else {
			Console.WriteLine("Wrong Input");
		}
		
	}
}