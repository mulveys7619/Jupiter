using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class RoomData
    {
        // Create method to use RNG to get direction user enters dungeon from
        public static String Start()
        {
            // Create RNG object
            Random random = new Random();
            // Compare outcome of RNG for a number between 1 and 4
            switch (random.Next(1,4))
            {
                // If RNG is 1, set return value to "North"
                case 1:
                    return "North";
                    break;
                // If RNG is 2, set return value to "South"
                case 2:
                    return "South";
                    break;
                // If RNG is 3, set return value to "East"
                case 3:
                    return "East";
                    break;
                // If RNG is 4, set return value to "West"
                case 4:
                    return "West";
                // Set default value so all paths return a string, even though RNG will always be from 1 to 4
                default:
                    return "";
                    break;

            }
        }
    }
}
