using System;

namespace Calculator2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            IAllMessage message = new AllMessage();
            IMathOperation mathOperation = new MathOperation();
            Calculations calculations = new Calculations(mathOperation);
            EnteringNumbers enteringNumbers = new EnteringNumbers();


            while (true) {
                try {
                    message.MessageBeginningOfWork();
                    enteringNumbers.commandBegin();
                    var result = calculations.Calculate(enteringNumbers);
                    message.ResultOperation();
                    Console.WriteLine(result);

                }
                catch (Exception e){
                    Console.WriteLine(e.Message); 
                }
            }
        }
    }
}