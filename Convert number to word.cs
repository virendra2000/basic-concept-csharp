using System;
class numtoword {
	public static string ConvertNumbertoWords(int number)
{
if (number == 0)
return "ZERO";
if (number < 0)
return "minus " + ConvertNumbertoWords(Math.Abs(number));
string words = "";
if ((number / 1000000) > 0)
{
words += ConvertNumbertoWords(number / 1000000) + " MILLION ";
number %= 1000000;
}
if ((number / 1000) > 0)
{
words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
number %= 1000;
}
if ((number / 100) > 0)
{
words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
number %= 100;
}
if (number > 0)
{
if (words != "")
words += "AND ";
var unitsMap = new[] { "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN" };
var tensMap = new[] { "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };

if (number < 20)
words += unitsMap[number];
else
{
words += tensMap[number / 10];
if ((number % 10) > 0)
words += " " + unitsMap[number % 10];
}
}
return words;
}
	public static void Main() {
		int num;
		Console.WriteLine("Enter a Amount : ");
		num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Number In Words : "+ConvertNumbertoWords(num)+" Rupees Only");
	}
}