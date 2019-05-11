using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSectionExam
{
    class Employee
    {
        int employeeId;
        string firstName;
        string lastName;
        DateTime hireDate;
        string jobDescription;
        string departmentName;
        decimal salary;

        public Employee(int CEmployeeId, string CFirstName, string CLastName)
        {
            EmployeeId = CEmployeeId;
            FirstName = CFirstName;
            LastName = CLastName;
        }

        public int EmployeeId
        {
            get
            { return employeeId; }
            set
            { employeeId = value; }
        }

        public string FirstName
        {
            get
            { return firstName; }
            set
            { firstName = value; }
        }

        public string LastName
        {
            get
            { return lastName; }
            set
            { lastName = value; }
        }

        public string FirstName_LastName_Method(string FirstName, string LastName)
        {

            Console.WriteLine("{0} {1}", FirstName, LastName);
            return firstName;


        }
        public string LastName_FirstName_Method(string FirstName, string LastName)
        {

            Console.WriteLine("{1}, {0}", FirstName, LastName);
            return firstName;

        }
    }
}
