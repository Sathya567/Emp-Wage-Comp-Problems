using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class UC_1_EmpAttendance
    {
        public static void EmpAttendance()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int result = random.Next(0, 2);
            if (result == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();
        }
    }
}
