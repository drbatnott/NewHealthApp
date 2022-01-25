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
            List<HealthData> dataList = new List<HealthData>();
            //This is just for setup I will delete the following line soon
            Console.WriteLine("Hello World");
            /*There are many types of iteration the first one we will use is called the for loop
            I plan on testing this by entering 4 sets of data.
            int i = 0; set up the loop counter to zero  The next thing the compiler will do is compare i to the 
            terminating condition in this case it will ask is i less than 4? If it is it will do the loop
            - the things between the {}
            Once the loop is finished the i++ is done this stands for add 1 to i the first time the answer will be 1
            Now i is compared to the terminating condition if i is still < 4 in this case the loop will go again and
            after that the i++ until i is equal to 4
             */
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter a height in cm ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a mass in kg ");
                float mass = (float)Convert.ToDouble(Console.ReadLine());
                //Store these in an object of the type HealthData
                HealthData healthData = new HealthData(mass, height);
                Console.WriteLine("That gives a BMI of " + healthData.BMI);
                dataList.Add(healthData);
            }
            /*
             * Now we are going to do another form of iteration called the foreach
             * This will iterate through any type of data structure if it can - arrays and lists are typical
             */
            foreach(HealthData hData in dataList)
            {
                Console.WriteLine("Data " + hData.BMI);
            }
            //The following line I will delete after my program is working
            Console.ReadLine();
        }
    }
}
