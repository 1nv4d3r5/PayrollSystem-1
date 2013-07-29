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
    public partial class addSalaryForm : Form
    {
        
        Properties.Settings settings = new Properties.Settings();


        public addSalaryForm()
        {
            InitializeComponent();
        }


        private void LinkdgSalary()
        {
            try
            {
                string connectionstring = @"user id=" + settings.userid + ";password=" + settings.password + ";server=" + settings.server + ";Trusted_Connection=yes;database=" + settings.database + ";connection timeout=30";

                using (var myContext = new EmployeeContext())
                {
                    var st = from s in myContext.Salaries select s;
                    {

                        dataGridView1.DataSource = st.ToList();
                        dataGridView1.ReadOnly = true;
                        dataGridView1.Enabled = true;
                        dataGridView1.Refresh();


                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Code";
                        dataGridView1.Columns[2].HeaderText = "Amount";



                        dataGridView1.Columns[0].Width = 100;
                        dataGridView1.Columns[1].Width = 163;



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
                    textBox2.Enabled = true;

                    button1.Enabled = false;
                    dataGridView1.Enabled = false;

                    dataGridView1.ClearSelection();

                    textBox1.Clear();
                    textBox1.Focus();


                    textBox2.Clear();

                    btnAdd.Text = "Save";
                    button1.Text = "Edit";
                }
                else
                {
                    try
                    {
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Enter New Salary Code.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Focus();
                        }
                        else if (textBox2.Text == "")
                        {
                            MessageBox.Show("Enter New Salary Amount.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox2.Focus();
                        }
                        else
                        {
                            string connectionstring = @"user id=" + settings.userid + ";password=" + settings.password + ";server=" + settings.server + ";Trusted_Connection=yes;database=" + settings.database + ";connection timeout=30";


                            using (var myContext = new EmployeeContext())
                            {
                                if (myContext.Salaries.Any(o => o.SalaryCode == textBox1.Text))
                                {
                                    MessageBox.Show("Salary Code is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBox1.Clear();

                                }
                                else
                                {
                                    var salary = new Salary
                                    {
                                        SalaryCode = textBox1.Text,
                                        SalaryAmount = double.Parse(textBox2.Text)
                                    };
                                    myContext.Salaries.Add(salary);
                                    myContext.SaveChanges();

                                    //MessageBox.Show("Added Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LinkdgSalary();

                                    textBox1.Clear();
                                    textBox2.Clear();
                                    dataGridView1.ClearSelection();

                                    dataGridView1.Enabled = true;
                                    btnAdd.Enabled = true;

                                    textBox1.Enabled = false;
                                    textBox2.Enabled = false;
                                    button1.Enabled = false;

                                    btnAdd.Text = "Add";
                                    button1.Text = "Edit";
                                }
                            }
                        }
                    }
                    catch { }
                }
            }
            catch { }
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
                    textBox2.Enabled = true;

                }
                else
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Enter Salary Code.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                    }
                    else if (textBox2.Text == "")
                    {
                        MessageBox.Show("Enter Salary Rate.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox2.Focus();
                    }
                    else
                    {
                        try
                        {
                            string connectionstring = @"user id=" + settings.userid + ";password=" + settings.password + ";server=" + settings.server + ";Trusted_Connection=yes;database=" + settings.database + ";connection timeout=30";


                            using (var myContext = new EmployeeContext())
                            {
                                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                                var c = (from s in myContext.Salaries where s.SalaryId == id select s).First();

                                if (myContext.Salaries.Any(o => o.SalaryCode == textBox1.Text && textBox1.Text != c.SalaryCode))
                                {
                                    MessageBox.Show("Code Already Exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBox1.Clear();
                                    textBox1.Focus();
                                }
                                else
                                {
                                    c.SalaryCode = textBox1.Text;
                                    c.SalaryAmount = double.Parse(textBox2.Text);
                                    myContext.SaveChanges();


                                    LinkdgSalary();

                                    textBox1.Clear();
                                    textBox2.Clear();
                                    dataGridView1.ClearSelection();

                                    dataGridView1.Enabled = true;
                                    btnAdd.Enabled = true;

                                    textBox1.Enabled = false;
                                    textBox2.Enabled = false;
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

        private void addSalaryForm_Load(object sender, EventArgs e)
        {
            LinkdgSalary();

            textBox1.Clear();
            textBox2.Clear();
            dataGridView1.ClearSelection();

            textBox1.Enabled=false;
            textBox2.Enabled=false;
            button1.Enabled=false;

            btnAdd.Enabled = true;
            dataGridView1.Enabled = true;

            btnAdd.Text = "Add";
            button1.Text = "Edit";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                button1.Enabled = true;


            }
            catch
            {
            }
        }

       
    }
}
