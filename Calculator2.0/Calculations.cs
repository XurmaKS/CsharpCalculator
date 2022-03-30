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

        public double Calculate(Operations operations)
        {
            var enteringNumbers = new EnteringNumbers();
            switch (operations)
            {
                case Operations.Addition:

                    return MathOperation.Addition(enteringNumbers.GetNumbersForCalculations());

                case Operations.Subtraction:
                    return MathOperation.Subtraction(enteringNumbers.GetNumbersForCalculations());

                case Operations.Multiplication:
                    return MathOperation.Multiplication(enteringNumbers.GetNumbersForCalculations());

                case Operations.Division:
                    return MathOperation.Division(enteringNumbers.GetNumbersForCalculations());

                default:
                    throw new Exception("Invalid command");
            }
        }

        public static Operations GettingANumberToSelectACommand()
        {
            IAllMessage outputMessage = new AllMessage();
            int numberToSelectACommand;
            string input = Console.ReadLine();
            if (!int.TryParse(input, out numberToSelectACommand) ||
                !Enum.IsDefined(typeof(Operations), numberToSelectACommand))
            {
                outputMessage.MessageError();
                input = Console.ReadLine();
                numberToSelectACommand = Int32.Parse(input);
            }
            return (Operations) numberToSelectACommand;
        }

        public enum Operations
        {
            Addition = 1,
            Subtraction = 2,
            Multiplication = 3,
            Division = 4
        }
    }
}