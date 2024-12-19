using System;
using Microsoft.VisualBasic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("---------------------");

            bool correctInput = false;

            while (!correctInput)
            {
                Console.WriteLine("Input temperature to be converted: ");
                string inputTemperatureStr = Console.ReadLine();

                if (double.TryParse(inputTemperatureStr, out double inputTemperature))
                {
                    correctInput = true;

                    Console.WriteLine("Input scale to be converted from: ");
                    string inputScale = Console.ReadLine().ToLower();

                    Console.WriteLine("Input scale temperature to be converted to: ");
                    string requiredScale = Console.ReadLine().ToLower();

                    switch (inputScale)
                    {
                        case "fahrenheit":

                            switch (requiredScale)
                            {
                                case "kelvin":
                                    double conversion1 = (inputTemperature - 32) * 5 / 9 + 273.15;
                                    Console.WriteLine($"{conversion1} degrees Kelvin");
                                    break;

                                case "celsius":
                                    double conversion2 = (inputTemperature - 32) * 5 / 9;
                                    Console.WriteLine($"{conversion2} degrees Celsius");
                                    break;
                            }
                            break;

                        case "kelvin":
                            switch (requiredScale)
                            {
                                case "fahrenheit":
                                    double conversion1 = ((inputTemperature - 273.15) * 1.8) + 32;
                                    Console.WriteLine($"{conversion1} degrees Fahrenheit");
                                    break;

                                case "celsius":
                                    double conversion2 = inputTemperature - 273.15;
                                    Console.WriteLine($"{conversion2} degrees Celsius");
                                    break;
                            }
                            break;

                        case "celsius":
                            switch (requiredScale)
                            {
                                case "fahrenheit":
                                    double conversion1 = (inputTemperature * 9 / 5) + 32;
                                    Console.WriteLine($"{conversion1} degrees Fahrenheit");
                                    break;

                                case "kelvin":
                                    double conversion2 = inputTemperature + 273.15;
                                    Console.WriteLine($"{conversion2} degrees Kelvin");
                                    break;
                            }
                            break;

                        default:
                            Console.WriteLine("Incorrect input. Please check again");
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please enter a valid number for the temperature.");
                }
            }
        }
    }
}

