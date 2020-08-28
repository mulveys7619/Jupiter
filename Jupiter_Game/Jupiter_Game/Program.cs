using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Jupiter_Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int userChoice = 0;
            Console.WriteLine(StandardMessages.StartMenu());
            userChoice = DecisionStructure.MenuChoiceValidation(userChoice, 3);
        }
    }
}
