using System;

namespace Calculator2._0
{
    public class EnteringNumbers
    {
        public int command;
        public double inputNumber;
        IAllMessage outputMessage = new AllMessage();

        public int commandBegin()
        {
            string input = Console.ReadLine();;
            if (!int.TryParse(input, out command))
            {
                outputMessage.MessageError();
                commandBegin();
            }

            while ((command < 0 || command > 4))
            {
                outputMessage.MessageError();
                input = Console.ReadLine();
                command = Int32.Parse(input);
            }

            return command;
        }

        public double commandInputNumbers()
        {
            outputMessage.MessageInput();
            string input = Console.ReadLine();
            if (!double.TryParse(input, out inputNumber))
            {
                outputMessage.MessageError();
                inputNumber = commandInputNumbers();
            }

            return inputNumber;
        }
    }
}