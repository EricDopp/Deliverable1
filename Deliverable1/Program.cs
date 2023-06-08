// See https://aka.ms/new-console-template for more information
using System;
					
public class Program
{
    public static void Main()
    {
        int SodasStock = 100;
        int SodasRestock = 40;

        int ChipsStock = 40;
        int ChipsRestock = 20;

        int CandyStock = 60;
        int CandyRestock = 40;


        Console.WriteLine("How many Sodas have been sold today? " + SodasStock + " in stock");
        string inputSoda = Console.ReadLine();
        int SodasSold = int.Parse(inputSoda);

        if (SodasSold > SodasStock)
        {
            Console.Write("That value is too high. Stock not adjusted");
        }
        else
        {
            SodasStock -= SodasSold;
            Console.WriteLine("There are " + SodasStock + " left");


            Console.WriteLine("How many Chips have been sold today? " + ChipsStock + " in stock");
            string inputChips = Console.ReadLine();
            int ChipsSold = int.Parse(inputChips);

            if (ChipsSold > ChipsStock)
            {
                Console.Write("That value is too high. Stock not adjusted");
            }
            else
            {
                ChipsStock -= ChipsSold;
                Console.WriteLine("There are " + ChipsStock + " left");


                Console.WriteLine("How many Candy have been sold today? " + CandyStock + " in stock");
                string inputCandy = Console.ReadLine();
                int CandySold = int.Parse(inputChips);

                if (CandySold > CandyStock)
                {
                    Console.Write("That value is too high. Stock not adjusted");
                }
                else
                {
                    CandyStock -= CandySold;
                    Console.WriteLine("There are " + CandyStock + " left");


                    Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");
                    if (SodasStock <= SodasRestock)
                        Console.WriteLine("Sodas needs to be restocked");
                    if (ChipsStock <= ChipsRestock)
                        Console.WriteLine("Chips needs to be restocked");
                    if (CandyStock <= CandyRestock)
                        Console.WriteLine("Candy needs to be restocked");
                }
            }
        }
    }
}