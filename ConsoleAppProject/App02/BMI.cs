using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
        string selectedUni;
        double BMIresult;
        double weightPoundsCalc;
        double heightInchesCalc;
        public void Run()
        {
            OutputHeading();
            ConvertMenu();
            //InputDistances();
        }


        private void OutputHeading()
        {

            Console.WriteLine("======================");
            Console.WriteLine("==  BMI CALCULATOR  ==");
            Console.WriteLine("==  by FELIPE SCHOL ==");
            Console.WriteLine("======================");

            Console.WriteLine("Please choose between Imperial or Metrical Units > ");
            Console.WriteLine("");
            Console.WriteLine("1. Imperial Units");
            Console.WriteLine("2. Metrical Units");
            selectedUni = Console.ReadLine();
            
        }
        private void ConvertMenu()
        {
            if (selectedUni == "1")
            {
                selectedUni = "Imperial Units";

                Console.WriteLine("Please enter your weight in pounds > ");
                string weightPounds /*onlyweight?*/ = Console.ReadLine();
                weightPoundsCalc = Convert.ToDouble(weightPounds);

                Console.WriteLine("Please enter your height in inches > ");
                string heightInches /*onlyheight?*/ = Console.ReadLine();
                heightInchesCalc = Convert.ToDouble(heightInches);

                BMIresult = weightPoundsCalc * 703 / Math.Pow(heightInchesCalc, 2);
                if (BMIresult >)
                {

                } 

                Console.WriteLine("The result is: " + BMIresult);
            }
            if (selectedUni == "2")
            {

            }
        }
    }
}
