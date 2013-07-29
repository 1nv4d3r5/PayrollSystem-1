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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBranchForm bform = new addBranchForm();
            bform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addDepartmentForm df = new addDepartmentForm();
            df.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addPositionForm pf = new addPositionForm();
            pf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addSalaryForm sf = new addSalaryForm();
            sf.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addScheduleForm sf = new addScheduleForm();
            sf.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addEmployeeFrom em = new addEmployeeFrom();
            em.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addEmploymentTypeForm empt = new addEmploymentTypeForm();
            empt.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addholiday hl= new addholiday();
            hl.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addallowance aa = new addallowance();
            aa.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Payroll pt = new Payroll();
            pt.ShowDialog();
        }
    }
}
