using System;

namespace StructDemo
{
    public struct MyStruct
    {
        private int _x;
        private int _y;
        private MyClass MyClass;
        private DayOfWeek _days;
        public MyStruct(int fNumber, int sNumber, int tNumber)
        {
            _x = fNumber;
            _y = sNumber;
            MyClass = new MyClass() { Number = tNumber };
            _days = DayOfWeek.Sunday;
        }

        public void PrintStatement()
        {
            Console.Write($"X = {_x} - Y = {_y} - Day = {_days}");
        }
    }
}
