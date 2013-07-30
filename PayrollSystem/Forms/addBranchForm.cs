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
    public partial class addBranchForm : Form
    {
        Properties.Settings settings = new Properties.Settings();

        
        public addBranchForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter New Branch.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else
            {
                string connectionstring = @"user id=" + settings.userid + ";password=" + settings.password + ";server=" + settings.server + ";Trusted_Connection=yes;database=" + settings.database + ";connection timeout=30";

                using (var myContext = new EmployeeContext())
                {
                    if (myContext.Branches.Any(o => o.BranchName == textBox1.Text))
                    {
                        MessageBox.Show("Branch is already exist.");
                        textBox1.Clear();

                    }
                    else
                    {
                        var branch = new Branch
                        {
                            BranchName = textBox1.Text
                        };
                        myContext.Branches.Add(branch);
                        myContext.SaveChanges();

                        MessageBox.Show("Added Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                    }
                }
            }
        }

        private void addBranchForm_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            
        }


  
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (textBox1.Text == "")
        //    {
        //        MessageBox.Show("Enter Branch Name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        textBox1.Focus();
        //    }
        //    else
        //    {
                
        //        using (var myContext = new EmployeeContext())
        //        {
                    
        //            foreach (var a in myContext.Branches)
        //            {
        //                id= a.BranchId;
        //            }

        //            var c = (from s in myContext.Branches where s.BranchName == textBox1.Text && s.BranchId == id select s).First();
        //            c.BranchName = textBox1.Text;
        //            myContext.SaveChanges();
        //            textBox1.Clear();
        //        }
        //    }
        //}

        
    }
}
