using System;

namespace Calculator2._0
{
    public class MathOperation : IMathOperation

    {
        public double Addition(Data number)
        {
            //сложение
            return   number.Numbers.OneNumber + number.Numbers.TwoNumber;
           
        }

        public double Subtraction(Data number)
        {
            //вычитание
            return number.Numbers.OneNumber - number.Numbers.TwoNumber;
        }

        public double Multiplication(Data number)
        {
            //умножение
            return number.Numbers.OneNumber * number.Numbers.TwoNumber;
        }

        public double Division(Data number)
        {
            //деление
            double result = number.Numbers.OneNumber / number.Numbers.TwoNumber;
           
            if (number.Numbers.TwoNumber == 0)
            {
                throw new Exception("Invalid command");
            }

            return result;
        }
    }
}