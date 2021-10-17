using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1

            string[] cars = new string[5]; 
           
            //in Csharp array index represents the position of the element and it starts with 0, 1, and so. 
            //Don't forget to mention the number of elements we want to have in the array.
            //Re Main method - MainApp.exe /r /f /p /test - these represent that the /r /f /p /test can passed into the string[]. 

            cars[0] = "Toyota";
            cars[1] = "Honda";
            cars[2] = "Hyundai";
            cars[3] = "Ford";
            cars[4] = "GM";

            Console.WriteLine($"The companies like {cars[0]}, {cars[1]}, {cars[2]}, {cars[3]}, {cars[4]} were present in the car expo.");



            //Example 2
            string carBrand = "Toyota,Honda,Hyundai,Ford,GM";
            string[] carName = carBrand.Split(',');

            Console.WriteLine($"The Automobile company {carName[0]} is well known of its quality manufacturing.");
            Console.WriteLine($"{carName[3]} and {carName[4]} has old rivalry.");


            //Example 3

            int[] ages = new int[3];

            ages[0] = 30;
            ages[1] = 18;
            ages[2] = 25;

            Console.WriteLine($"There are three people in the group whose ages are {ages[0]}, {ages[1]}, {ages[2]}.");


            //Example 4

            string[] firstNames = new string[] { "Tom", "Jerry", "Jack" };
            firstNames[2] = "Jackson";
            Console.WriteLine($"we have team of {firstNames[0]}, {firstNames[1]}, {firstNames[2]}");



            Console.ReadLine();
        }
    }
}