using System;

namespace APICalculator.Models
{
    public class Calculator
    {

        // JSON to Send

        /* 
         {
            "num1": 12.3,
            "num2": 45.03
         }
        */

        public const int ROUND_DECIMAL = 4;

        public double num1 { get; set; }
        public double num2 { get; set; }

        public Calculator(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double Addition()
        {
            return Math.Round(this.num1 + this.num2, ROUND_DECIMAL);
        }

        public double Subtraction()
        {
            return Math.Round(this.num1 - this.num2, ROUND_DECIMAL);
        }

        public double Multiplication()
        {
            return Math.Round(this.num1 * this.num2, ROUND_DECIMAL);
        }

        public double Division()
        {
            return Math.Round(this.num1 / this.num2, ROUND_DECIMAL);
        }
    }
}
