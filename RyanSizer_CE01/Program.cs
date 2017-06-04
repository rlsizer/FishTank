using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanSizer_CE01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ryan Sizer
            Section 01
            Advanced Scalable Data Infrastructures
            06/03/2017
            Big Blue Fish
            */

            Console.WriteLine("Welcome to Big Blue Fish!\r\n\r\nThis is a simple program where you can search for the lengthiest fish by color.\r\nGo ahead, give it a try!");
            Console.WriteLine();

            //Create do while loop to keep program running until user chooses to quit
            do
            {

                //TODO fill this out with more options to interact with the pet
                //Added seven menu options for user
                Console.WriteLine();
                Console.WriteLine("The Fish Tank");
                Console.WriteLine("\r\n\r\nPlease select a color of fish:");
                Console.WriteLine("1 - Red");
                Console.WriteLine("2 - Blue");
                Console.WriteLine("3 - Green");
                Console.WriteLine("4 - Yellow");
                Console.WriteLine("5 - QUIT");
                Console.WriteLine();
                Console.Write("> ");

                //Declare int variable for user menu selection 
                int colorChoice;

                //Capture the user response and store it in a string variable
                string colorChoiceString = Console.ReadLine();

                //Make sure that user enters a number for the menu choice
                //Create a conditional to test out validation of the problem
                while (!(int.TryParse(colorChoiceString, out colorChoice)))
                {
                    //Tell user what went wrong and that it was unable to convert
                    Console.WriteLine("Oops! You typed in something other than the corresponding menu choice number of 1 through 5.\r\nPlease input your number selection and press enter:");

                    //Re-capture the user response
                    colorChoiceString = Console.ReadLine();

                    //Re-convert captured string response to an integer
                    int.TryParse(colorChoiceString, out colorChoice);

                }

                while (colorChoice < 1 || colorChoice > 5)
                {
                    //Tell user what went wrong and that it was unable to proceed
                    Console.WriteLine("Oops! You typed in a number that does not correspond to the menu choice numbers of 1 through 5.\r\nPlease input your number selection and press enter:");

                    //Re-capture the user response
                    colorChoiceString = Console.ReadLine();

                    //Re-convert captured string response to an integer
                    int.TryParse(colorChoiceString, out colorChoice);
                }
                //Declare and define an array for the fish colors
                string[] fishColors = new string[12] { "red", "blue", "green", "yellow", "red", "blue", "blue", "green", "yellow", "red", "blue", "green" };

                //Declare and define an array for the fish lengths
                float[] fishLength = new float[12] { 3.755F, 8.881F, 6.5F, 1.95F, 3.001F, 17.233F, 9.991F, 6.777F, 5.15F, 4.9F, 4.25F, 8.005F };

                //Add Console.Clear() to clean up the user interface
                Console.Clear();
                
                //use switch case to determine reactions to user selections
                switch (colorChoice)
                {
                    //when the user selects option one we feed the pet
                    case 1:
                        //Declare and define variable for red fish length
                        float redFishLength = 0;

                        //Create an index
                        int i = 0;

                        //Create while loop to compare colors array with length array and determine top length for particular color
                        while (i < fishColors.Length)
                        {
                            if (fishColors[i] == fishColors[0] && fishLength[i] > redFishLength)
                            {

                                redFishLength = fishLength[i];
                            }
                            i++;
                        }
                        
                        //Keep user informed; display result to user
                        Console.WriteLine("\r\n\r\nYou selected the color red.");
                        Console.WriteLine();
                        Console.WriteLine("\r\n\r\nThe biggest {0} fish has a length of {1} feet.", fishColors[0], redFishLength);
                        break;

                    //TODO we need to add more cases for the other ways to interact with our pet
                    //when the user selects option two we give tiger a drink
                    case 2:
                        //Declare and define variable for blue fish length
                        float blueFishLength = 0;

                        //Create an index
                        int i2 = 0;

                        //Create while loop to compare colors array with length array and determine top length for particular color
                        while (i2 < fishColors.Length)
                        {
                            if (fishColors[i2] == fishColors[1] && fishLength[i2] > blueFishLength)
                            {

                                blueFishLength = fishLength[i2];
                            }
                            i2++;
                        }

                        //Keep user informed; display result to user
                        Console.WriteLine("\r\n\r\nYou selected the color blue.");
                        Console.WriteLine();
                        Console.WriteLine("\r\n\r\nThe biggest {0} fish has a length of {1} feet.", fishColors[1], blueFishLength);
                        break;

                    case 3:
                        //Declare and define variable for green fish length
                        float greenFishLength = 0;

                        //Create an index
                        int i3 = 0;

                        //Create while loop to compare colors array with length array and determine top length for particular color
                        while (i3 < fishColors.Length)
                        {
                            if (fishColors[i3] == fishColors[2] && fishLength[i3] > greenFishLength)
                            {

                                greenFishLength = fishLength[i3];
                            }
                            i3++;
                        }

                        //Keep user informed; display result to user
                        Console.WriteLine("\r\n\r\nYou selected the color green.");
                        Console.WriteLine();
                        Console.WriteLine("\r\n\r\nThe biggest {0} fish has a length of {1} feet.", fishColors[2], greenFishLength);
                        break;


                    case 4:
                        //Declare and define variable for yellow fish length
                        float yellowFishLength = 0;

                        //Create an index
                        int i4 = 0;

                        //Create while loop to compare colors array with length array and determine top length for particular color
                        while (i4 < fishColors.Length)
                        {
                            if (fishColors[i4] == fishColors[3] && fishLength[i4] > yellowFishLength)
                            {

                                yellowFishLength = fishLength[i4];
                            }
                            i4++;
                        }

                        //Keep user informed; display result to user
                        Console.WriteLine("\r\n\r\nYou selected the color yellow.");
                        Console.WriteLine();
                        Console.WriteLine("\r\n\r\nThe biggest {0} fish has a length of {1} feet.", fishColors[3], yellowFishLength);
                        break;



                    case 5:
                        //Display goodbye message for user
                        Console.WriteLine("\r\n\r\nThank you for checking out the fish tank!");
                        return;

                    default:

                        break;
                }


            } while (true);









        }
    }
}
