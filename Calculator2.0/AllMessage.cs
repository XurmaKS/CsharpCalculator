using System;
using System.Collections.Generic;

namespace Calculator2._0
{
    public class AllMessage : IAllMessage
    {
        public void MessageBeginningOfWork()
        {

            Console.WriteLine($"Привет! Я приложение калькулятор, пожалуйста, выберите одну из команд: ");
            GetEnum();
        }

        public void MessageError()
        {
            Console.WriteLine("ошибка, попробуйте еще раз ");
        }

        public void MessageInput()
        {
            Console.WriteLine("Введите число");
        }

         public void ResultOperation(double result)
        {
            Console.WriteLine("Итог " + result);
        }

        private void GetEnum()
        {
            Dictionary<int, string> list = new Dictionary<int, string>(ListEnum.EnumList());
            foreach (var key in list)
            {
             Console.WriteLine(key.Key + " -> " + key.Value);
            }
        }
    }
    
}