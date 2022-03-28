using System;

namespace Calculator2._0
{
    public class AllMessage: IAllMessage
    {
        public void MessageBeginningOfWork() {
            Console.WriteLine("Привет! Я приложение калькулятор, пожалуйста, выберите одну из команд: " +
                              "\n1 - сложение; \n2 - вычитание; \n3 - умножение; \n4 - деление.");
        }

        public void MessageError() {
            Console.WriteLine("ошибка, попробуйте еще раз ");
        }

        public void MessageInput() {
            Console.WriteLine("Введите число");
        }


        public void ResultOperation() {
            Console.WriteLine("Итог");
        }
    }
}