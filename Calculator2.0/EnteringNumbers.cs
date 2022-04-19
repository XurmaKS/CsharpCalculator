using System;

namespace Calculator2._0
{
    static class EnteringNumbers
    {
        static double InputNumber;

        public static NumberForCalculate GetNumbersForCalculations()
        {
           NumberForCalculate numberForCalculate = new NumberForCalculate();
            numberForCalculate.OneNumber = GetNumberForOperations();
            numberForCalculate.TwoNumber = GetNumberForOperations();
            return numberForCalculate;
        }

        public static double GetNumberForOperations()
        {
            IAllMessage _outputMessage = new AllMessage();
            _outputMessage.MessageInput();
            string input = Console.ReadLine();
            if (double.TryParse(input, out InputNumber)) return InputNumber;
            _outputMessage.MessageError();
            InputNumber = GetNumberForOperations();

            return InputNumber;
        }
    }
}