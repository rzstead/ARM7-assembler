using System;

namespace ARMAssembler
{
    public class Parser
    {
        //instruction destination source value

        static void Main(string[] args)
        {
            Parser p = new Parser();
            p.Prompter();
        }

        private void Prompter()
        {
            Console.WriteLine("Start of parser");
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("Enter your ARM instructions per line.");
                
            }
        }

    }
}
