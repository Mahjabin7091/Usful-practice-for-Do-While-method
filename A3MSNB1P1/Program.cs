/*
 * Purpose: Do while loop 
 * Author: Mahjabin Sajadi
 * Date: winter 2021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3MSNB1P1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Define Variables*/
            
            bool flag_main,flag_option_2_1, flag_option_2_2, flag_option_2_exit, flag_option_3;
            string Option_0_string;
            string Number_1_string;
            string Number_2_string;
            
            int  j;
            int even_num;
            int odd_num;
            int Out_Put;
            double Number_1_int;
            double Number_2_int;
            double result_1;

            /*Initial Variables*/
            flag_main = true;
            flag_option_2_1 = true;
            flag_option_2_2 = true;
            flag_option_2_exit = true;

            Option_0_string = "";
            Number_1_string = "";
            Number_2_string = "";
                       
            Number_1_int = 0.0;
            Number_2_int = 0.0;
            even_num = 0;
            odd_num = 0;
            Out_Put = 0;
            result_1 = 0.0;

            /*get option the process at the first time; Do loop*/
            do
            {
                /*Process*/
                Console.WriteLine("Please choose on of the options and write: Option_1 or Option_2 or Option_3 or numbers");
                Console.WriteLine("Option_1: Calculation");
                Console.WriteLine("Option_2: Divid Two Numbers");
                Console.WriteLine("Option_3: Exit Program");
                Option_0_string = Console.ReadLine();

                flag_option_2_1 = true;   // checking for enter correct number one
                flag_option_2_2 = true;   // checking for enter correct number two



                switch (Option_0_string)
                {
                    case "1":

                        /* Option_1: Calculation and displey numbers; for*/

                        for (j = 1; j <= 25; j++)
                        {
                            if (j % 2 != 0)
                            {
                                odd_num = j + 7;    /* odd num + 7; */

                                if (j == 3 || j == 11 || j == 21)
                                {
                                    Out_Put = odd_num - 3;
                                    Console.WriteLine("Nnmber " + j + " is odd and also is in spacial number list: " + Out_Put); // spacial list number is : 3,11,21
                                }
                                else
                                    Console.WriteLine("Number " + j + " is odd and the result is: " + odd_num);

                            }
                            else if (j % 2 == 0)
                            {
                                even_num = j * 4;   /* even_num * 4; */
                                Console.WriteLine("Number " + j + " is even and the result is: " + even_num);
                            }

                        }

                        break;
                        
                    case "2":

                        while (flag_option_2_1)
                        {
                            try
                            {
                                Console.WriteLine("Option 2");
                                Console.WriteLine("Enter the first number: ");
                                Console.WriteLine("You can Type END to exit the program");
                                Number_1_string = Console.ReadLine();

                                if (Number_1_string == "END")
                                {
                                    //flag_option_2_exit = false;
                                    flag_option_2_1 = false;
                                    flag_main = false;
                                    flag_option_2_2 = false;
                                }

                                else
                                {
                                    Number_1_int = int.Parse(Number_1_string);
                                    flag_option_2_1 = false;
                                }
                            }
                            catch (FormatException fEx)
                            {
                                Console.WriteLine("The input is incorrect,Enter number again: ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (OverflowException oEx)
                            {
                                Console.WriteLine("the number should be smaller: ");
                                Console.ReadKey();
                            }
                            catch (DivideByZeroException dEx)
                            {
                                Console.WriteLine("Dividing by zero is not allowed, the second number should not be zero. ");
                                Console.ReadKey();
                            }
                        }
                        while(flag_option_2_2)
                        { 
                            try
                            {
                                Console.WriteLine("Please Enter second number: ");
                                Console.WriteLine("You can Type END to exit the program");

                                Number_2_string = Console.ReadLine();
                                if (Number_2_string == "END")
                                {
                                    flag_option_2_2 = false;
                                    flag_main = false;
                                }


                                else
                                {
                                    Number_2_int = int.Parse(Number_2_string);

                                    result_1 = Number_1_int / Number_2_int;
                                    Console.WriteLine("The result is: " + result_1);

                                }

                            }

                            catch (FormatException fEx)
                            {
                                Console.WriteLine("The input is incorrect,Enter number again: ");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (OverflowException oEx)
                            {
                                Console.WriteLine("the number should be smaller: ");
                                Console.ReadKey();
                            }
                            catch (DivideByZeroException dEx)
                            {
                                Console.WriteLine("Dividing by zero is not allowed, the second number should not be zero. ");
                                Console.ReadKey();
                            }
                           
                        }
                       

                        break;

                    case "3":
                        Console.WriteLine("Option 3,Exit Program");
                        Console.WriteLine("Thank YOu");
                       flag_main = false;
                                          
                        break;

                        default:
                            Console.WriteLine("invalid option " + Option_0_string);
                           // flag_main = false;
                            break;

                 }
  
            }
            while (flag_main);
            
            //Console.ReadKey();

        }
        
    }
}
