namespace EmployeeDirectoryManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DateTimePicker dtpHireDate;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();

            this.txtId.Location = new System.Drawing.Point(20, 20);
            this.txtId.PlaceholderText = "Employee ID";

            this.txtName.Location = new System.Drawing.Point(150, 20);
            this.txtName.PlaceholderText = "Full Name";

            this.txtDepartment.Location = new System.Drawing.Point(20, 60);
            this.txtDepartment.PlaceholderText = "Department";

            this.txtRole.Location = new System.Drawing.Point(150, 60);
            this.txtRole.PlaceholderText = "Role";

            this.txtSalary.Location = new System.Drawing.Point(20, 100);
            this.txtSalary.PlaceholderText = "Salary";

            this.dtpHireDate.Location = new System.Drawing.Point(150, 100);

            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(20, 140);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(100, 140);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(200, 140);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(300, 140);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnLoad.Text = "Load";
            this.btnLoad.Location = new System.Drawing.Point(380, 140);
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            this.btnExit.Text = "Exit";
            this.btnExit.Location = new System.Drawing.Point(460, 140);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.dataGridViewEmployees.Location = new System.Drawing.Point(20, 180);
            this.dataGridViewEmployees.Size = new System.Drawing.Size(600, 200);

            this.lblStatus.Location = new System.Drawing.Point(20, 390);
            this.lblStatus.Size = new System.Drawing.Size(500, 30);
            this.lblStatus.Text = "Status: Ready";

            this.ClientSize = new System.Drawing.Size(650, 430);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.dtpHireDate);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnExit);

            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.lblStatus);

            this.Text = "Employee Directory Manager";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
        }
    }
}