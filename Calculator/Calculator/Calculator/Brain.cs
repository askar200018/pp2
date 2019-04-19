using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    enum CalcState
    {
        Zero,
        AccumulateDigits,
        Operation,
        Result,
        QuickOperation
    }
   
    public delegate void ChangeTextDelegate(string text);

    class Brain
    {
        ChangeTextDelegate changeTextDelegate;
        CalcState calcState = CalcState.Zero;
        string tempNumber = "";
        string resultNumber = "";
        string operation = "";
        bool isPoint = true;
        public Brain(ChangeTextDelegate changeTextDelegate)
        {
            this.changeTextDelegate = changeTextDelegate;
        }

        public void Process(string msg)
        {
            switch (calcState)
            {
                case CalcState.Zero:
                    Zero(msg, false);
                    break;
                case CalcState.AccumulateDigits:
                    AccumulateDigits(msg, false);
                    break;
                case CalcState.Operation:
                    Operation(msg, false);
                    break;
                case CalcState.Result:
                    Result(msg, false);
                    break;
                case CalcState.QuickOperation:
                    QuickOperation(msg, false);
                    break;
                default:
                    break;
            }
        }
            void Zero(string msg , bool isInput)
            {
                if(isInput)
                {
                    tempNumber = "0";
                    calcState = CalcState.Zero;
                }
                else
                {
                    if (Rules.IsNonZeroDigit(msg))
                    {
                        AccumulateDigits(msg, true);
                    }
                }
            }
        void AccumulateDigits(string msg , bool isInput)
        {
            if (isInput)
            {
                calcState = CalcState.AccumulateDigits;
                tempNumber += msg;
                changeTextDelegate.Invoke(tempNumber);
            }
            else
            {
                if (Rules.IsDigit(msg))
                {
                    AccumulateDigits(msg, true);
                }
                else if (Rules.IsOperation(msg))
                {
                    Operation(msg, true);
                }
                else if (Rules.IsResult(msg))
                {
                    Result(msg, true);
                }
                else if (Rules.IsQuickOperation(msg))
                {
                    QuickOperation(msg, true);
                }
                else if (Rules.IsPoint(msg) && isPoint)
                {
                    isPoint = false;
                    AccumulateDigits(msg, true);
                }
            }
        }
        void Operation(string msg , bool isInput)
        {
            if (isInput)
            {
                calcState = CalcState.Operation;
                if (operation.Length != 0)
                {
                    PerformCalculation();
                    changeTextDelegate(resultNumber);
                }
                if (resultNumber == "")
                {
                    resultNumber = tempNumber;
                }
                isPoint = true;
                operation = msg;
                //changeTextDelegate.Invoke(msg);
                tempNumber = "";
            }
            else
            {
                if (Rules.IsDigit(msg))
                {
                    AccumulateDigits(msg, true);
                }
                else if (Rules.IsOperation(msg))
                {
                    operation = "";
                    Operation(msg, true);
                }
            }
        }

        void QuickOperation(string msg , bool isInput)
        {
            if (isInput)
            {
                if(resultNumber != "")
                {
                    tempNumber = resultNumber;
                    resultNumber = "";
                }
                isPoint = true;
                calcState = CalcState.QuickOperation;
                operation = msg;
                QuickCalulation();
                changeTextDelegate(tempNumber);
            }
            else
            {
                if (Rules.IsNonZeroDigit(msg))
                {
                    tempNumber = "";
                    resultNumber = "";
                    changeTextDelegate.Invoke(tempNumber);
                    AccumulateDigits(msg, true);
                }
                else if (Rules.IsOperation(msg))
                {
                    Operation(msg, true);
                }
                else if (Rules.IsQuickOperation(msg))
                {
                    QuickOperation(msg, true);
                }
            }
        }

        void Result(string msg, bool isInput)
        {
            if (isInput)
            {
                isPoint = true;
                calcState = CalcState.Result;
                PerformCalculation();
                operation = "";
                changeTextDelegate.Invoke(resultNumber);
            }
            else
            {
                if (Rules.IsOperation(msg))
                {
                    Operation(msg, true);
                }
                else if (Rules.IsNonZeroDigit(msg))
                {
                    tempNumber = "";
                    resultNumber = "";
                    changeTextDelegate.Invoke(tempNumber);
                    AccumulateDigits(msg, true);
                }
                else if (Rules.IsResult(msg))
                {
                    Result(msg, true);
                }
                else if (Rules.IsQuickOperation(msg))
                {
                    QuickOperation(msg, true);
                }
            }
        }
        void PerformCalculation()
        {
            if (operation == "+")
            {
                resultNumber = (double.Parse(tempNumber) + double.Parse(resultNumber)).ToString();
            }
            else if (operation == "-")
            {
                resultNumber = (double.Parse(resultNumber) - double.Parse(tempNumber)).ToString();
            }
            else if (operation == "*")
            {
                resultNumber = (double.Parse(tempNumber) * double.Parse(resultNumber)).ToString();
            }
            else if (operation == "/")
            {
                resultNumber = (double.Parse(resultNumber) / double.Parse(tempNumber)).ToString();
            }
        }
        void QuickCalulation()
        {
            if (operation == "x^2")
            {
                tempNumber = (double.Parse(tempNumber) * double.Parse(tempNumber)).ToString();
            }
            else if (operation == "√")
            {
                tempNumber = ( Math.Sqrt(double.Parse(tempNumber))).ToString();
            }
            else if(operation == "←")
            {
                tempNumber = tempNumber.Remove(tempNumber.Length - 1);
            }
            else if(operation == "C")
            {
                tempNumber = "";
            }
            else if (operation == "±")
            {
                tempNumber = double.Parse(tempNumber) *(-1) + "";
            }
            else if (operation == "1/x")
            {
                tempNumber = 1 / double.Parse(tempNumber) + "";
            }
            else if (operation == "!")
            {
                tempNumber = Factorial(double.Parse(tempNumber)) + "";
            }
            else if (operation == "f")
            {
                int res = 0;
                int a = int.Parse(tempNumber);
                for(int i = 2; i < a; i++)
                {
                    if (a % i == 0) res += i;
                }
                tempNumber = res.ToString();
            }
            else if (operation == "p")
            {
                int a = int.Parse(tempNumber);
                int count = 0;
                for( int i = 1; i <= a; i++)
                {
                    if (IsPrime(i)) count++;
                }
                tempNumber = count + "";
            }
        }
        double Factorial(double a)
        {
            int b = 1;
            if (a == 0) return 1;
            for(int i = 1; i <= a; i++)
            {
                b *= i;
            }
            return b;
        }
        bool IsPrime(int a)
        {
            if (a == 1) return false;
            for(int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
    }
}
