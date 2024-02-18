using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem {
    internal class Manager : Employee {
        double bonus;

       public Manager(string ID, string name, int age, string department, double salary, double bonus) : base(ID, name, age, department, salary) {
            this.bonus = bonus;
        }

        public override void displayEmployee() {
            base.displayEmployee();
            Console.WriteLine($"Bonus: {bonus}");
        }
    }
}
