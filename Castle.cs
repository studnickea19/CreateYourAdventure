using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourAdventure
{
    class Castle
    {
        
        string castleSize = "enormous";
        int ageOfCastle = 2000;
        bool castleIsMysterious = true;

        public Castle(string castleSize, int ageOfCastle, bool castleIsMysterious)
        {
            this.castleSize = castleSize;
            this.ageOfCastle = ageOfCastle;
            this.castleIsMysterious = castleIsMysterious;
        }

        public void DescribeCastle()
        {
            Console.WriteLine("This Castle is " + castleSize +
            "! I bet it was built " + ageOfCastle + " years ago. Its " + castleIsMysterious + " that this place is mysterious.");
            CastNextAdv();
        }

        public void CastNextAdv()
        {
            Console.WriteLine("Where would you like to go next? Please choose Forest | Library");
            string userInput = Console.ReadLine();
            Forest forest1 = new Forest("miles", 20, false);
            if (userInput == "Forest")
            {
                forest1.DescribeForest();
            }
            else
            {
                Console.WriteLine("The Library is under construction, please move on to the Forest");
                CastNextAdv();
            }
        }

    }
}
