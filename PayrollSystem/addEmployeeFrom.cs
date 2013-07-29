using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class addEmployeeFrom : Form
    {
        public addEmployeeFrom()
        {
            InitializeComponent();
        }

        private void addEmployeeFrom_Load(object sender, EventArgs e)
        {
            DataPopulator();
            txtuid.Visible = false;
        }

        private void DataPopulator()
        {
            Populator populator = new Populator();
            foreach (var b in populator.branch)
            {
                cbBranch.Items.Add("[" + b.BranchId + "]" + b.BranchName);
            }

            foreach (var d in populator.department)
            {
                cbDepartment.Items.Add("[" + d.DepartmentId + "]" + d.DepartmentName);
            }

            foreach (var p in populator.position)
            {
                cbPosition.Items.Add("[" + p.PositionId + "]" + p.PositionName);
            }

            foreach (var s in populator.salary)
            {
                cbSalary.Items.Add("[" + s.SalaryId + "]" + s.SalaryCode + "(" + s.SalaryAmount.ToString() + ")");
            }

            foreach (var et in populator.emType)
            {
                cbEmploymentType.Items.Add("[" + et.EmploymentTypeId + "]" + et.EmploymentName);
            }

            foreach (var s in populator.schedule)
            {
                cbSchedule.Items.Add("[" + s.ScheduleId + "]" + s.ScheduleCode + "(" + s.TimeIn +" - " + s.TimeOut + ")");
            }


            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");

            cbCivilStatus.Items.Add("Single");
            cbCivilStatus.Items.Add("Married");
            cbCivilStatus.Items.Add("Widowed");

            List<Employee> emp = new List<Employee>();
            using (var myContext = new EmployeeContext())
            {
                var em = from s in myContext.Employees select s;
                foreach (var e in em)
                {
                    emp.Add(new Employee { UserId = e.UserId });
                }
            }

            string connectionString = @"user id=RUBEN-PC\jjruben;password=;server=RUBEN-PC\SQLEXPRESS1;Trusted_Connection=yes;database=ForZKSoftware;connection timeout=30";
            ZKDatabase zkdb = new ZKDatabase(connectionString);


            Additionals additionals = new Additionals();
            additionals.BindGrid(dataGridView1, zkdb.ToBeEnrollToPayroll(emp));
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            getSelectedUserId();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getSelectedUserId();
        }

        private void getSelectedUserId()
        {
            try
            {
                txtuid.Visible = true;
                txtuid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBranch.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbBranch.Focus();
                }
                else if (cbDepartment.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbDepartment.Focus();

                }
                else if (cbPosition.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbPosition.Focus();
                }
                else if (cbSalary.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbSalary.Focus();
                }
                else if (cbEmploymentType.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbEmploymentType.Focus();
                }
                else if (cbSchedule.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbSchedule.Focus();
                }
                else if (txtuid.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtuid.Focus();
                }
                else if (txtFName.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFName.Focus();
                }
                else if (txtLName.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLName.Focus();
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAddress.Focus();
                }
                else if (dtDate.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtDate.Focus();
                }
                else if (txtMobile.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMobile.Focus();
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                }
                else if (txtPagibig.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPagibig.Focus();
                }
                else if (txtdpendent.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtdpendent.Focus();
                }
                else if (txtSss.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSss.Focus();
                }
                else if (txtTin.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTin.Focus();
                }
                else if (cbCivilStatus.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbCivilStatus.Focus();
                }
                else if (cbGender.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbGender.Focus();
                }
                else if (txtPhilhealth.Text == "")
                {
                    MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPhilhealth.Focus();
                }
                else
                {


                    int branchId = int.Parse(cbBranch.Text.Substring(1, cbBranch.Text.IndexOf("]") - 1));
                    int departmentId = int.Parse(cbDepartment.Text.Substring(1, cbDepartment.Text.IndexOf("]") - 1));
                    int positionId = int.Parse(cbPosition.Text.Substring(1, cbPosition.Text.IndexOf("]") - 1));
                    int salaryId = int.Parse(cbSalary.Text.Substring(1, cbSalary.Text.IndexOf("]") - 1));
                    int employmentId = int.Parse(cbEmploymentType.Text.Substring(1, cbEmploymentType.Text.IndexOf("]") - 1));
                    int scheduleId = int.Parse(cbSchedule.Text.Substring(1, cbSchedule.Text.IndexOf("]") - 1));
                    int employeeId;
                    if (Dummy.employee.Count < 1)
                    {
                        employeeId = 1;
                    }
                    else
                    {
                        employeeId = Dummy.employee.Count;
                    }
                    using (var myContext = new EmployeeContext())
                    {
                        var employee = new Employee
                        {
                            UserId = int.Parse(txtuid.Text),
                            FirstName = txtFName.Text,
                            LastName = txtLName.Text,
                            Address = txtAddress.Text,
                            BirthDate = dtDate.Value.Date,
                            Contact = txtMobile.Text,
                            Email = txtEmail.Text,
                            Pagibig = txtPagibig.Text,
                            NoDependnt = txtdpendent.Text,
                            SSS = txtSss.Text,
                            Tin = txtTin.Text,
                            BranchId = branchId,
                            DepartmentId = departmentId,
                            PositionId = positionId,
                            EmploymentTypeId = employmentId,
                            ScheduleId = scheduleId,
                            SalaryId = salaryId,
                            CivilStatus = cbCivilStatus.Text,
                            Gender = cbGender.Text,
                            PhilHealth = txtPhilhealth.Text
                        };
                        myContext.Employees.Add(employee);
                        myContext.SaveChanges();


                        MessageBox.Show("Employee has been registered.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtuid.Visible = false;
                        txtFName.Clear();
                        txtLName.Clear();
                        txtAddress.Clear();
                        txtMobile.Clear();
                        txtEmail.Clear();
                        txtPagibig.Clear();
                        txtdpendent.Clear();
                        txtSss.Clear();
                        txtTin.Clear();


                    }
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Edit")
            {

                button1.Text = "Update";

            }
            else
            {
                try
                {
                    if (cbBranch.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbBranch.Focus();
                    }
                    else if (cbDepartment.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbDepartment.Focus();

                    }
                    else if (cbPosition.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbPosition.Focus();
                    }
                    else if (cbSalary.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbSalary.Focus();
                    }
                    else if (cbEmploymentType.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbEmploymentType.Focus();
                    }
                    else if (cbSchedule.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbSchedule.Focus();
                    }
                    else if (txtuid.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtuid.Focus();
                    }
                    else if (txtFName.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtFName.Focus();
                    }
                    else if (txtLName.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLName.Focus();
                    }
                    else if (txtAddress.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtAddress.Focus();
                    }
                    else if (dtDate.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dtDate.Focus();
                    }
                    else if (txtMobile.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMobile.Focus();
                    }
                    else if (txtEmail.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtEmail.Focus();
                    }
                    else if (txtPagibig.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPagibig.Focus();
                    }
                    else if (txtdpendent.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtdpendent.Focus();
                    }
                    else if (txtSss.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtSss.Focus();
                    }
                    else if (txtTin.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtTin.Focus();
                    }
                    else if (cbCivilStatus.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbCivilStatus.Focus();
                    }
                    else if (cbGender.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbGender.Focus();
                    }
                    else if (txtPhilhealth.Text == "")
                    {
                        MessageBox.Show("Make sure you fill-up all fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPhilhealth.Focus();
                    }
                    else
                    {


                        int branchId = int.Parse(cbBranch.Text.Substring(1, cbBranch.Text.IndexOf("]") - 1));
                        int departmentId = int.Parse(cbDepartment.Text.Substring(1, cbDepartment.Text.IndexOf("]") - 1));
                        int positionId = int.Parse(cbPosition.Text.Substring(1, cbPosition.Text.IndexOf("]") - 1));
                        int salaryId = int.Parse(cbSalary.Text.Substring(1, cbSalary.Text.IndexOf("]") - 1));
                        int employmentId = int.Parse(cbEmploymentType.Text.Substring(1, cbEmploymentType.Text.IndexOf("]") - 1));
                        int scheduleId = int.Parse(cbSchedule.Text.Substring(1, cbSchedule.Text.IndexOf("]") - 1));
                        int employeeId;
                        if (Dummy.employee.Count < 1)
                        {
                            employeeId = 1;
                        }
                        else
                        {
                            employeeId = Dummy.employee.Count;
                        }
                        using (var myContext = new EmployeeContext())
                        {
                             var c = (from s in myContext.Employees where s.EmployeeId == int.Parse(txtuid.Text) select s).First();
 
                                c.UserId = int.Parse(txtuid.Text);
                                c.FirstName = txtFName.Text;
                                c.LastName = txtLName.Text;
                                c.Address = txtAddress.Text;
                                c.BirthDate = dtDate.Value.Date;
                                c.Contact = txtMobile.Text;
                                c.Email = txtEmail.Text;
                                c.Pagibig = txtPagibig.Text;
                                c.NoDependnt = txtdpendent.Text;
                                c.SSS = txtSss.Text;
                                c.Tin = txtTin.Text;
                                c.BranchId = branchId;
                                c.DepartmentId = departmentId;
                                c.PositionId = positionId;
                                c.EmploymentTypeId = employmentId;
                                c.ScheduleId = scheduleId;
                                c.SalaryId = salaryId;
                                c.CivilStatus = cbCivilStatus.Text;
                                c.Gender = cbGender.Text;
                                c.PhilHealth = txtPhilhealth.Text;

                            myContext.SaveChanges();
                            };
            
                            
                    

                            MessageBox.Show("Employee's information has been updated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtuid.Visible = false;
                            txtFName.Clear();
                            txtLName.Clear();
                            txtAddress.Clear();
                            txtMobile.Clear();
                            txtEmail.Clear();
                            txtPagibig.Clear();
                            txtdpendent.Clear();
                            txtSss.Clear();
                            txtTin.Clear();


                        }
                    }
                
                catch { }
 
            }
        }

       
    }
}
