using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PayrollSystem
{
    class Details
    {
        public string ComapanyName { get; set; }
        public string Reference { get; set; }
        public string FromTo { get; set; }
        public string DateCreated { get; set; }
        public string EmployeeName { get; set; }
        public string UserID { get; set; }
        public string NetPay { get; set; }
        public string TotalIncome { get; set; }
        public string TotalDeduction { get; set; }
    }

    class DrawPayslip
    {
        public Details d = new Details();
        
        public void panel1_Paint(object sender, PaintEventArgs e, List<DeductEarn> deductAndEarn)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 8);
            float fontHeight = font.GetHeight();
            int startX = 20;
            int startY = 20;
            int Offset = 0;
            int space = 20;

            Pen blackPen = new Pen(Color.Black, 1);

            StringFormat stringFormatCenter = new StringFormat();
            stringFormatCenter.Alignment = StringAlignment.Center;
            stringFormatCenter.LineAlignment = StringAlignment.Center;


            StringFormat stringFormatLeft = new StringFormat();
            stringFormatLeft.Alignment = StringAlignment.Near;
            stringFormatLeft.LineAlignment = StringAlignment.Center;

            StringFormat stringFormatRight = new StringFormat();
            stringFormatRight.Alignment = StringAlignment.Far;
            stringFormatRight.LineAlignment = StringAlignment.Center;


            Rectangle rect1 = new Rectangle(0, startY + Offset, 1000, 30);
            e.Graphics.DrawString(d.ComapanyName,
                new Font("Courier New", 12),
                new SolidBrush(Color.Black),
                rect1, stringFormatCenter);
            e.Graphics.DrawRectangle(blackPen, rect1);

            Rectangle rect2 = new Rectangle(1, startY + Offset, 200, 30);

            e.Graphics.DrawString("Reference# : " + d.Reference,
                new Font("Courier New", 10),
                new SolidBrush(Color.Black),
                rect2, stringFormatLeft);

            e.Graphics.DrawRectangle(blackPen, rect2);

            Rectangle rect3 = new Rectangle(800, startY + Offset, 200, 30);

            e.Graphics.DrawString("FromTo : \n" + d.FromTo,
                new Font("Courier New", 10),
                new SolidBrush(Color.Black),
                rect3, stringFormatRight);

            e.Graphics.DrawRectangle(blackPen, rect3);

            Offset = Offset + space;

            Rectangle rect6 = new Rectangle(0, startY + Offset + 20, 1000, 20);

            e.Graphics.DrawString(d.EmployeeName,
                new Font("Courier New", 10),
                new SolidBrush(Color.Black),
                rect6, stringFormatLeft);

            e.Graphics.DrawRectangle(blackPen, rect6);

            Rectangle rect7 = new Rectangle(0, startY + Offset + 20, 1000, 20);

            e.Graphics.DrawString(d.UserID,
                new Font("Courier New", 10),
                new SolidBrush(Color.Black),
                rect7, stringFormatRight);

            //e.Graphics.DrawRectangle(blackPen, rect7);

            Offset = Offset + space;

            Rectangle rect8 = new Rectangle(0, startY + Offset + 20, 1000, 20);

            e.Graphics.DrawString("Date:" + d.DateCreated,
                new Font("Courier New", 10),
                new SolidBrush(Color.Black),
                rect8, stringFormatLeft);

            e.Graphics.DrawRectangle(blackPen, rect8);
            
            Offset = Offset + space + 10;


            Rectangle rect4 = new Rectangle(0, startY + Offset + 20, 500, 20);

            e.Graphics.DrawString("Earnings",
                new Font("Courier New", 10),
                new SolidBrush(Color.Black),
                rect4, stringFormatCenter);

            e.Graphics.DrawRectangle(blackPen, rect4);

            Rectangle rect5 = new Rectangle(500, startY + Offset + 20, 500, 20);

            e.Graphics.DrawString("Deductions",
                new Font("Courier New", 10),
                new SolidBrush(Color.Black),
                rect5, stringFormatCenter);

            e.Graphics.DrawRectangle(blackPen, rect5);

            Offset = Offset + space;

            Rectangle rect10 = new Rectangle(0, startY + Offset + 20, 500, 300);

            e.Graphics.DrawRectangle(blackPen, rect10);

            Rectangle rect11 = new Rectangle(500, startY + Offset + 20, 500, 300);

            e.Graphics.DrawRectangle(blackPen, rect11);
            Offset = Offset + space;

            int offSetLeft = Offset + 15;
            int offSetRight = Offset + 15;

            foreach (var ded in deductAndEarn)
            {
                Rectangle LeftCon = new Rectangle(10, startY + offSetLeft, 480, 20);
                Rectangle RightCon = new Rectangle(510, startY + offSetRight, 480, 20);

                if (ded.Type == "Earn")
                {
                    e.Graphics.DrawString(ded.Name,
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black),
                    LeftCon, stringFormatLeft);

                    e.Graphics.DrawString(ded.Amount.ToString(),
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black),
                    LeftCon, stringFormatRight);

                    offSetLeft = offSetLeft + space;
                }
                else if (ded.Type == "Deduct")
                {
                    e.Graphics.DrawString(ded.Name,
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black),
                    RightCon, stringFormatLeft);

                    e.Graphics.DrawString(ded.Amount.ToString(),
                    new Font("Courier New", 14),
                    new SolidBrush(Color.Black),
                    RightCon, stringFormatRight);

                    offSetRight = offSetRight + space;
                }
            }

            Rectangle rect14 = new Rectangle(0, startY + Offset + 260, 500, 20);

            e.Graphics.DrawString("Total Earnings",
                new Font("Courier New", 10),
                new SolidBrush(Color.Black),
                rect14, stringFormatLeft);

            e.Graphics.DrawString(d.TotalDeduction,
               new Font("Courier New", 12, FontStyle.Bold),
               new SolidBrush(Color.Black),
               rect14, stringFormatRight);

            e.Graphics.DrawRectangle(blackPen, rect14);

            Rectangle rect13 = new Rectangle(500, startY + Offset + 260, 500, 20);

            e.Graphics.DrawString("Total Deductions",
                new Font("Courier New", 10),
                new SolidBrush(Color.Black),
                rect13, stringFormatLeft);

            e.Graphics.DrawString(d.TotalDeduction,
               new Font("Courier New", 12, FontStyle.Bold),
               new SolidBrush(Color.Black),
               rect13, stringFormatRight);

            e.Graphics.DrawRectangle(blackPen, rect13);

            Rectangle rect12 = new Rectangle(500, startY + Offset + 280, 500, 20);

            e.Graphics.DrawString("NetPay",
                new Font("Courier New", 10),
                new SolidBrush(Color.Black),
                rect12, stringFormatLeft);


            e.Graphics.DrawString(d.NetPay,
                new Font("Courier New", 12, FontStyle.Bold),
                new SolidBrush(Color.Black),
                rect12, stringFormatRight);

            e.Graphics.DrawRectangle(blackPen, rect12);

        }
    }
}
