using System;

namespace Calculator2._0
{
    public class EnteringNumbers
    {
        public double InputNumber;
        IAllMessage _outputMessage = new AllMessage();
        
        public Data GetNumbersForCalculations()
        {
            Data datanum = new Data();
            datanum.Numbers = new NumberForCalculate();
            datanum.Numbers.OneNumber = GetNumberForOperations();
            datanum.Numbers.TwoNumber = GetNumberForOperations();
            return datanum;
        }

        private double GetNumberForOperations()
        {
            _outputMessage.MessageInput();
            string input = Console.ReadLine();
            if (double.TryParse(input, out InputNumber)) return InputNumber;
            _outputMessage.MessageError();
            InputNumber = GetNumberForOperations();

            return InputNumber;
        }
    }
}