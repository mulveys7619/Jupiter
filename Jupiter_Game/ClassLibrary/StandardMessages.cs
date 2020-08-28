using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StandardMessages
    {
        // Create Method to hold Start Menu string
        public static string StartMenu()
        {
            return "Please select an option from the menu below\n" +
                  "===========================================\n" +
                  "1. Enter Dungeon\n" +
                  "2. Game Information\n" +
                  "3. Exit\n";
        }
        // Create Method to hold info menu string
        public static string InfoMenu()
        {
            return "This menu provides information on various aspects of Jupiter\n" +
            "------------------------------------------------------------------------------\n" +
            "Select an option from the menu below to learn more about it.\n" +
            "==============================================================================\n" +
            "1. Beginner Classes\n" +
            "2. Dungeon Rooms\n" +
            "3. Potions\n" +
            "4. Treasure\n" +
            "5. Items\n" +
            "6. Weapons\n" +
            "7. Abilities\n" +
            "8. Enemies\n" +
            "9. Stats\n" +
            "10. Exit\n" +
            "Please select an option (1-10): ";
        }
        
        // Create method to hold input error message
        public static string InputError()
        {
            return "ERROR: Please Input A Valid Value!";
        }
        // Create method to hold string for critical hit taken
        public static String CritHitTaken(int damage)
        {
            return "You were critically hit for " + damage + " points!";
        }
        // Create method to hold string for normal hit taken
        public static String NormHitTaken(int damage)
        {
            return "You were dealt " + damage + " points of damage";
        }
        // Create method to hold string for critical hit dealt
        public static String CritHitDealt(int damage)
        {
            return "You critically hit for " + damage + " points!";
        }
        // Create method to hold string for normal hit taken
        public static String NormHitDealt(int damage)
        {
            return "You  dealt " + damage + " points of damage";
        }
        // Create method to hold string to ask player if they want to leave the dungeon
        public static String LeaveDungeon()
        {
            return "You are in the start room.\n" +
                "Are you sure you would like to exit the dungeon?(y/n):";
        }
        
    }
}
