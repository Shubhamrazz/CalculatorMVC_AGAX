using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorMVC_AGAX.Models
{
    public class CalculateModel
    {
        [Key]
        public int Add { get; set; }
        public int Substract { get; set; }
        public int Multiply { get; set; }
        public decimal Divide { get; set; }
        //public DateTime CurrentDateTime { get; set; }
    }
}
