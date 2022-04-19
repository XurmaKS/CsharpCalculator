using System;

namespace Calculator2._0
{
    public class Data
    {
        public NumberForCalculate Numbers { get; set; }
        public Operation Operation { get; set; }


        public void GetANumberToSelectACommand()
    {
        IAllMessage outputMessage = new AllMessage();
        int numberToSelectACommand;
        string input = Console.ReadLine();
        if (!int.TryParse(input, out numberToSelectACommand) ||
            !Enum.IsDefined(typeof(Operation), numberToSelectACommand))
        {
            outputMessage.MessageError();
            input = Console.ReadLine();
            numberToSelectACommand = Int32.Parse(input);
        }

        Operation = (Operation) numberToSelectACommand;
    }
}

}