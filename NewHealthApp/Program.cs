using System;
using System.Collections.Generic;
using System.Text;

namespace NewHealthApp
{
    public class HealthData
    {
        //3 private fields
        private float massInKg;
        private int heightInCm;
        private float bmi;
        /// <summary>
        /// Constructor which takes the mass in kg and height in cm and stores them
        /// it then calculate the bmi and stores that in a further field
        /// </summary>
        /// <param name="massKg"></param>
        /// <param name="heightCm"></param>
        public HealthData(float massKg, int heightCm)
        {
            massInKg = massKg;
            heightInCm = heightCm;
            float heightInM = heightCm / 100.0f;
            //bmi is the mass in kg divided by the heightInM squared
            //Math.Pow returns the first argument raised to the power of the second argument
            //as a double so we have to cast it as a float
            bmi = massKg / (float)Math.Pow(heightInM,2);
          
        }
        /// <summary>
        /// this is a parameter in C# which is used to access the BMI
        /// </summary>
        public float BMI
        {
            get
            {
                return bmi;
            }
        }
    } 
    class Program
    {
        /// <summary>
        /// Main is the starting method or function for all C# programs
        /// if you ran your program from a command window then args will be the rest of the text on the line where you
        /// run your code
        /// </summary>
        /// <param name="args">This is the command line paramater</param>
        static void Main(string[] args)
        {
            //This is just for setup I will delete the following line soon
            Console.WriteLine("Hello World");
            Console.Write("Enter a height in cm ");
            int height = Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter a mass in kg ");
            float mass = (float) Convert.ToDouble(Console.ReadLine());
            //Store these in an object of the type HealthData
            HealthData healthData = new HealthData(mass, height);
            Console.WriteLine("That gives a BMI of " + healthData.BMI);
            //The following line I will delete after my program is working
            Console.ReadLine();
        }
    }
}
