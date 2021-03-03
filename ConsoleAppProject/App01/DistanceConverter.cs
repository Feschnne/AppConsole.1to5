using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app contains three different stages:
    /// 1. Create an app to convert from Miles to Feet getting user input.
    /// 2. Create an app to convert Miles to Feet & Feet to Miles, & Miles to Metres
    /// 3. Create an app where allowing the to select which unit to convert from and which unit to convert to. (If possible Movile app version)
    /// </summary>
    /// <author>
    /// Felipe Schol Negrin 0.1
    /// </author>
    public class DistanceConverter // Creando una clase que va a contener toda la programacion que va a llevar a cabpo esta aplicacion
    {
     
        string selectedUnitFrom;// antes de llamar a cualquier metodo vamos a declarar las variables que estaran dentro de nuestra programacion
        string selectedUnitTo;// declaramos como string aquellas que el usuario va a crear el input
        string valueToConvert;//
        double toDistance;// declaramos como doble aquellas variables que necesitaremos con numeros para llevar a cabo el calculo
        double fromDistance;//

        public void Run()// creamos un public void donde todos nuestros diferentes sub metodos quedaran dentro.
        {
            OutputHeading();// todos los metodos son declarados antes de su programacion para avisar al programa que queremos ejecutar esos metodos
            SelectDistanceFrom();
            SelectDistanceTo();
            ConvertUnitFrom();
            InputDistance();
            ConvertMenu();
            CalculateDistance();
            OutputResult();
        }
        private void OutputHeading()// en este metodo añadire la forma y aspecto que le quiero dar a mi heading
        {
            Console.WriteLine();
            Console.WriteLine("=========================");// simplemente utilizamos Console.WriteLine para "dibujar" nuestra aplicacion
            Console.WriteLine("=   DISTANCE CONVERTER  =");
            Console.WriteLine("= Miles & Metres & Feet =");
            Console.WriteLine("=    by FELIPE SCHOL    =");
            Console.WriteLine("=========================");
            Console.WriteLine();
        }
        private void SelectDistanceFrom()// en este metodo le daremos la posibilidad al usuario de elegir entre 3 opciones para convertir desde.
        {
            Console.WriteLine("Please choose the unit distance to convert from: ");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Metres");
            Console.WriteLine("3. Feet");
            Console.WriteLine();
            selectedUnitFrom = Console.ReadLine();// llamamos a la string selected unit from y le asignamos el input del usuarion con Console.ReadLine.
            Console.WriteLine();
            Console.WriteLine("Distance from, chosen: " + selectedUnitFrom);// avisamos al usuario de su eleccion
        }
        private void SelectDistanceTo()// en este metodo sera igual que el de SelectedInputFrom, con la unica diferencia que aqui aclamamos la seleccion de otra unidad para convertir a
        {
            Console.WriteLine();
            Console.Write("Please choose the unit distance to convert to: ");
            selectedUnitTo = Console.ReadLine();//
            Console.WriteLine();
            Console.WriteLine("Distance to, chosen: " + selectedUnitTo);//
        }

        private void ConvertUnitFrom()// este metodo lo añadi el ultimo ya que necesitaba que en el metodo siguiente, selectedUnitFrom saliese como una unidad y no como un numero
        {
            if (selectedUnitFrom == "1")// basicamente con este if le digo al programa que si el input del usuario es 1-->Miles, 2..>Metres, 3--> Feet.
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
        private void InputDistance()// en este metodo el usuario entrara el numero de unidades a convertir a. 
        {
            Console.WriteLine("");
            Console.Write("Please enter the desired number of " + selectedUnitFrom + " > ");
            valueToConvert = Console.ReadLine();// llamamos a valueToConvert para adjudicarle el input del usuario
            fromDistance = Convert.ToDouble(valueToConvert);// al ser una string, la convertimos en double y le damos el nombre de fromDistance
        }
        private void ConvertMenu()// Este metodo es facil de interpretar y le ayuda al metodo que biene posteriormente a entender las unidades para los calculos
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
        private void CalculateDistance()// en este metodo utilizamos if statements para añadir calculos segun los input recibidos por el usuario.
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
        private void OutputResult()//
        {
            
            Console.WriteLine();
            Console.WriteLine("The result is " + toDistance + " " + selectedUnitTo);//
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
