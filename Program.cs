using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("This campus has so much to explore! Where would you like to go first? Please choose Castle | Greenhouse");
            string userInput = Console.ReadLine();
            Castle castle1 = new Castle("enormous", 2000, true);
            Greenhouse greenhouse1 = new Greenhouse("huge", 1000, true);
            if (userInput == "Castle")
            {
                castle1.DescribeCastle();
            }
            else
            {
                greenhouse1.DescribeGreenhouse();
            }
        }
    }
}
