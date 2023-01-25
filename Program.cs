using Object_oriented__program_which_print_out_employee_details;

class Program
{
    static void Main(string[] args)
    {
        Employee person1 = new Employee("PETRUS", "SHAI", "MALE", 1999 / 09 / 13, "SOUTH AFRICAN", "CEO", 24);
        Employee person2 = new Employee("PRECIOUS", "MPURU", "FEMALE", 2000 / 02 / 25, "SOUTH AFRICAN", "COO", 23);
        Employee person3 = new Employee("THULI", "BALOYI", "FEMALE", 1999 / 10 / 21, "SOUTH AFRICAN", "SUPERVISOR", 24);
        Employee person4 = new Employee("MALESELA", "LETSOALO", "MALE", 1994 / 09 / 07, "SOUTH AFRICAN", "MANAGER", 30);

        Console.WriteLine(person1.Name + " "+ person1.Surname+" " +person1.Gender+" "+ person1.Dateofbirth+" "+ person1.Nationality+" "+ person1.Position+" "+ person1.Age);
        Console.WriteLine(person2.Name + " " + person2.Surname + " " + person2.Gender + " " + person2.Dateofbirth + " " + person2.Nationality + " " + person2.Position + " "+ person2.Age);
        Console.WriteLine(person3.Name + " " + person3.Surname + " " + person3.Gender + " " + person3.Dateofbirth + " " + person3.Nationality + " " + person3.Position + " "+ person3.Age);
        Console.WriteLine(person4.Name + " " + person4.Surname + " " + person4.Gender + " " + person4.Dateofbirth + " " + person4.Nationality + " " + person4.Position + " "+ person4.Age);
    }
}
    
