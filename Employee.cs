using System;
using System.Globalization;
//main setup for table data//
namespace EmployeeDirectoryManager
{
    public sealed class Employee
    {
        public string Id { get; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string id, string fullName, string department, string role, double salary, DateTime hireDate)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Employee ID is required.");

            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Full name is required.");

            if (string.IsNullOrWhiteSpace(department))
                throw new ArgumentException("Department is required.");

            if (string.IsNullOrWhiteSpace(role))
                throw new ArgumentException("Role is required.");

            if (salary < 0)
                throw new ArgumentException("Salary must be ≥ 0.");

            if (hireDate > DateTime.Today)
                throw new ArgumentException("Hire date cannot be in the future.");

            Id = id;
            FullName = fullName;
            Department = department;
            Role = role;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToString()
            => $"{Id} | {FullName} | {Department} | {Role} | {Salary:C0} | {HireDate:yyyy-MM-dd}";

        public string ToCsv()
        {
            return string.Join(",",
                Id,
                FullName,
                Department,
                Role,
                Salary.ToString(CultureInfo.InvariantCulture),
                HireDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
            );
        }

        public static Employee FromCsv(string csvLine)
        {
            var cols = csvLine.Split(',');

            if (cols.Length != 6)
                throw new FormatException("Invalid CSV format.");

            string id = cols[0];
            string fullName = cols[1];
            string department = cols[2];
            string role = cols[3];
            double salary = double.Parse(cols[4], CultureInfo.InvariantCulture);
            DateTime hire = DateTime.Parse(cols[5]);

            return new Employee(id, fullName, department, role, salary, hire);
        }
    }
}