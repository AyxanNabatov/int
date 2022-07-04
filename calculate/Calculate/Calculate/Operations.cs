using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    public class Operations : ICalculate
    {
        public void Calculation(int num1, int num2, string operation)
        {
            throw new NotImplementedException();
        }

        public void Calculator(int num1, int num2, string Operation)
        {
            if (Operation == "+")
            {
                Console.WriteLine(num1 + num2);
            }

            if (Operation == "-")
            {
                Console.WriteLine(num1 - num1);
            }

            if (Operation == "*")
            {
                Console.WriteLine(num1 * num2);
            }

            if (Operation == "/")
            {
                Console.WriteLine(num1 / num2);
            }
        }
    }
}
