using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace EmployeeDirectoryManager
{
    public sealed class EmployeeManager
    {
        public BindingList<Employee> Employees { get; } = new BindingList<Employee>();

        public void AddEmployee(Employee e)
        {
            if (Employees.Any(emp => emp.Id.Equals(e.Id, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("Employee ID already exists.");

            Employees.Add(e);
        }

        public void UpdateEmployee(Employee updated)
        {
            var existing = Employees.FirstOrDefault(emp =>
                emp.Id.Equals(updated.Id, StringComparison.OrdinalIgnoreCase));

            if (existing == null)
                throw new InvalidOperationException("Employee not found.");

            existing.FullName = updated.FullName;
            existing.Department = updated.Department;
            existing.Role = updated.Role;
            existing.Salary = updated.Salary;
            existing.HireDate = updated.HireDate;
        }

        public bool RemoveEmployee(string id)
        {
            var employee = Employees.FirstOrDefault(emp =>
                emp.Id.Equals(id, StringComparison.OrdinalIgnoreCase));

            if (employee == null)
                return false;

            Employees.Remove(employee);
            return true;
        }

        public void SaveToCsv(string path)
        {
            using var sw = new StreamWriter(path, false, new UTF8Encoding(false));
            sw.WriteLine("Id,FullName,Department,Role,Salary,HireDate");

            foreach (var e in Employees)
                sw.WriteLine(e.ToCsv());
        }

        public void LoadFromCsv(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("CSV file not found.");

            Employees.Clear();

            var lines = File.ReadAllLines(path);

            foreach (var line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var emp = Employee.FromCsv(line);

                if (Employees.Any(x => x.Id == emp.Id))
                    throw new InvalidOperationException($"Duplicate ID {emp.Id}");

                Employees.Add(emp);
            }
        }
    }
}