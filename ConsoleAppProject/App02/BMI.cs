using System;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app allows the user to calculate their BMI from Metrical or Imperial Units. 
    /// </summary>
    /// <author>
    /// Felipe Schol  0.1
    /// </author>
    public class BMI 
    {
        // Variables are declared with its type.
        string selectedUnit;
        double BMIresult;
        double BMIresult2;
        double heightInches;
        double weightPounds;
        double heightMetres;
        double weightKg;

        public void Run()
        {
            OutputHeading1();
            InputUnit();
            OutputHealthMessage();
            //InputDistances();
        }


        private void OutputHeading1()
        {

            Console.WriteLine();
            Console.WriteLine("======================");
            Console.WriteLine("==  BMI CALCULATOR  ==");
            Console.WriteLine("==  by FELIPE SCHOL ==");
            Console.WriteLine("======================");
            Console.WriteLine();
          
            
        }
        private void InputUnit() // This method is used to allow the user select either metrical or imperial units.
        {
            Console.Write("Please choose: Imperial or Metrical Units > ");
            Console.WriteLine("");
            Console.WriteLine("1. Imperial Units");
            Console.WriteLine("2. Metrical Units");
            selectedUnit = Console.ReadLine();  // We assigned a value for the variable declared beofre. In this case is assigned the user input
        }
        private void OutputHealthMessage() // I used this method to tell the proram what to do en each situation (Imperial or Metrical=
        {
            if (selectedUnit == "1")
            {
                selectedUnit = "Imperial Units";
                Console.WriteLine();
                Console.WriteLine("You have chosen " + selectedUnit);

                Console.WriteLine("Please enter your weight in pounds > ");
                weightPounds = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your height in inches > ");
                heightInches = Convert.ToDouble(Console.ReadLine());
                // values are assigned to variables declared before. 

                BMIresult = weightPounds * 703 / (heightInches * heightInches); // The formula is declared after the user input is gotten.
                
                if ( BMIresult <= 18.49 ) 
                {
                Console.WriteLine("Your BMI is > " + BMIresult + "You are underweight");// The result of the BMI is displayed with a little comment.
                }
                if ( BMIresult >= 18.50 && BMIresult <= 24.9 ) // Operators are used to separate the possibilities of the output result. 
                {
                Console.WriteLine("Your BMI is > " + BMIresult + "You are normal");
                }
                if ( BMIresult >= 25.0 && BMIresult <= 29.9 )
                {
                Console.WriteLine("Your BMI is > " + BMIresult + "You are overweight");
                }
                if (BMIresult >= 30.0 &&  BMIresult <= 34.9 ) 
                {
                Console.WriteLine("Your BMI is > " + BMIresult + "You are Obese Class |");
                }
                if (BMIresult >= 35.0 && BMIresult <= 39.9 ) 
                {
                Console.WriteLine("Your BMI is > " + BMIresult + "You are Obese Class ||");
                }
                if (BMIresult >= 40.0)
                {
                Console.WriteLine("Your BMI is > " + BMIresult + "You are Obese Class |||");
                }  
            }
      
            if(selectedUnit == "2")
            {
            Console.Write("Please enter the your weight in kg > ");
                weightKg = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Please enter your height in metres > ");
                heightMetres = Convert.ToDouble(Console.ReadLine());
                
                BMIresult2 = weightKg / (heightMetres * heightMetres);
                
                if (BMIresult2 <=18.50)
                {
                    Console.WriteLine("Your BMI is > " + BMIresult + "underweight");
                }    
                if (BMIresult2 > 18.50 && BMIresult2 <= 24.9) 
                {
                    Console.WriteLine("Your BMI is > " + BMIresult + "You are normal");
                }
                if (BMIresult2 >= 25 && BMIresult2 <= 29.9);
                {
                    Console.WriteLine("Your BMI is > " + BMIresult + "You are overweight");
                }
                if (BMIresult2 >= 30 && BMIresult2 <= 34.9);
                {
                    Console.WriteLine("Your BMI is > " + BMIresult + "You are Obese Class |");
                }
                if (BMIresult2 >= 35 && BMIresult2 <= 39.9);
                {
                    Console.WriteLine("Your BMI is > " + BMIresult + "You are Obese Class ||");
                }
                if (BMIresult2 >= 40)
                {
                    Console.WriteLine("Your BMI is > " + BMIresult + "You are Obese Class |||");
                }
            }  
        }
    }
}
