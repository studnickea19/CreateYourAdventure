using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class Greenhouse
    {
        
        string gHouseSize = "huge";
        int numberOfPlants = 1000;
        bool whatTheySay = true;
        
        public Greenhouse(string gHouseSize, int numberOfPlants, bool whatTheySay)
        {
            this.gHouseSize = gHouseSize;
            this.numberOfPlants = numberOfPlants;
            this.whatTheySay = whatTheySay;
        }

        public void DescribeGreenhouse()
        {
            Console.WriteLine("This Greenhouse is " + gHouseSize + 
            "! There must be " + numberOfPlants + " plants in here. I guess it's " + whatTheySay + " about Professor Sprout.");
            GhNextAdv();
        }

        public void GhNextAdv()
        {
            Console.WriteLine("Where would you like to go next? Please choose Garden | Castle");
            string userInput = Console.ReadLine();
            Garden garden1 = new Garden("expansive", 100, true);
            Castle castle2 = new Castle("enormous", 2000, true);
            if (userInput == "Garden")
            {
                garden1.DescribeGarden();
            }
            else
            {
                castle2.DescribeCastle();
            }
        }

    }
}
