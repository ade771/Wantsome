using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TemaParcursTutorialASP.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }



        public static List<Employee> employeeList = new List<Employee>{
                new Employee() {EmployeeId = 1, EmployeeName = "John", Age = 18 } ,
                new Employee() {EmployeeId = 2, EmployeeName = "Steve", Age = 21 } ,
                new Employee() {EmployeeId = 3, EmployeeName = "Bill",  Age = 25 } ,
                new Employee() {EmployeeId = 4, EmployeeName = "Ram" , Age = 20 } ,
                new Employee() {EmployeeId = 5, EmployeeName = "Ron" , Age = 31 } ,
                new Employee() {EmployeeId = 6, EmployeeName = "Chris", Age = 17 } ,
                new Employee() {EmployeeId = 7, EmployeeName = "Rob" , Age = 19 }
            };

        public List<Employee> GetAll()
        {
            return employeeList;
        }

        public Employee GetById(int id)
        {
            return employeeList.FirstOrDefault(x => x.EmployeeId == id);
        }

        public void Add(Employee employee)
        {
            employee.EmployeeId = GetMaxId();

            employeeList.Add(employee);
        }

        private int GetMaxId()
        {
            return employeeList.Count + 1;
        }

    }
}
