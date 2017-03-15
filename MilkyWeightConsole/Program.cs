using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyWeightConsole
{
    class Program
    {
        
        static double mercury = 0.37;
        static double venus = 0.88;
        static double mars = 0.38;          // Here I set up the conversion and variables, 
        static double jupiter = 2.64;       // I had to makes them static because of an error
        static double saturn = 1.15;        // in my results WriteLine..
        static double uranus = 1.15;
        static double neptune = 1.12;
        static double pluto = 0.04;

        static int planetChoice;
        static double earthWeight;
        static double spaceWeight;
        
        static void Main(string[] args)
        {                                   
            while (true)                    
            {
                try
                {       //menu and prompt for planet selection input
                    Console.Clear();
                    Console.WriteLine("             Menu of Planets \n             ===============");
                    Console.WriteLine("\n 1. Jupiter     2. Mars      3. Mercury \n 4. Neptune     5. Pluto     6. Saturn \n 7. Uranus      8. Venus     9. <Quit> ");
                    Console.Write("\n Enter your planet choice: ");
                    planetChoice = int.Parse(Console.ReadLine());
                    if (planetChoice == 9)              // breaks loop if 9 is chosen
                    {
                        Console.WriteLine("OK! Bye!");
                        Console.ReadLine();
                        break;
                    }                                                //verifies the user input is in correct range
                    else if (1 > planetChoice || 9 < planetChoice)  // prompts re-entry if it's not
                    {
                        Console.WriteLine(" Please enter an number from 1-9 to make your selection.");
                    }
                    else                   // if it is, prompt for Earth weight 
                    {                       // then it continues with the weight calculation using a switch 
                        Console.Write("\n Please, enter your weight on Earth in pounds: ");
                        earthWeight = double.Parse(Console.ReadLine());
                        spaceWeight = earthWeight;

                        switch (planetChoice)
                        {
                            case 1:
                                spaceWeight *= jupiter;
                                break;
                            case 2:
                                spaceWeight *= mars;
                                break;
                            case 3:
                                spaceWeight *= mercury;
                                break;
                            case 4:
                                spaceWeight *= neptune;
                                break;
                            case 5:
                                spaceWeight *= pluto;
                                break;
                            case 6:
                                spaceWeight *= saturn;
                                break;
                            case 7:
                                spaceWeight *= uranus;
                                break;
                            case 8:
                                spaceWeight *= venus;
                                break;
                        }
                    }                        // places the planet name in results line
                        String planet = "";
                        switch (planetChoice)
                        {
                            case 1:
                                planet = "Jupiter";
                                break;
                            case 2:
                                planet = "Mars";
                                break;
                            case 3:
                                planet = "Mercury";
                                break;
                            case 4:
                                planet = "Neptune";
                                break;
                            case 5:
                                planet = "Pluto";
                                break;
                            case 6:
                                planet = "Saturn";
                                break;
                            case 7:
                                planet = "Uranus";
                                break;
                            case 8:
                                planet = "Venus";
                                break;
                        }                     

                    Console.WriteLine("\n Your weight of " + earthWeight.ToString() + " pounds on Earth would be " + spaceWeight.ToString("0.0") + " pounds on " + planet + ".");
                    Console.ReadLine();
                }
                catch (System.FormatException) // *attempts* to catch incorrect inputs
                {
                    Console.WriteLine(" Whoops, please enter a number between 1-9 for menu choice or a number for your weight on Earth.");
                }
            }             
        }
    }
}
