namespace PayrollSystem
{
    partial class Payroll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsynchronize = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncompute = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtnodep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemptype = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtschedid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsalaryid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtuid = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcivilstat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnsynchronize);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(1, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 390);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(129, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "History";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnsynchronize
            // 
            this.btnsynchronize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsynchronize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsynchronize.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsynchronize.Location = new System.Drawing.Point(14, 7);
            this.btnsynchronize.Name = "btnsynchronize";
            this.btnsynchronize.Size = new System.Drawing.Size(100, 40);
            this.btnsynchronize.TabIndex = 5;
            this.btnsynchronize.Text = "Verify";
            this.btnsynchronize.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 333);
            this.panel5.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(242, 333);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btncompute);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 216);
            this.panel2.TabIndex = 1;
            // 
            // btncompute
            // 
            this.btncompute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompute.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompute.Location = new System.Drawing.Point(72, 175);
            this.btncompute.Name = "btncompute";
            this.btncompute.Size = new System.Drawing.Size(91, 34);
            this.btncompute.TabIndex = 7;
            this.btncompute.Text = "Compute";
            this.btncompute.UseVisualStyleBackColor = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(48, 28);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(160, 20);
            this.txtsearch.TabIndex = 16;
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            this.txtsearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyUp);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(20, 9);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(46, 16);
            this.label36.TabIndex = 17;
            this.label36.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 117);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Range";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(91, 86);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(103, 23);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Semi-Monthly",
            "Monthly"});
            this.comboBox2.Location = new System.Drawing.Point(91, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(103, 24);
            this.comboBox2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Period";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(21, 88);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(22, 16);
            this.label32.TabIndex = 1;
            this.label32.Text = "To";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(21, 59);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(38, 16);
            this.label33.TabIndex = 0;
            this.label33.Text = "From";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtnodep);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtemptype);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtschedid);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtsalaryid);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtuid);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtuname);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtposition);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtdepartment);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtcivilstat);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(253, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 183);
            this.panel3.TabIndex = 2;
            // 
            // txtnodep
            // 
            this.txtnodep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnodep.Location = new System.Drawing.Point(727, 24);
            this.txtnodep.Name = "txtnodep";
            this.txtnodep.Size = new System.Drawing.Size(42, 26);
            this.txtnodep.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 65;
            this.label5.Text = "No. of Dependent";
            // 
            // txtemptype
            // 
            this.txtemptype.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemptype.Location = new System.Drawing.Point(727, 59);
            this.txtemptype.Name = "txtemptype";
            this.txtemptype.Size = new System.Drawing.Size(242, 26);
            this.txtemptype.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 18);
            this.label8.TabIndex = 66;
            this.label8.Text = "Employment Type";
            // 
            // txtschedid
            // 
            this.txtschedid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtschedid.Location = new System.Drawing.Point(727, 91);
            this.txtschedid.Name = "txtschedid";
            this.txtschedid.Size = new System.Drawing.Size(242, 26);
            this.txtschedid.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(573, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 67;
            this.label9.Text = "Schedule Id";
            // 
            // txtsalaryid
            // 
            this.txtsalaryid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalaryid.Location = new System.Drawing.Point(727, 123);
            this.txtsalaryid.Name = "txtsalaryid";
            this.txtsalaryid.Size = new System.Drawing.Size(242, 26);
            this.txtsalaryid.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(571, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 68;
            this.label10.Text = "Salary Id";
            // 
            // txtuid
            // 
            this.txtuid.AutoSize = true;
            this.txtuid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuid.Location = new System.Drawing.Point(70, 140);
            this.txtuid.Name = "txtuid";
            this.txtuid.Size = new System.Drawing.Size(0, 18);
            this.txtuid.TabIndex = 64;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "ID";
            // 
            // txtuname
            // 
            this.txtuname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuname.Location = new System.Drawing.Point(272, 25);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(242, 26);
            this.txtuname.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Name";
            // 
            // txtposition
            // 
            this.txtposition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposition.Location = new System.Drawing.Point(272, 59);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(242, 26);
            this.txtposition.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Position";
            // 
            // txtdepartment
            // 
            this.txtdepartment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartment.Location = new System.Drawing.Point(272, 91);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(242, 26);
            this.txtdepartment.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Department";
            // 
            // txtcivilstat
            // 
            this.txtcivilstat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcivilstat.Location = new System.Drawing.Point(272, 123);
            this.txtcivilstat.Name = "txtcivilstat";
            this.txtcivilstat.Size = new System.Drawing.Size(242, 26);
            this.txtcivilstat.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(170, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "Civil Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(253, 197);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1002, 473);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Payroll";
            this.Text = "Payroll";
            this.Load += new System.EventHandler(this.Payroll_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcivilstat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsynchronize;
        private System.Windows.Forms.Button btncompute;
        private System.Windows.Forms.TextBox txtnodep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemptype;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtschedid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsalaryid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtuid;
    }
}