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
    public partial class addholiday : Form
    {
      
        public addholiday()
        {
            InitializeComponent();
        }

        private void LinkdgHolidays()
        {
            try
            {
                using (var myContext = new EmployeeContext())
                {
                    var st = from s in myContext.HL select s;
                    {

                        dataGridView1.DataSource = st.ToList();
                        dataGridView1.ReadOnly = true;
                        dataGridView1.Enabled = true;
                        dataGridView1.Refresh();


                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Date";
                        dataGridView1.Columns[2].HeaderText = "Holiday";
                        dataGridView1.Columns[3].HeaderText = "Type";


                        dataGridView1.Columns[0].Width = 100;
                        dataGridView1.Columns[1].Width = 150;
                        dataGridView1.Columns[2].Width = 209;
                        dataGridView1.Columns[3].Width = 270;

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

                textBox1.Clear();
                comboBox1.SelectedIndex = -1;

                dateTimePicker1.Enabled = true;
                textBox1.Enabled = true;
                comboBox1.Enabled = true;

                btnadd.Text = "Save";
                btnedit.Text = "Edit";

                btnedit.Enabled = false;
                dataGridView1.Enabled = false;

            }

            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter New Holiday.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
 
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Choose Type of Holiday.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox1.Focus();
 
                }
                else
                {
                using (var myContext = new EmployeeContext())
                {



                    if (myContext.HL.Any(o => o.Name == textBox1.Text && o.HolidayDate == dateTimePicker1.Value.Date))
                    {
                        MessageBox.Show("Holiday is already Exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                        comboBox1.SelectedIndex = -1;
                        textBox1.Focus();
                    }
                    else
                    {
                        var holday = new HolidayList
                        {
                            HolidayDate = dateTimePicker1.Value.Date,
                            Name = textBox1.Text,
                            Type = comboBox1.SelectedItem.ToString()
                        };

                        myContext.HL.Add(holday);
                        myContext.SaveChanges();

                        textBox1.Clear();
                        comboBox1.SelectedIndex = -1;


                        btnadd.Text = "Add";
                        btnedit.Text = "Edit";
                        LinkdgHolidays();
                        dataGridView1.ClearSelection();

                        dataGridView1.Enabled = true;

                        dateTimePicker1.Enabled = false;
                        textBox1.Enabled = false;
                        comboBox1.Enabled = false;
                    }
                    }
                }


            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            using (var myContext = new EmployeeContext())
            {
                if (btnedit.Text == "Edit")
                {
                    btnedit.Text = "Update";
                    btnadd.Text = "Add";

                    dateTimePicker1.Enabled = true;
                    textBox1.Enabled = true;
                    comboBox1.Enabled = true;

                    dataGridView1.Enabled = false;
                    btnadd.Enabled = false;


                }

                else
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Enter Holiday Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();

                    }
                    else if (comboBox1.Text == "")
                    {
                        MessageBox.Show("Choose Type of Holiday.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comboBox1.Focus();

                    }
                    else
                    {
                        int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                        var c = (from s in myContext.HL where s.HolidayListID == id select s).First();

                        if (myContext.HL.Any(o => o.Name == textBox1.Text && textBox1.Text != c.Name))
                        {
                            MessageBox.Show("Holiday Already Exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Clear();
                            textBox1.Focus();
                        }
                        else
                        {
                           
                            c.Name = textBox1.Text;
                            c.HolidayDate = dateTimePicker1.Value.Date;
                            c.Type = comboBox1.SelectedItem.ToString();
                            myContext.SaveChanges();


                            textBox1.Clear();
                            comboBox1.SelectedIndex = -1;

                            btnedit.Enabled = false;
                            dateTimePicker1.Enabled = false;
                            textBox1.Enabled = false;
                            comboBox1.Enabled = false;
                            btnedit.Enabled = false;


                            btnedit.Text = "Edit";
                            LinkdgHolidays();
                            dataGridView1.ClearSelection();

                            dataGridView1.Enabled = true;
                            btnadd.Enabled = true;

                        }

                    }
                }
            }
        }

        private void addholiday_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;

            dataGridView1.Enabled = true;

            

            btnedit.Enabled = false;
            dateTimePicker1.Enabled = false;
            textBox1.Enabled = false;
            comboBox1.Enabled = false;

            btnadd.Text = "Add";
            btnedit.Text = "Edit";


            LinkdgHolidays();
            dataGridView1.ClearSelection();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                btnedit.Enabled = true;

            }
            catch
            {
            }
        }


       
    }
}
