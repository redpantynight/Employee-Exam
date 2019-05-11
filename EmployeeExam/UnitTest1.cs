using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//Objective of the exam:
//1. Create an Employee class and store the following in the appripriate data types: employee Id, first name, last name,
//date of hire, job description, department and monthly salary.
//2. Include appropriate constructors and properties.
//3. Create two methods: 1) Returns the first name + last name 2) Returns the last name + "," + first name.
//BONUS: Write a test that checks if the methods return the correct values.


namespace EmployeeSectionExam
{
    [TestClass]
    public class EmployeeSectionExam
    {
        [TestMethod]
        public void FirstAndLast()
        {
            Employee emp = new Employee(10, "Andy", "Hajrovic");
            string fullname = emp.FirstName_LastName_Method(emp.FirstName, emp.LastName);

            StringAssert.Equals(fullname, "Andy Hajrovic");
        }

        [TestMethod]
        public void LastAndFirst()
        {
            Employee emp = new Employee(10, "Andy", "Hajrovic");
            emp.LastName_FirstName_Method(emp.FirstName, emp.LastName);

            StringAssert.Equals(emp.FirstName, "Andy Hajrovic");
        }
    }
}
