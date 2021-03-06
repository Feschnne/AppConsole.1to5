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
        private void InputUnit()
        {
            Console.Write("Please choose: Imperial or Metrical Units > ");
            Console.WriteLine("");
            Console.WriteLine("1. Imperial Units");
            Console.WriteLine("2. Metrical Units");
            selectedUnit = Console.ReadLine();  
        }
        private void OutputHealthMessage()
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


                BMIresult = weightPounds * 703 / (heightInches * heightInches);
                
                if ( BMIresult <= 18.49 ) 
                {
                Console.WriteLine("Your BMI is > " + BMIresult + "You are underweight");
                }
                if ( BMIresult >= 18.50 && BMIresult <= 24.9 )
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
                
                Console.WriteLine("Your BMI is: " + BMIresult);
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
