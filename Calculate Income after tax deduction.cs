using System;
class itsys {
	public static void Main() {
		double amount;
		float itr,basicamt;
		string custname;
		Console.WriteLine("Enter Customer : ");
		custname = Console.ReadLine();
		Console.WriteLine("Enter Customer Income : ");
		basicamt= Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Customer Name : {0}",custname);
		Console.WriteLine("Customer Basic Amount : {0}",basicamt);
		if(basicamt > 0 && basicamt <= 200000) {
			amount = basicamt;
			Console.WriteLine("Customer Income Amount : {0}",amount);
		}
		else if (basicamt > 200000 && basicamt <= 250000) {
			float amt = basicamt - 200000;
			itr = ((amt * 10)/100);
			amount = basicamt - itr;
			Console.WriteLine("ITR : {0}",itr);
			Console.WriteLine("Customer Income Amount : {0}",amount);
		}
		else if(basicamt > 250000 && basicamt <=300000) {
			float amt1 =(((250000 - 200000) * 10)/100);
			float amt = (((basicamt - 250000)*20)/100);
			itr = amt1 + amt;
			amount = basicamt - itr;
			Console.WriteLine("ITR : {0}",itr);
			Console.WriteLine("Customer Income Amount : {0}",amount);
		}
		else if(basicamt > 300000 && basicamt <=350000) {
			float amt = 250000 - 200000;
			float amt1 =((amt * 10)/100);
			float amt2 = ((amt *20)/100);
			float amt3 = (((basicamt - 300000) * 30)/100);
			itr = amt1 + amt2 + amt3;
			amount = basicamt - itr;
			Console.WriteLine("ITR : {0}",itr);
			Console.WriteLine("Customer Income Amount : {0}",amount);
		}
		else {
			Console.WriteLine("Wrong Input");
		}
	}
}