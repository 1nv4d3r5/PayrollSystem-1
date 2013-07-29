using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem
{
    class DeductEarn
    {
        public int DeductEarnId { get; set; }
        public string Name { get; set; }
        public double Hours { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        public string Reference { get; set; }
        public int Userid { get; set; }
        public string DateRange { get; set; }
    }    
}
