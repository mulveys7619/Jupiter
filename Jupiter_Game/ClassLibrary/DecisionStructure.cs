using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DecisionStructure
    {
    // Create method to validate if user inputs a valid option
        public static int MenuChoiceValidation(int choice, int max)
        {
            
            
            
            // Check to see if user inputs an int and that int is between the lowest (always 1) and highest number for choices
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > max)
            {
                // Inform user that input is invalid
                Console.WriteLine(StandardMessages.InputError());
            }
            // Return user input
            return choice;
        }
    }
}
