using System;

namespace Calculator2._0
{
    public class MathOperation : IMathOperation

    {
        public double Addition(NumberForCalculate number)
        {
            //сложение
            return number.OneNumber + number.TwoNumber;
        }

        public double Subtraction(NumberForCalculate number)
        {
            //вычитание
            return number.OneNumber - number.TwoNumber;
        }

        public double Multiplication(NumberForCalculate number)
        {
            //умножение
            return number.OneNumber * number.TwoNumber;
        }

        public double Division(NumberForCalculate number)
        {
            //деление
            if (number.TwoNumber == 0) 
            {
                throw new Exception("Invalid command");
            }

            double result = number.OneNumber / number.TwoNumber;


            return result;
        }
    }
}