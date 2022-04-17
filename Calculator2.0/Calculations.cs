using System;


namespace Calculator2._0
{
    public class Calculations
    {
        public IMathOperation MathOperation;

        public Calculations(IMathOperation mathOperation)
        {
            MathOperation = mathOperation;
        }

        public double Calculate(Data data)
        {
        switch (data.Operation)
            {
                case Operation.Addition:

                    return MathOperation.Addition(data.Numbers);

                case Operation.Subtraction:
                    return MathOperation.Subtraction(data.Numbers);

                case Operation.Multiplication:
                    return MathOperation.Multiplication(data.Numbers);

                case Operation.Division:
                    return MathOperation.Division(data.Numbers);

                default:
                    throw new Exception("Invalid command");
            }
        }

        

       
    }
}