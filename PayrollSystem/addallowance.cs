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
    public partial class addallowance : Form
    {
        Properties.Settings settings = new Properties.Settings();
     
        public addallowance()
        {
            InitializeComponent();
        }

        private void LinkdgAllowance()
        {
            try
            {
                string connectionstring = @"user id=" + settings.userid + ";password=" + settings.password + ";server=" + settings.server + ";Trusted_Connection=yes;database=" + settings.database + ";connection timeout=30";

                using (var myContext = new EmployeeContext())
                {
                    var st = from s in myContext.Allowances select s;
                    {

                        dataGridView1.DataSource = st.ToList();
                        dataGridView1.ReadOnly = true;
                        dataGridView1.Enabled = true;
                        dataGridView1.Refresh();


                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Allowance";
                        dataGridView1.Columns[2].HeaderText = "Rate";
                        
                        dataGridView1.Columns[0].Width = 130;
                        dataGridView1.Columns[1].Width = 240;
                        dataGridView1.Columns[2].Width = 180;
                        

                    }
                }
            }
            catch
            { }


        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (btnadd.Text == "Add")
            {
                btnadd.Text = "Save";
                btnedit.Text = "Edit";

                textBox1.Clear();
                textBox2.Clear();

                textBox1.Enabled = true;
                textBox2.Enabled = true;

                dataGridView1.Enabled = false;
                btnedit.Enabled = false;


            }
            else 
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter New Allowance.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Enter New Allowance Rate.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                }
                else
                {
                    string connectionstring = @"user id=" + settings.userid + ";password=" + settings.password + ";server=" + settings.server + ";Trusted_Connection=yes;database=" + settings.database + ";connection timeout=30";


                    using (var myContext = new EmployeeContext())
                    {

                        if (myContext.Allowances.Any(o => o.Name == textBox1.Text))
                        {
                            MessageBox.Show("Allowance is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Clear();


                        }
                        else
                        {
                            var al = new Allowance
                            {
                                Name = textBox1.Text,
                                Rate = double.Parse(textBox2.Text)
                            };
                            myContext.Allowances.Add(al);
                            myContext.SaveChanges();
                        }
                        LinkdgAllowance();
                        textBox1.Clear();
                        textBox2.Clear();
                        dataGridView1.ClearSelection();

                        btnadd.Text = "Add";
                        btnedit.Text = "Edit";

                        dataGridView1.Enabled = true;

                        btnedit.Enabled = false;
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;


                    }
                }

 
            }
           
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (btnedit.Text == "Edit")
            {
                btnadd.Text = "Add";
                btnedit.Text = "Update";

                btnadd.Enabled = false;
                dataGridView1.Enabled = false;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter New Allowance.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Enter New Allowance Rate.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Focus();
                }
                else
                {
                    int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());


                    string connectionstring = @"user id=" + settings.userid + ";password=" + settings.password + ";server=" + settings.server + ";Trusted_Connection=yes;database=" + settings.database + ";connection timeout=30";


                    using (var myContext = new EmployeeContext())
                    {
                        
                            var c = (from s in myContext.Allowances where s.AllowanceID == id select s).First();

                            if (myContext.Allowances.Any(o => o.Name == textBox1.Text && textBox1.Text != c.Name))
                            {
                                MessageBox.Show("Allowance Already Exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox1.Clear();
                                textBox1.Focus();
                            }
                            else
                            {
                            
                                c.Name = textBox1.Text;
                                c.Rate = double.Parse(textBox2.Text);
                                myContext.SaveChanges();

                                LinkdgAllowance();

                                dataGridView1.Enabled = true;
                                btnadd.Enabled = true;

                                btnedit.Enabled = false;


                                dataGridView1.ClearSelection();
                                textBox1.Clear();
                                textBox2.Clear();

                                textBox1.Enabled = false;
                                textBox2.Enabled = false;

                                btnadd.Text = "Add";
                                btnedit.Text = "Edit";


                            }
                    }

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                btnedit.Enabled = true;

            }
            catch
            {
            }
        }

        private void addallowance_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            btnadd.Enabled = true;

            btnedit.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;


            dataGridView1.ClearSelection();
            textBox1.Clear();
            textBox2.Clear();

            btnadd.Text = "Add";
            btnedit.Text = "Edit";

            LinkdgAllowance();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }


            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }


    }
}
