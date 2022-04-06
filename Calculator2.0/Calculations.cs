using System;
using System.Collections.Generic;
using System.Linq;

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

                    return MathOperation.Addition(data.Entering.GetNumbersForCalculations());

                case Operation.Subtraction:
                    return MathOperation.Subtraction(data.Entering.GetNumbersForCalculations());

                case Operation.Multiplication:
                    return MathOperation.Multiplication(data.Entering.GetNumbersForCalculations());

                case Operation.Division:
                    return MathOperation.Division(data.Entering.GetNumbersForCalculations());

                default:
                    throw new Exception("Invalid command");
            }
        }

        

        public static Dictionary<int, string> EnumList()
        {
            return Enum.GetValues(typeof(Operation)).Cast<Operation>()
                .ToDictionary(operation => (int) operation, operation => operation.ToString());
        }
    }
}