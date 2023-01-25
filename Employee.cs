using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented__program_which_print_out_employee_details
{
    class Employee
    {
        public string Name;
        public string Surname;
        public string Gender;
        public string Nationality;
        public int Age;
        public string Position;

        public Employee(string name, string surname, string gender , string nationality, string position, int age) {
            Name = name;
            Surname = surname;
            Gender = gender;
            Nationality = nationality;
            Age = age;
            Position = position;



        }

    }
}
