using System;

namespace csharp_es03_mattina // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                ShowMessage.AppendMessage("Esempio di testo casuale per vedere se funziona il programma");

                int value;
                string sValue = Console.ReadLine();
                value = Convert.ToInt32(sValue);
                while (value != 0)
                {
                    Console.WriteLine(Pencil.Add(value));
                    sValue = Console.ReadLine();
                    value = Convert.ToInt32(sValue);
                }


                /*
                while (int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine(Pencil.Add(value));
                }
                */
            }


            {
                Bank bank1 = new Bank();
                Bank bank2 = new Bank();
                int value;

                while (int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("1: {0}", bank1.Add(value));
                    value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2: {0}", bank2.Add(value));
                }
            }
        }
    }
}