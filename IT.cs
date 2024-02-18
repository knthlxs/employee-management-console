using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem {
    internal class IT : Employee {
        string specialization;

        public IT(string ID, string name, int age, string department, double salary, string specialization) : base(ID, name, age, department, salary) {
            this.specialization = specialization;
        }

        public override void displayEmployee() {
            base.displayEmployee();
            Console.WriteLine($"Specialization: {specialization}");
        }
    }
}
