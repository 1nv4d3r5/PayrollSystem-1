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
    public partial class addDepartmentForm : Form
    {

        Properties.Settings settings = new Properties.Settings();


        public addDepartmentForm()
        {
            InitializeComponent();
        }


        private void LinkdgDepartment()
        {
            try
            {
                string connectionstring = @"user id=" + settings.userid + ";password=" + settings.password + ";server=" + settings.server + ";Trusted_Connection=yes;database=" + settings.database + ";connection timeout=30";

                using (var myContext = new EmployeeContext())
                {
                    var st = from s in myContext.Departments select s;
                    {

                        dataGridView1.DataSource = st.ToList();
                        dataGridView1.ReadOnly = true;
                        dataGridView1.Enabled = true;
                        dataGridView1.Refresh();


                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Department";


                      
                        dataGridView1.Columns[1].Width = 243;
                        dataGridView1.Columns[0].Width = 120;


                    }
                }
            }
            catch
            { }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdd.Text == "Add")
                {
                    textBox1.Enabled = true;

                    button1.Enabled = false;
                    dataGridView1.Enabled = false;

                    dataGridView1.ClearSelection();

                    textBox1.Clear();
                    textBox1.Focus();

                    btnAdd.Text = "Save";
                    button1.Text = "Edit";
                }
                else
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Enter New Department.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                    }
                    else
                    {
                        string connectionstring = @"user id=" + settings.userid + ";password=" + settings.password + ";server=" + settings.server + ";Trusted_Connection=yes;database=" + settings.database + ";connection timeout=30";

                        try
                        {
                            using (var myContext = new EmployeeContext())
                            {

                                if (myContext.Departments.Any(o => o.DepartmentName == textBox1.Text))
                                {
                                    MessageBox.Show("Department is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBox1.Clear();

                                }
                                else
                                {
                                    var department = new Department
                                    {
                                        DepartmentName = textBox1.Text
                                    };

                                    myContext.Departments.Add(department);
                                    myContext.SaveChanges();

                                  //  MessageBox.Show("Added Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                    LinkdgDepartment();

                                    textBox1.Clear();
                                    dataGridView1.ClearSelection();

                                    dataGridView1.Enabled = true;
                                    btnAdd.Enabled = true;

                                    textBox1.Enabled = false;
                                    button1.Enabled = false;

                                    btnAdd.Text = "Add";
                                    button1.Text = "Edit";
                                }
                            }
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }

        private void addDepartmentForm_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.ClearSelection();

            dataGridView1.Enabled = true;
            btnAdd.Enabled = true;

            textBox1.Enabled = false;
            button1.Enabled = false;

            btnAdd.Text = "Add";
            button1.Text = "Edit";

            LinkdgDepartment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "Edit")
                {
                    dataGridView1.Enabled = false;
                    btnAdd.Enabled = false;

                    button1.Text = "Update";
                    btnAdd.Text = "Add";

                    textBox1.Enabled = true;
                }
                else
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Enter Department Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                    }
                    else
                    {
                        string connectionstring = @"user id=" + settings.userid + ";password=" + settings.password + ";server=" + settings.server + ";Trusted_Connection=yes;database=" + settings.database + ";connection timeout=30";

                        try
                        {
                            using (var myContext = new EmployeeContext())
                            {
                               

                                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                                var c = (from s in myContext.Departments where s.DepartmentId == id select s).First();
                              
                                if (myContext.Departments.Any(o => o.DepartmentName == textBox1.Text && textBox1.Text != c.DepartmentName))
                                {
                                    MessageBox.Show("Department Already Exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBox1.Clear();
                                    textBox1.Focus();
                                }
                                else
                                {
                                    try
                                    {
                                        c.DepartmentName = textBox1.Text;
                                        myContext.SaveChanges();

                                        LinkdgDepartment();

                                        textBox1.Clear();
                                        dataGridView1.ClearSelection();

                                        dataGridView1.Enabled = true;
                                        btnAdd.Enabled = true;

                                        textBox1.Enabled = false;
                                        button1.Enabled = false;

                                        btnAdd.Text = "Add";
                                        button1.Text = "Edit";
                                    }
                                    catch { }
                                }
                            }

                        }
                        catch { }
                    }
                }
            }
            catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                button1.Enabled = true;
               

            }
            catch
            {
            }
        }



    }
}

