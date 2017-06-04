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


            //Declare and define an array for the fish colors
            string[] fishColors = new string[12] { "red", "blue", "green", "yellow", "red", "blue", "blue", "green", "yellow", "red", "blue", "green" };

            //Declare and define an array for the fish lengths
            float[] fishLength = new float[12] { 3.755F, 8.881F, 6.5F, 1.95F, 3.001F, 17.233F, 9.991F, 6.777F, 5.15F, 4.9F, 4.25F, 8.005F };

           

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

            //use switch case to determine reactions to user selections
            switch (colorChoice)
            {
                //when the user selects option one we feed the pet
                case 1:

                    Console.WriteLine("\r\n\r\nYou selected the color red.");
                    break;

                //TODO we need to add more cases for the other ways to interact with our pet
                //when the user selects option two we give tiger a drink
                case 2:

                    Console.WriteLine("\r\n\r\nYou selected the color blue.");
                    break;

                case 3:

                    Console.WriteLine("\r\n\r\nYou selected the color green.");
                    break;

                case 4:

                    Console.WriteLine("\r\n\r\nYou selected the color yellow.");
                    break;


                case 5:

                    Console.WriteLine("\r\n\r\nThank you for checking out the fish tank!");
                    return;

                default:
                    Console.WriteLine("\r\n\r\nInvalid menu selection.");
                    break;
            }

           


                


    



            
        }
    }
}
