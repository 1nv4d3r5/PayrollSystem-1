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
    public partial class Payroll : Form
    {
        Properties.Settings settings = new Properties.Settings();

        public Payroll()
        {
            InitializeComponent();
        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            EmployeeDataGrid ed = new EmployeeDataGrid();
            ed.BindGrid(dataGridView1);
            dataGridView1.ReadOnly= true;
            dataGridView1.Refresh();

            panel3.Enabled = false;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtuid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtuname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtposition.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtdepartment.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtcivilstat.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtnodependent.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtemptype.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtdrate.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtactivation.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                Txrender.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                Txabsent.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                txtrate.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

                panel4.Refresh();

                
            }
            catch { }
        }


        private void Search()
        {
            using (var myContext = new EmployeeContext())
            {
                var sc = from s in myContext.Employees
                         where
                             s.UserId.ToString().Contains(txtsearch.Text) ||
                             s.FirstName.Contains(txtsearch.Text)||
                             s.LastName.Contains(txtsearch.Text)
                             
                             
                         select s;
                dataGridView1.DataSource = sc.ToList();

            }
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            //Search();
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Search();
        }

        private void txtsearch_KeyUp(object sender, KeyEventArgs e)
        {
           // Search();
        }

        //private void btncompute_Click(object sender, EventArgs e)
        //{
        //    if (comboBox2.Text == "")
        //    { 
               
        //    }
        //    else
        //    compute();
        //}


        //private void compute()
        //{
        //    double BS = 0;
        //    double bs = 0;

        //    try
        //    {
        //        BS = double.Parse(dataGridView1.SelectedRows[0].Cells[11].Value.ToString());

        //        if (comboBox2.Text == "Monthly")
        //        {


        //            //txtbasicsalary.Text = (double.Parse(txtbasicsalary.Text) * 2).ToString();

        //            getPhilHealth phCompute = new getPhilHealth();
        //            settings.Philhealth = phCompute.PhilHealth(BS);

        //            getSSS sssCompute = new getSSS();
        //            settings.SSS = sssCompute.SSS(BS);
        //            settings.Pagbig = 100;
        //            settings.Save();

        //            settings.TotalDeuction = settings.SSS + settings.Pagbig + settings.Philhealth;
        //            settings.Save();


        //            MessageBox.Show(settings.SSS.ToString());
        //            MessageBox.Show(settings.Pagbig.ToString());
        //            MessageBox.Show(settings.Philhealth.ToString());
        //            MessageBox.Show(settings.TotalDeuction.ToString());
        //        }
        //        else
        //        {
        //            double bsalary;

        //            bsalary = BS * 2;
                   

        //            getPhilHealth phCompute = new getPhilHealth();
        //            settings.Philhealth = (phCompute.PhilHealth(bsalary)) / 2;

        //            getSSS sssCompute = new getSSS();
        //            settings.SSS = (sssCompute.SSS(bsalary)) / 2;
        //            settings.Pagbig = 50;
        //            settings.Save();

        //            settings.TotalDeuction = settings.SSS + settings.Pagbig + settings.Philhealth;
        //            settings.Save();


        //            MessageBox.Show(settings.SSS.ToString());
        //            MessageBox.Show(settings.Pagbig.ToString());
        //            MessageBox.Show(settings.Philhealth.ToString());
        //            MessageBox.Show(settings.TotalDeuction.ToString());
        //        }
        //    }
        //    catch { };
        //}

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
            List<DeductEarn> de = new List<DeductEarn>();
            de.Add(new DeductEarn { Name = "Utang", Amount = 100, Type = "Deduct" });
            de.Add(new DeductEarn { Name = "Basic Salary", Amount = 15000, Type = "Earn" });
            de.Add(new DeductEarn { Name = "Utang", Amount = 100, Type = "Deduct" });
            de.Add(new DeductEarn { Name = "Utang", Amount = 100, Type = "Deduct" });
            de.Add(new DeductEarn { Name = "Utang", Amount = 100, Type = "Deduct" });
            de.Add(new DeductEarn { Name = "Utang", Amount = 100, Type = "Deduct" });


            DrawPayslip dp = new DrawPayslip();
            dp.d.ComapanyName = "Asi.Com.Ph";
            dp.d.Reference = "000000";
            dp.d.FromTo = "07/1/2013 - 07/15/2013";
            dp.d.EmployeeName = txtuname.Text;
            dp.d.UserID = txtuid.Text;
            dp.d.DateCreated = DateTime.Now.ToShortDateString();
            dp.d.NetPay = "2000";
            dp.d.TotalDeduction = "1000";
            dp.d.TotalIncome = "4000";
            dp.panel1_Paint(sender, e, de);
        }


    }
}
