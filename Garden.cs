using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class Garden
    {
        
        string gardenSize = "expansive";
        int numberOfAcres = 100;
        bool campusIsBeautiful = true;

        public Garden(string gardenSize, int numberOfAcres, bool campusIsBeautiful)
        {
            this.gardenSize = gardenSize;
            this.numberOfAcres = numberOfAcres;
            this.campusIsBeautiful = campusIsBeautiful;
        }

        public void DescribeGarden()
        {
            Console.WriteLine("This Garden is " + gardenSize +
            "! It must be " + numberOfAcres + " acres. Its " + campusIsBeautiful + " that this campus is beautiful.");
            GarNextAdv();
        }

        public void GarNextAdv()
        {
            Console.WriteLine("Where would you like to go next? Please choose Forest | Castle");
            string userInput = Console.ReadLine();
            Forest forest1 = new Forest("miles", 20, false);
            Castle castle3 = new Castle("enormous", 2000, true);
            if (userInput == "Forest")
            {
                forest1.DescribeForest();
            }
            else
            {
                castle3.DescribeCastle();
            }
        }

    }
}
