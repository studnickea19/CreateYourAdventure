using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class Forest
    {
        
        string forestGoesFor = "miles";
        int yearsCouldWalk = 20;
        bool forestIsScary = false;

        public Forest(string forestGoesFor, int yearsCouldWalk, bool forestIsScary)
        {
            this.forestGoesFor = forestGoesFor;
            this.yearsCouldWalk = yearsCouldWalk;
            this.forestIsScary = forestIsScary;
        }

        public void DescribeForest()
        {
            Console.WriteLine("This Forest goes for " + forestGoesFor +
            "! I bet you could walk for " + yearsCouldWalk + " years before you reach the other side. Ive heard that this forest is scary, but I think that is " + forestIsScary + ".");
            ForestNextAdv();
        }

        public void ForestNextAdv()
        {
            Console.WriteLine("Where would you like to go next? Please choose Greenhouse | Library");
            string userInput = Console.ReadLine();
            Greenhouse greenhouse1 = new Greenhouse("huge", 1000, true);
            if (userInput == "Greenhouse")
            {
                greenhouse1.DescribeGreenhouse();
            }
             else
             {
                Console.WriteLine("The Library is under construction, please move on to the Greenhouse");
                ForestNextAdv();
             }
        }
    }
}
