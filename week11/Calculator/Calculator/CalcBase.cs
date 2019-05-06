using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcBase
    {
        public double first_number;
        public double second_number;
        public double result;
        public string operation;
        public void Calculate()
        {
            switch (operation)
            {
                case "+":
                    result = first_number + second_number;
                    break;
                case "-":
                    result = first_number - second_number;
                    break;
                case "*":
                    result = first_number * second_number;
                    break;
                case "/":
                    result = first_number / second_number;
                    break;
                case "x^2":
                    result = first_number * first_number;
                    break;
                case "x^3":
                    result = first_number * first_number * first_number;
                    break;
                case "sq":
                    result = Math.Sqrt(first_number);
                    break;
            }
        }
    }
}
