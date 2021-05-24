using System;

namespace CSWeek2Module4
{
    class Program
    {
        static void Main()
        {
            DateTime date1 = new DateTime(2021,01,01);
            DateTime date2 = new DateTime(2021,12,31);

            if (date1 < date2)
            {
                Console.WriteLine("Date 2 is grater");
            }
            else
            {
                Console.WriteLine("Date 1 is grater");
            }
        }
    }
}
