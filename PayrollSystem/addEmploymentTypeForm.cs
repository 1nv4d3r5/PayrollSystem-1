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
    public partial class addEmploymentTypeForm : Form
    {
        Properties.Settings settings = new Properties.Settings();


        public addEmploymentTypeForm()
        {
            InitializeComponent();
        }


        private void LinkdgEmployment()
        {
            try
            {
                string connectionstring = @"user id=" + settings.userid + ";password=" + settings.password + ";server=" + settings.server + ";Trusted_Connection=yes;database=" + settings.database + ";connection timeout=30";

                using (var myContext = new EmployeeContext())
                {
                    var st = from s in myContext.EmploymentTypes select s;
                    {

                        dataGridView1.DataSource = st.ToList();
                        dataGridView1.ReadOnly = true;
                        dataGridView1.Enabled = true;
                        dataGridView1.Refresh();


                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Type";


                        dataGridView1.Columns[0].Width = 143;
                        dataGridView1.Columns[1].Width = 225;



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
                    btnAdd.Text = "Save";
                    button1.Text = "Edit";

                    button1.Enabled = false;
                    dataGridView1.Enabled = false;

                    dataGridView1.ClearSelection();

                    textBox1.Clear();
                    textBox1.Focus();
                    textBox1.Enabled = true;



                }
                else
                {
                    try
                    {
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("Enter New Employment Type.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Focus();
                        }
                        else
                        {
                            try
                            {
                                using (var myContext = new EmployeeContext())
                                {
                                    if (myContext.EmploymentTypes.Any(o => o.EmploymentName == textBox1.Text))
                                    {
                                        MessageBox.Show("Employment Type is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        textBox1.Clear();

                                    }
                                    else
                                    {
                                        var empType = new EmploymentType
                                        {
                                            EmploymentName = textBox1.Text
                                        };
                                        myContext.EmploymentTypes.Add(empType);
                                        myContext.SaveChanges();

                                       // MessageBox.Show("Added Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        LinkdgEmployment();

                                        btnAdd.Text = "Add";
                                        button1.Text = "Edit";

                                        dataGridView1.Enabled = true;
                                        btnAdd.Enabled = true;

                                        button1.Enabled = false;
                                        textBox1.Enabled = false;

                                        textBox1.Clear();
                                        dataGridView1.ClearSelection();
                                    }
                                }
                            }
                            catch { }
                        }
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void addEmploymentTypeForm_Load(object sender, EventArgs e)
        {
            btnAdd.Text = "Add";
            button1.Text = "Edit";

            dataGridView1.Enabled = true;
            btnAdd.Enabled = true;

            button1.Enabled = false;
            textBox1.Enabled = false;

            textBox1.Clear();
            dataGridView1.ClearSelection();

            LinkdgEmployment();

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

                    textBox1.Enabled = true;
                }
                else
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Enter Type of Employment Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                                var c = (from s in myContext.EmploymentTypes where s.EmploymentTypeId == id select s).First();

                                if (myContext.EmploymentTypes.Any(o => o.EmploymentName == textBox1.Text && textBox1.Text != c.EmploymentName))
                                {
                                    MessageBox.Show("Employment Type Already Exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBox1.Clear();
                                    textBox1.Focus();
                                }
                                else
                                {
                                    try
                                    {
                                        c.EmploymentName = textBox1.Text;
                                        myContext.SaveChanges();

                                        LinkdgEmployment();

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
