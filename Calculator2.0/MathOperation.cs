using System;

namespace Calculator2._0
{
    public class MathOperation: IMathOperation
    {
        
        public double addition(double numOne, double numTwo)
        {
            //сложение
            return numOne + numTwo;
        }

        public double subtraction(double numOne, double numTwo)
        {
            //вычитание
            return numOne - numTwo;
        }

        public double multiplication(double numOne, double numTwo)
        {
            //умножение
            return numOne * numTwo;

        }

        public double division(double numOne, double numTwo)
        {
            //деление
            double result = numOne / numTwo;
            if (numTwo == 0)
            {
                throw new Exception("Invalid command");
            }

            return result;

        }
    }
}