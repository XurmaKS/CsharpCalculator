using System;

namespace Calculator2._0
{
    public class EnteringNumbers
    {
        public double InputNumber;
        IAllMessage _outputMessage = new AllMessage();

        // public double[] GetTwoValuesForCalculations()
        // {
        //     double[] arrayOfNumbersToCalculate = new double [2];
        //     for (int i = 0; i < arrayOfNumbersToCalculate.Length; i++)
        //     {
        //         arrayOfNumbersToCalculate[i] = GetNumberForOperations();
        //     }
        //
        //     return arrayOfNumbersToCalculate;
        // }

        public NumberForCalculate GetNumbersForCalculations()
        {
            NumberForCalculate numberForCalculate = new NumberForCalculate();
            numberForCalculate.OneNumber = GetNumberForOperations();
            numberForCalculate.TwoNumber = GetNumberForOperations();
            return numberForCalculate;
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