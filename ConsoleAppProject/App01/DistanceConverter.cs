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
        string selectedUnitFrom;
        string selectedUnitTo;
        string valueToConvert;
        double toDistance;
        double fromDistance;

        public void Run()
        {
            OutputHeading();
            SelectDistanceFrom();
            SelectDistanceTo();
            InputDistance();
            ConvertMenu();
            CalculateDistance();
            OutputResult();
        }
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("=========================");
            Console.WriteLine("=   DISTANCE CONVERTER  =");
            Console.WriteLine("= Miles & Metres & Feet =");
            Console.WriteLine("=    by FELIPE SCHOL    =");
            Console.WriteLine("=========================");
            Console.WriteLine();
        }
        private void SelectDistanceFrom()
        {
            Console.WriteLine("Please choose the unit distance to convert from: ");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Metres");
            Console.WriteLine("3. Feet");
            Console.WriteLine();
            selectedUnitFrom = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Distance from, chosen: " + selectedUnitFrom);
        }
        private void SelectDistanceTo()
        {
            Console.WriteLine();
            Console.Write("Please choose the unit distance to convert to: ");
            selectedUnitTo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Distance to, chosen: " + selectedUnitTo);
        }
        private void InputDistance()
        {
            Console.Write("Please enter the desired number of " + selectedUnitFrom + " > ");
            valueToConvert = Console.ReadLine();
            fromDistance = Convert.ToDouble(valueToConvert);
        }
        private void ConvertMenu()
        {
            if (selectedUnitFrom == "1")
            {
                selectedUnitFrom = "Miles";

            }
            if (selectedUnitFrom == "2")
            {
                selectedUnitFrom = "Metres";

            }
            if (selectedUnitFrom == "3")
            {
                selectedUnitFrom = "Feet";

            }
            if (selectedUnitTo == "1")
            { 
                selectedUnitTo = "Miles";

            }
            if (selectedUnitTo == "2")
            {
                selectedUnitTo = "Metres";

            }
            if (selectedUnitTo == "3")
            {
                selectedUnitTo = "Feet";

            }
        }
        private void CalculateDistance()
        {
            if (selectedUnitFrom == "Miles" && selectedUnitTo == "Metres")
            {
                toDistance = fromDistance * 1609.34;
            }
            if (selectedUnitFrom == "Miles" && selectedUnitTo == "Feet")
            {
                toDistance = fromDistance * 5280;
            }
            if (selectedUnitFrom == "Metres" && selectedUnitTo == "Miles")
            {
                toDistance = fromDistance * 0.000621371;
            }
            if (selectedUnitFrom == "Metres" && selectedUnitTo == "Feet")
            {
                toDistance = fromDistance * 3.28084;
            }
            if (selectedUnitFrom == "Feet" && selectedUnitTo == "Miles")
            {
                toDistance = fromDistance * 0.00018939394545455;
            }
            if (selectedUnitFrom == "Feet" && selectedUnitTo == "Metres")
            {
                toDistance = fromDistance * 0.3048;
            }
        }
        private void OutputResult()
        {
            Console.WriteLine();
            Console.WriteLine("The result is " + toDistance + " " + selectedUnitTo);
        }
        




    }
}

//FEATURE STAGE 1-->
///
//string valueToConvert;
//double miles;
//double feet;
//public void Run() /**/
//{
//    OutputHeading(); /**/
//    InputMiles();
//    Calculate();
//    OutputResult();
//}

//private void OutputHeading() /**/
//{
//    Console.WriteLine("======================");
//    Console.WriteLine("= DISTANCE CONVERTER =");
//    Console.WriteLine("=    Miles & feet    =");
//    Console.WriteLine("=   by FELIPE SCHOL  =");
//    Console.WriteLine("======================");
//    Console.WriteLine();

//}
//private void InputMiles() /**/
//{
//    Console.Write("Please enter the desired number of miles > "); /**/
//    string valueToConvert = Console.ReadLine(); /**/
//    miles = Convert.ToDouble(valueToConvert); /**/
//}
//private void Calculate() /**/
//{
//    feet = miles * 5280;
//}
//private void OutputResult() /**/ 
//{
//    Console.WriteLine(); 
//    Console.WriteLine(miles + " Miles is " + feet + " feet."); /**/
//}
//FEATURE STAGE 2 -->
//double milesFromFeet;
//double feetFromMiles;
//double miles;
//double milesForMts;
//double miles2;
//double metresFromMiles;
//double feet;
//public void Run() /**/
//{
//    OutputHeading(); /**/
//    InputDistances();
//    OutputResult();
//}

//private void OutputHeading() /**/
//{
//    Console.WriteLine("=========================");
//    Console.WriteLine("=   DISTANCE CONVERTER  =");
//    Console.WriteLine("=     Miles to feet     =");
//    Console.WriteLine("=     Feet to Miles     =");
//    Console.WriteLine("=    Miles to Metres    =");
//    Console.WriteLine("=    by FELIPE SCHOL    =");
//    Console.WriteLine("=========================");
//    Console.WriteLine();

//}
//private void InputDistances() /**/
//{
//    Console.Write("Please enter the desired number of miles > "); /**/
//    string valueToConvert1 = Console.ReadLine(); /**/
//    miles = Convert.ToDouble(valueToConvert1); /**/
//    feetFromMiles = miles * 5280;

//    Console.Write("Please enter the desired number of feet > ");
//    string valueToConvert2 = Console.ReadLine();
//    feet = Convert.ToDouble(valueToConvert2);
//    milesFromFeet = feet / 5280;


//    Console.Write("Please enter the desired number of Miles > ");
//    string valueToConvert3 = Console.ReadLine();
//    miles2 = Convert.ToDouble(valueToConvert3);
//    metresFromMiles = miles2 * 1609.34;


//}

//private void OutputResult() /**/
//{
//    Console.WriteLine();
//    Console.WriteLine(miles + " Miles is " + feetFromMiles + " Feet."); /**/
//    Console.WriteLine(feet + " Feet is " + milesFromFeet + " Miles");
//    Console.WriteLine(miles2 + " Miles is " + metresFromMiles + " Metres");
//}
