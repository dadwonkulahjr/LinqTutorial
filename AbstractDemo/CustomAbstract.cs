using System;

namespace AbstractDemo
{
    public abstract class CustomAbstract
    {
        private string _message = "Hi, C# Developer";
        public abstract void PrintAbstractMessage();

        public void PrintMessage()
        {
            Console.WriteLine(_message);
        }
    }
}
