﻿using System;

namespace WardrobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wardrobe = {"hat", "hoodie", "jeans", "dress", "shirt" };
            string[] colors = {"red", "blue", "white", "green", "pink" };
            string[] patterns = {"lowery", "striped", "polka dot", "circles", "checkered" };

            Random rnd = new Random();

            Console.WriteLine("Would you like some fashion advice?");
            string userInput = Console.ReadLine();

            if(userInput == "no")
            {
                Console.WriteLine("Farewell!");
            }else
            {
                Console.WriteLine($"Today,you should wear " +
                $"{colors[rnd.Next(0, colors.Length)]} " +
                $"{patterns[rnd.Next(0, patterns.Length)]} " +
                $"{wardrobe[rnd.Next(0, wardrobe.Length)]} ");

            }


        }
    }
}
