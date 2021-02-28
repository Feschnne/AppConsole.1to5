using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app contains three different stages:
    /// 1. Create an app to convert from Miles to Feet getting user input.
    /// 2. Create an app to convert Miles to Feet & Feet to Miles, & Miles to Metres
    /// 3. Create an app where the user is able to select which unit to convert from and which unit to convert to. (If possible Movile app version)
    /// </summary>
    /// <author>
    /// Felipe Schol Negrin 0.1
    /// </author>
    public class DistanceConverter
    {
        string valueToConvert;
        double miles;
        double feet;
        public void Run() /**/
        {
            OutputHeading(); /**/
            InputMiles();
            Calculate();
            OutputResult();
        }

        private void OutputHeading() /**/
        {
            Console.WriteLine("======================");
            Console.WriteLine("= DISTANCE CONVERTER =");
            Console.WriteLine("=    Miles & feet    =");
            Console.WriteLine("=   by FELIPE SCHOL  =");
            Console.WriteLine("======================");
            Console.WriteLine();

        }
        private void InputMiles() /**/
        {
            Console.Write("Please enter the desired number of miles > "); /**/
            string valueToConvert = Console.ReadLine(); /**/
            miles = Convert.ToDouble(valueToConvert); /**/
        }
        private void Calculate() /**/
        {
            feet = miles * 5280;
        }
        private void OutputResult() /**/ 
        {
            Console.WriteLine(); 
            Console.WriteLine(miles + " Miles is " + feet + " feet."); /**/
        }


    }
}
