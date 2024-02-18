using System;

namespace EmployeeManagementSystem {
    internal class ManageEmployee {

        List<Employee> employees = new List<Employee>();
        static void Main(string[] args) {
            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.addEmployee();
        }

        public void addEmployee() {
            bool again = true;
            string[] employeeArray = { "Employee", "Manager", "IT" };
            string employeeChoice, ID, name, department, specialization;
            string addAgain;
            int age;
            double salary, bonus;

            while (again) {
                Console.Write("Choose the employee that you want to add\n- Employee\n- Manager\n- IT\n> ");
                employeeChoice = Console.ReadLine();

                Console.Write("ID: ");
                ID = Console.ReadLine();

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Age: ");
                age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Department: ");
                department = Console.ReadLine();

                Console.Write("Salary: ");
                salary = Convert.ToDouble(Console.ReadLine());

                if (employeeChoice.Equals(employeeArray[1])) {
                    Console.Write("Bonus: ");
                    bonus = Convert.ToDouble(Console.ReadLine());
                    employees.Add(new Manager(ID, name, age, department, salary, bonus));
                } else if (employeeChoice.Equals(employeeArray[2])) {
                    Console.Write("Specialization: ");
                    specialization = Console.ReadLine();
                    employees.Add(new IT(ID, name, age, department, salary, specialization));
                } else {
                    employees.Add(new Employee(ID, name, age, department, salary));
                }

                Console.Write("Do you want to add another employee? (Y/N): ");
                addAgain = Console.ReadLine().ToLower();

                if (addAgain.Equals("n")) {
                    displayAllEmployee();
                    again = false;
                }
            }
        }

        public void displayAllEmployee() {
            Console.WriteLine();
            foreach (Employee employee in employees) {
                if (employee is Manager) Console.WriteLine("POSITION: MANAGER");
                else if (employee is IT) Console.WriteLine("POSITION: IT");
                else Console.WriteLine("POSITION: EMPLOYEE");
                employee.displayEmployee();
                Console.WriteLine();
            }
        }
    }
}