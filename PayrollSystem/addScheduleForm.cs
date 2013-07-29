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
    public partial class addScheduleForm : Form
    {
        
        public addScheduleForm()
        {
            InitializeComponent();
        }


        private void LinkdgSchedule()
        {
            try
            {
                using (var myContext = new EmployeeContext())
                {
                    var st = from s in myContext.Schedules select s;
                    {

                        dataGridView1.DataSource = st.ToList();
                        dataGridView1.ReadOnly = true;
                        dataGridView1.Enabled = true;
                        dataGridView1.Refresh();


                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "Schedule Code";
                        dataGridView1.Columns[2].HeaderText = "Time-in";
                        dataGridView1.Columns[3].HeaderText = "Time-in Start";
                        dataGridView1.Columns[4].HeaderText = "Time-out";
                        dataGridView1.Columns[5].HeaderText = "Time-out End";
                        dataGridView1.Columns[6].HeaderText = "Graceful Time";
                        




                        dataGridView1.Columns[0].Width = 25;
                        dataGridView1.Columns[1].Width = 120;
                        dataGridView1.Columns[2].Width = 75;
                        dataGridView1.Columns[3].Width = 75;
                        dataGridView1.Columns[4].Width = 75;
                        dataGridView1.Columns[5].Width = 75;
                        dataGridView1.Columns[6].Width = 75;

                    }
                }
            }
            catch
            { }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                dateTimePicker2.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                dateTimePicker3.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                dateTimePicker4.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                dateTimePicker5.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
               


                button1.Enabled = false;
               

            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Add")
            {
                btnSave.Text = "Save";
                button1.Text = "Edit";

                button1.Enabled = false;
                dataGridView1.Enabled = false;

                textBox1.Clear();
            }
            else
            {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter New Schedule Code.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            using (var myContext = new EmployeeContext())
            {
                if (myContext.Schedules.Any(o => o.ScheduleId == int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Schedule Code is already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();

                }
                else
                {
                    var schedule = new Schedule
                    {
                        ScheduleCode = textBox1.Text,
                        TimeIn = dateTimePicker1.Value.TimeOfDay,
                        TimeOut = dateTimePicker2.Value.TimeOfDay,
                        TimeInStart = dateTimePicker3.Value.TimeOfDay,
                        TimeOutEnd = dateTimePicker4.Value.TimeOfDay,
                        GracefulTime = dateTimePicker5.Value.TimeOfDay
                    };
                    myContext.Schedules.Add(schedule);
                    myContext.SaveChanges();

                    MessageBox.Show("Added Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                }
            }
            }
        }

        private void addScheduleForm_Load(object sender, EventArgs e)
        {
            LinkdgSchedule();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Edit")
            {
                button1.Text = "Update";
                btnSave.Text = "Add";

                dataGridView1.Enabled = false;
                btnSave.Enabled = false;

            }

            else 
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter Schedule Code.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();


                }
                else
                {


                    using (var myContext = new EmployeeContext())
                    {

                        if (myContext.Schedules.Any(o => o.ScheduleId == int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())))
                        {

                            var c = new Schedule
                            {
                                ScheduleCode = textBox1.Text,
                                TimeIn = TimeSpan.Parse(dateTimePicker1.Value.ToShortTimeString()),
                                TimeInStart = TimeSpan.Parse(dateTimePicker2.Value.ToShortTimeString()),
                                TimeOut = TimeSpan.Parse(dateTimePicker3.Value.ToShortTimeString()),
                                TimeOutEnd = TimeSpan.Parse(dateTimePicker4.Value.ToShortTimeString()),
                                GracefulTime = TimeSpan.Parse(dateTimePicker5.Value.ToShortTimeString())
                            };

                            myContext.Schedules.Add(c);
                            myContext.SaveChanges();
                            LinkdgSchedule();

                            textBox1.Clear();
                            dataGridView1.ClearSelection();

                            dataGridView1.Enabled = true;
                            btnSave.Enabled = true;

                            button1.Enabled = false;

                            button1.Text = "Edit";
                        }
                    }
                }
            }
        }

       
    }
}
