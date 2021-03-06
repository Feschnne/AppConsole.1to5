using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app contains three different stages:
    /// 1. Create an app to convert from Miles to Feet getting user input.
    /// 2. Create an app to convert Miles to Feet & Feet to Miles, & Miles to Metres
    /// 3. Create an app where allowing the user to select which unit to convert from and which unit to convert to. (If possible Movile app version)
    /// </summary>
    /// <author>
    /// Felipe Schol Negrin 0.1
    /// </author>
    public class DistanceConverter // Creating a class which will contain methods inside it.
    {
        // Declaring variables
        // 3 variables type string to get user input
        // Then 2 variables type double to use for calculations. 
        string selectedUnitFrom;
        string selectedUnitTo;
        string valueToConvert;
        double toDistance;
        double fromDistance;

        public void Run()// We create a public method which contains different private methods to run the program.
        {
            OutputHeading();// All private methods are declared first to tell the program that we want to run them. 
            SelectDistanceFrom();
            SelectDistanceTo();
            ConvertUnitFrom();
            InputDistance();
            ConvertMenu();
            CalculateDistance();
            OutputResult();
        }
        private void OutputHeading()// In this method we add the shape of the program by using Console.WriteLine()'s.
        {
            Console.WriteLine();
            Console.WriteLine("=========================");
            Console.WriteLine("=   DISTANCE CONVERTER  =");
            Console.WriteLine("= Miles & Metres & Feet =");
            Console.WriteLine("=    by FELIPE SCHOL    =");
            Console.WriteLine("=========================");
            Console.WriteLine();
        }
        private void SelectDistanceFrom()// In this method the user is allowed to choose a unit to convert from. este metodo le daremos la posibilidad al usuario de elegir entre 3 opciones para convertir desde.
        {
            Console.WriteLine("Please choose the unit distance to convert from: ");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Metres");
            Console.WriteLine("3. Feet");
            Console.WriteLine();
            selectedUnitFrom = Console.ReadLine();// The user input is saved in this string named 'selectedUnitFrom'. There's no need to put string before its name because we have already declared this variable before.
            Console.WriteLine();
            Console.WriteLine("Distance from, chosen: " + selectedUnitFrom);// We tell the user which distance has chosen to convert from.
        }
        private void SelectDistanceTo()// This method is similar as the last one but in this case the user will choose the distance to converto to.
        {
            Console.WriteLine();
            Console.Write("Please choose the unit distance to convert to: ");
            selectedUnitTo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Distance to, chosen: " + selectedUnitTo);//
        }

        private void ConvertUnitFrom()// I add this method in order to tell the user (in my next method Line 83) what distance unit has been chosen, instead of showing the number chosen.
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
                selectedUnitFrom = "Feet";//
            }
        }
        private void InputDistance()// In this method we get the user input to convert the distance. 
        {
            Console.WriteLine("");
            Console.Write("Please enter the desired number of " + selectedUnitFrom + " > ");
            valueToConvert = Console.ReadLine();// I name the user input valueToConvert
            fromDistance = Convert.ToDouble(valueToConvert);// I need the user input as a double for calculations, so I convert the user input (as a string) to a double.
        }
        private void ConvertMenu()// In this method I assign values for the if statements of my next method. 
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
        private void CalculateDistance()// In this method I used the values assigned before to assign to each posibility a calculation.  
        {
            if (selectedUnitFrom == "Miles" && selectedUnitTo == "Metres")//
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
        private void OutputResult()// This method is used to give the user the result.
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
//double feetFromMiles;
//double milesFromFeet;
//double metresFromMiles;
//double miles;
//double feet;
//double miles2;


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
