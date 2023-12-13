using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsUserInput_H1.Classes
{
    public class Methods
    {
        public int GetIntFromUserException(string text)
        {
            while (true)
            {
                Console.WriteLine(text);
                string input = Console.ReadLine();
                try
                {
                    return int.Parse(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Det virkede ikke");
                }
            }
        }
        public int GetIntFromUserTryParse(string text)
        {
            while (true)
            {
                Console.WriteLine(text);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine("Det virkede");
                }
                else
                {
                    Console.WriteLine("Indtast en integer");
                    Console.WriteLine("Det virkede ikke");
                }
                return result;
            }
        }
    }
}
