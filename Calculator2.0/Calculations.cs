using System;

namespace Calculator2._0
{
    public class Calculations
    {
        public IMathOperation mathOperation;

        public Calculations(IMathOperation mathOperation)
        {
            this.mathOperation = mathOperation;
        }

        public double Calculate(EnteringNumbers enteringNumbers)
        {
            switch (enteringNumbers.command)
            {
                case 1:

                    return mathOperation.addition(enteringNumbers.commandInputNumbers(),
                        enteringNumbers.commandInputNumbers());
                
                case 2:
                    return mathOperation.subtraction(enteringNumbers.commandInputNumbers(),
                        enteringNumbers.commandInputNumbers());
                
                case 3:
                    return mathOperation.multiplication(enteringNumbers.commandInputNumbers(),
                        enteringNumbers.commandInputNumbers());
                
                case 4:
                    return mathOperation.division(enteringNumbers.commandInputNumbers(),
                        enteringNumbers.commandInputNumbers());
                
                default:
                    throw new Exception("Invalid command");
            }
        }
    }
}