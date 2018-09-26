using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcBT
{
    class Program
    {
        static void Main(string[] args)
        {
            //******************************************* Variable Declariation************************************************//
            // user input
            // variable 
            // we use camel notation
            int firstUserOption = 0;
            int calcuserOption = 0;
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;
            double Tax;
            //------------------- tax
            string firstName;
            string lastName;
            string Gender;
            double netPay;
            string userInput;
            double grossPay;
            double hrsWorked;
            double ovtWorked;
            double payWage;
            double taxFed;
            double taxSs;
            double FTAX = .028;
            double SSTAX = .0765;
            

            int grossUserOption = 0;



            //*****************************************Exit and Display Menu**************************************************//
            // Syntax of while

            /*  while(condition)
                 {
                 statement(s);
                 }                       */
            //***************************************************************************************************************//

            while (firstUserOption != 3)
            {
                firstUserOption = firstMenu();
                if (firstUserOption == 3)
                {
                    Console.WriteLine(" --------------- Thanks for using Hahu Applicaton ----------------------------");
                    Console.WriteLine(" ----------------- press any key to Exit ----------------------------");
                    Console.ReadKey(true);
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                if (firstUserOption == 1)

                {
                    while (calcuserOption != 5)
                    {
                        calcuserOption = CalcDisplaymenu();
                        if (calcuserOption == 5)
                        {
                            Console.WriteLine(" --------------- Thanks for using Hahu Applicaton ----------------------------");
                            Console.WriteLine(" ----------------- press any key to Exit ----------------------------");
                            Console.ReadKey(true);
                            return;
                        }
                       
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n PLEASE ENTER YOUR FIRST NUMBER THEN PRESS ENTER KEY");
                        firstNumber = getNumber();
                        Console.WriteLine("\n PLEASE ENTER YOUR SECOND NUMBER THEN PRESS ENTER KEY");
                        secondNumber = getNumber();

                        if (calcuserOption == 1)
                        {
                            result = firstNumber + secondNumber;
                        }
                        else if (calcuserOption == 2)
                        {
                            result = firstNumber - secondNumber;
                        }
                        else if (calcuserOption == 3)
                        {
                            result = firstNumber * secondNumber;
                        }
                        else if (calcuserOption == 4)
                        {
                            result = firstNumber / secondNumber;
                        }
                        else
                        {

                        }
                        Console.WriteLine("\n *****************************************************************************");
                        Console.WriteLine("\n              THE RESULT OF YOUR ACTION IS:   " + result);
                        Console.WriteLine(" \n\n----------------- To Continue please press any key ----------------------------");
                        Console.ReadKey(true);

                        Console.WriteLine("\n \n\n");

                        

                    }
                }
                // **********************************************  tax case ***********************************************//



                else if (firstUserOption == 2)

                {


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" -=--------------- Welcome to Tax calculator Application ---------------------=-");
                    Console.WriteLine(" ----------------- To Continue please press any key ----------------------------");
                    Console.ReadKey(true);
                    Console.WriteLine("\n PLEASE ENTER YOUR FIRST NAME");
                    Console.WriteLine("\n");
                    firstName = Console.ReadLine();

                    Console.WriteLine("\n PLEASE ENTER YOUR LAST NAME");
                    Console.WriteLine("\n");
                    lastName = Console.ReadLine();


                    status: Console.WriteLine("\n PLEASE SELECT YOUR MARITAL STATUS");
                    Console.WriteLine("\n 1. singe  2. married  3. divorced  4. separated  5. widow");
                    string s = Console.ReadLine();
                    string mStatus;
                    switch (s)
                    {
                        case "1": mStatus = "single"; break;
                        case "2": mStatus = "married"; break;
                        case "3": mStatus = "divorced"; break;
                        case "4": mStatus = "separated"; break;
                        case "5": mStatus = "widow"; break;
                        default:
                            Console.WriteLine("choose 1-5 please");
                            goto status;
                    }

                    Console.WriteLine("\n PLEASE SELECT YOUR GENDER");

                    char Sex;
                    Console.WriteLine("\n Sex(F=Female/M=Male): ");
                    Sex = char.Parse(Console.ReadLine());
                    {
                        if (Sex == 'f')
                            Gender = "Female";
                        else if (Sex == 'F')
                            Gender = "Female";
                        else if (Sex == 'm')
                            Gender = "Male";
                        else if (Sex == 'M')
                            Gender = "Male";
                        else
                            Gender = "Unknown";
                    }



                    Console.WriteLine("\n PLEASE SELECT YOUR TYPE OF SALARY");

                    Console.WriteLine("\n 1. Hourly Gross Pay  2. Salaried Gross Pay");
                    grossUserOption = int.Parse(Console.ReadLine());
                    if (grossUserOption == 1)
                    {



                        Console.Write("\n      PLEASE ENTER THE NUMBER OF HOURS WORKED THIS WEEK: ");
                        userInput = Console.ReadLine();
                        hrsWorked = Convert.ToDouble(userInput);

                        Console.Write("\n       PLEASE ENTER THE NUMBER OF OVERTIME HOURS WORKED THIS WEEK: ");
                        userInput = Console.ReadLine();
                        ovtWorked = Convert.ToInt32(userInput);

                        Console.Write("\n       PLEASE ENTER HOURLY WAGE: ");
                        userInput = Console.ReadLine();
                        payWage = Convert.ToDouble(userInput);

                        grossPay = (hrsWorked * payWage + ovtWorked * 1.5 * payWage);
                                               
                        
                            taxFed = FTAX * grossPay;

                            taxSs = SSTAX * grossPay;

                            netPay = taxFed + taxSs - grossPay;
                       
                       {
                            Console.WriteLine("\a\n\n **************** Thank you for calculating your Tax************************ ");
                            Console.WriteLine("\n Full Name: {0} {1}", firstName, lastName);
                            Console.WriteLine("\n Marital Status:  {0} ", mStatus);
                            Console.WriteLine("\n Gender:  {0} ", Gender);
                            Console.WriteLine("\n Gross pay:  {0:C2}", grossPay);
                            Console.WriteLine("\n Social security Tax: {0:C2}", taxSs);
                            Console.WriteLine("\n Federal Tax:  {0:C2}", taxFed);
                            Console.WriteLine("\n Net pay: {0:C2}", netPay);

                            Console.WriteLine("\n To continue press Enter................");
                            Console.WriteLine("\n*************************************************************************** ");

                            Console.ReadLine();

                            Console.WriteLine("\n \n \n");
                        }
                    }



                    else if (grossUserOption == 2)
                    {
                        Console.Write("PLEASE INPUT YOUR MONTHLY SALARY: ");
                        grossPay = double.Parse(Console.ReadLine());



                        if (grossPay < 1000)
                        {
                            Tax = grossPay * 0;
                        }
                        else if (grossPay > 1001 && 3400 > grossPay)
                        {
                            Tax = 0.1 * grossPay;
                        }
                        else if (grossPay > 3500 && grossPay < 8000)
                        {
                            Tax = 0.2 * grossPay;
                        }
                        else if (grossPay > 8001 && 12500 > grossPay)
                        {
                            Tax = 0.25 * grossPay;
                        }
                        else if (grossPay > 12501 && 100000 > grossPay)
                        {
                            Tax = 0.35 * grossPay;
                        }
                        else
                        {
                            Tax = 0.39 * grossPay;
                        }
                        {
                            netPay = grossPay - Tax;
                            Console.WriteLine("\n\n\n");


                        }

                        Console.WriteLine("\a ****************Thank you for calculating your Tax************************ ");
                        Console.WriteLine("\n Full Name: {0} {1}", firstName, lastName);
                        Console.WriteLine("\n Marital Status: {0} ", mStatus);
                        Console.WriteLine("\n Gender: {0} ", Gender);
                        Console.WriteLine("\n Gross pay:{0}", grossPay);
                        Console.WriteLine("\n The result of Your Income Tax is: {0} ", Tax);
                        Console.WriteLine("\n Net Pay =  {0}", netPay);
                        Console.WriteLine("\n To continue press Enter................");
                        Console.WriteLine("\n*************************************************************************** ");

                        Console.ReadLine();

                        Console.WriteLine("\n \n \n");
                    }

                }
            }
        }
        //***********************************************Get Number******************************************//

          private static int getNumber()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                return number;
            }
            catch
            {
                Console.WriteLine("Error in Input");
                return 0;
            }
            
           }

        //********************************************** First menu**************************************************//
             // @ - verbatim Literal

        private static int firstMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine (@"
            
            
                **   **     ***     **   **  **   **            
                **   **    ** **    **   **  **   **    
                *******   *******   *******  **   **
                **   **  **     **  **   **  **   **
                **   **  **     **  **   **  *******   "); 



            Console.WriteLine("\n \n \n ****************** WELCOME TO HAHU CALCULATOR CENTER ***********************");
            Console.WriteLine("\n 1. BASIC CALCULATOR" + Environment.NewLine +  "\n 2. TAX CALCULATOR" + Environment.NewLine + "\n 3. EXIT");
            Console.WriteLine("\n \n ******************************************************************************");

            // used to prevent the program crash
            // first message

            int firMes;
            try
            {
                firMes = int.Parse(Console.ReadLine());
            }
            catch
            {

                firMes = 0;
            }
            return firMes;
        }




        //***********************************************calculator Display Menu  ****************************************//
        // Display Menu

        private static int CalcDisplaymenu()
        {
            Console.WriteLine("\n ************************ Welcome to calculator Application *******************");
            Console.WriteLine("\n ******************* please choose the number you want to Calculate************");
            
            Console.WriteLine("\n 1. ADDITON" + Environment.NewLine + "\n 2. SUBSTRUCTION" + Environment.NewLine + "\n 3. MULTIPLICATION" + Environment.NewLine + "\n 4. DIVISION" + Environment.NewLine + "\n 5. Exit");
            Console.WriteLine("\n \n ******************************************************************************");

            // USED TO PERVENT THE PROGRAM TO BE CRASH
            int optionValue;
            try
            {
                optionValue = int.Parse(Console.ReadLine());
            }
            catch
            {

                optionValue = 0;
            }
            return optionValue;
        }

    }

}

