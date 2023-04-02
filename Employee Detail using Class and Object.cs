using System;
class employee {
	public int empid;
	public string empname;
	public double salary;
	public employee(int eid,string ename,double esalary) {
		empid = eid;
		empname = ename;
		salary = esalary;	
	}

	public void display() {
		Console.WriteLine("Employee ID : "+empid);
		Console.WriteLine("Employee Name : "+empname);
		Console.WriteLine("Employee Salary : "+salary);
	}
}
class employeedetail {
	public static void Main() {
		int id;
		string name;
		double sal;
		Console.WriteLine("Enter Employee ID : ");
		id = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Employee Name : ");
		name = Console.ReadLine();
		Console.WriteLine("Enter Employee Salary : ");
		sal = double.Parse(Console.ReadLine());	
		employee emp = new employee(id,name,sal);
		emp.display();
	}
}