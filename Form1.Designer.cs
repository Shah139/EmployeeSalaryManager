namespace EmployeeSalaryManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.txtUpdateSalary = new System.Windows.Forms.TextBox();
            this.btnUpdateSalary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100,20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(299, 137);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 1;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(542, 137);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(100, 23);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // lstEmployees
            // 
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.Location = new System.Drawing.Point(299, 231);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(120, 95);
            this.lstEmployees.TabIndex = 3;
            // 
            // txtUpdateSalary
            // 
            this.txtUpdateSalary.Location = new System.Drawing.Point(299, 181);
            this.txtUpdateSalary.Name = "txtUpdateSalary";
            this.txtUpdateSalary.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateSalary.TabIndex = 4;
            // 
            // btnUpdateSalary
            // 
            this.btnUpdateSalary.Location = new System.Drawing.Point(542, 181);
            this.btnUpdateSalary.Name = "btnUpdateSalary";
            this.btnUpdateSalary.Size = new System.Drawing.Size(92, 24);
            this.btnUpdateSalary.TabIndex = 5;
            this.btnUpdateSalary.Text = "Update Salary";
            this.btnUpdateSalary.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateSalary);
            this.Controls.Add(this.txtUpdateSalary);
            this.Controls.Add(this.lstEmployees);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.TextBox txtUpdateSalary;
        private System.Windows.Forms.Button btnUpdateSalary;
    }
}

