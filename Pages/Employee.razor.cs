using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FirstBlazorApp.Models;
// using System.Collections.nume
namespace FirstBlazorApp.Pages{
    public partial class EmployeePage{
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees(){
            Employee e1 = new Employee{
                EmployeeId = 1,
                FirstName = "Dito",
                LastName = "Adriel",
                Email = "Ditoadriel@gmail.com",
                DateOfBirth = new DateTime(1999,09,09),
                Gender = Gender.Male,
                Department = new Department{DepartmentId = 1, DepartmentName= "IT"},
                PhotoPath = "images/dito.jpg"

            };
            Employee e2 = new Employee{
                EmployeeId = 2,
                FirstName = "yeyen",
                LastName = "kezia",
                Email = "yeyen@gmail.com",
                DateOfBirth = new DateTime(1999,09,09),
                Gender = Gender.Male,
                Department = new Department{DepartmentId = 2, DepartmentName= "FINANCE"},
                PhotoPath = "images/yeyen.jpg"

            };
            Employee e3 = new Employee{
                EmployeeId = 3,
                FirstName = "will",
                LastName = "fridus",
                Email = "will@gmail.com",
                DateOfBirth = new DateTime(1999,09,09),
                Gender = Gender.Male,
                Department = new Department{DepartmentId = 3, DepartmentName= "MUSIK"},
                PhotoPath = "images/will.jpg"

            };
            Employee e4 = new Employee{
                EmployeeId = 4,
                FirstName = "supra",
                LastName = "asik",
                Email = "supra@gmail.com",
                DateOfBirth = new DateTime(9090,09,09),
                Gender = Gender.Male,
                Department = new Department{DepartmentId = 4, DepartmentName= "HRD"},
                PhotoPath = "images/supra.jpg"

            };
            Employees = new List<Employee>{e1,e2,e3,e4};
        }
    }
}