using System;
using System.Windows.Forms;

namespace EmployeeDirectoryManager
{
    public partial class MainForm : Form
    {
        private EmployeeManager manager = new EmployeeManager();

        public MainForm()
        {
            InitializeComponent();

            // Bind DataGridView
            dataGridViewEmployees.DataSource = manager.Employees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = new Employee(
                    txtId.Text,
                    txtName.Text,
                    txtDepartment.Text,
                    txtRole.Text,
                    double.Parse(txtSalary.Text),
                    dtpHireDate.Value
                );

                manager.AddEmployee(emp);
                lblStatus.Text = "Employee added successfully.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblStatus.Text = "Error adding employee.";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = new Employee(
                    txtId.Text,
                    txtName.Text,
                    txtDepartment.Text,
                    txtRole.Text,
                    double.Parse(txtSalary.Text),
                    dtpHireDate.Value
                );

                manager.UpdateEmployee(emp);
                lblStatus.Text = "Employee updated.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblStatus.Text = "Update failed.";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool removed = manager.RemoveEmployee(txtId.Text);

            if (removed)
            {
                lblStatus.Text = "Employee deleted.";
            }
            else
            {
                MessageBox.Show("Employee not found.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                manager.SaveToCsv("employees.csv");
                lblStatus.Text = "Data saved.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblStatus.Text = "Save failed.";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                manager.LoadFromCsv("employees.csv");
                lblStatus.Text = "Employees loaded.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblStatus.Text = "Load failed.";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}