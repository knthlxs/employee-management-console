using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem {
    internal class Employee {
        private string ID;
        public string name, department;
        public int age;
        private double salary;

        public Employee(string ID, string name, int age, string department, double salary) {
            this.ID = ID;
            this.name = name;
            this.age = age;
            this.department = department;
            this.salary = salary;
        }

        public virtual void displayEmployee() {
            Console.WriteLine($"ID: {ID}\nName: {name}\nAge: {age}\nDepartment: {department}\nSalary: {salary}");
        }
    }
}
