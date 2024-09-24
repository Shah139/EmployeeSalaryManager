using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeeSalaryManager
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        // Override ToString to display employee info in ListBox
        public override string ToString()
        {
            return $"{Name} - Salary: {Salary:C}";
        }
    }

    public partial class Form1 : Form
    {
        // List to store employees
        private List<Employee> employees = new List<Employee>();

    
            public Form1()
            {
                InitializeComponent();

                // Hook up the event handler
                this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            }

            // Event handler for txtSalary TextChanged event
            private void txtSalary_TextChanged(object sender, EventArgs e)
            {
                                              // You can implement logic here that should execute when the text in the txtSalary TextBox changes.
                                              // For example, you could validate the salary input.
            if (!decimal.TryParse(txtSalary.Text, out decimal result))
                {
                    // Invalid salary format
                    MessageBox.Show("Please enter a valid salary.");
                }
            }

        

        // Add Employee Button Click Event
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                Employee newEmployee = new Employee(name, salary);
                employees.Add(newEmployee);
                UpdateEmployeeList();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please enter a valid salary.");
            }
        }

        // Update Salary Button Click Event
        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            if (lstEmployees.SelectedItem is Employee selectedEmployee)
            {
                if (decimal.TryParse(txtUpdateSalary.Text, out decimal newSalary))
                {
                    selectedEmployee.Salary = newSalary;
                    UpdateEmployeeList();
                }
                else
                {
                    MessageBox.Show("Please enter a valid salary.");
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to update.");
            }
        }

        // Method to refresh ListBox
        private void UpdateEmployeeList()
        {
            lstEmployees.Items.Clear();
            foreach (var employee in employees)
            {
                lstEmployees.Items.Add(employee);
            }
        }

        // Method to clear input fields
        private void ClearInputs()
        {
            txtName.Clear();
            txtSalary.Clear();
            txtUpdateSalary.Clear();
        }
    }
        
    

}

