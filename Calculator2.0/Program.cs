using System;

namespace Calculator2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            IAllMessage message = new AllMessage();
            MathOperation _mathOperation = new MathOperation();
            Calculations _calculations = new Calculations(_mathOperation);


            while (true)
            {
                try
                {
                    Data data = new Data();
                    message.MessageBeginningOfWork();
                    data.GetANumberToSelectACommand();
                    data.Numbers = EnteringNumbers.GetNumbersForCalculations();
                    var result = _calculations.Calculate(data);
                    message.ResultOperation(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}