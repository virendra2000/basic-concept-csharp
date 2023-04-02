using System;
public interface userdata {
	void display();
}
class student : userdata {
	public int id;
	public string name;
	public string course;
	public student(int sid,string sname,string scourse) {
		id = sid;
		name = sname;
		course = scourse;
	}
	public void display() {
		Console.WriteLine("Student ID : "+id);
		Console.WriteLine("Student Name : "+name);
		Console.WriteLine("Student Course : "+course);
	} 
}

class employee : userdata {
	public int id;
	public string name;
	public double salary;
	public employee(int empid,string empname,double empsal) {
		id = empid;
		name = empname;
		salary = empsal;
	}
	public void display() {
		Console.WriteLine("Employee ID : "+id);
		Console.WriteLine("Employee Name : "+name);
		Console.WriteLine("Employee Salary : "+salary);
	} 
}
class userdetail {
	public static void Main() {
		int uid;
		string uname,ucourse;
		double sal;
		Console.WriteLine("\t \t MAIN MENU \t \t");
		Console.WriteLine("1. Student Record");
		Console.WriteLine("2. Employee Record");
		Console.WriteLine("Enter your choice (1-2) : ");
		int ch = int.Parse(Console.ReadLine());
		switch(ch) {
			case 1: Console.WriteLine("\t \t STUDENT DETAIL\t \t\n\n");
				Console.WriteLine("Enter Student ID : ");
				uid = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter Student Name : ");
				uname = Console.ReadLine();
				Console.WriteLine("Enter Student Course : ");
				ucourse = Console.ReadLine();
				student s = new student(uid,uname,ucourse);
				s.display();
				break;
			case 2: Console.WriteLine("\t \t EMPLOYEE DETAIL\t \t\n\n");
				Console.WriteLine("Enter Employee ID : ");
				uid = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter Employee Name : ");
				uname = Console.ReadLine();
				Console.WriteLine("Enter Employee Salary : ");
				sal = int.Parse(Console.ReadLine());
				employee emp = new employee(uid,uname,sal);
				emp.display();
				break;
			default: Console.WriteLine("Fatal Error : Input Error ~ Incorrect Data Inputted");
				 break; 
		}
	}
}
