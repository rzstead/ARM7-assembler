using System;
using System.Collections.Generic;
using System.Text;

namespace ARMAssembler
{
    class Input
    {
        public static string Prompt(int pos)
        {
            Console.WriteLine($"{pos}. ");
            return Console.ReadLine();
        }
    }
}
