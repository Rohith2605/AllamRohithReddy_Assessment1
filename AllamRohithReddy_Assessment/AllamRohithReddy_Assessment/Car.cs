using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Write a program to create a class called Car with Model, Year of making details. 
  
Read the Car details from the User and store into a file.
 */
namespace AllamRohithReddy_Assessment
{
    public class Car
    {
        public string model;
           
        public DateTime year_of_making;

        public Car(string model,DateTime year_of_making)
        {
            this.model = model;
            this.year_of_making = year_of_making;
        }
    }

    public class FileDemo
    {
       
        public void Write(string path, string s)
        {
            File.AppendAllText(path, s);
        }
    }

    public class test
    {
        public static void Main()
        {
            Console.WriteLine("Enter the car model");
            string model = Console.ReadLine();
            Console.WriteLine("enter the year_of_making in mm/dd/yyyy format");
             DateTime dateTime = DateTime.Parse(Console.ReadLine());
     
            Car car = new Car(model, dateTime);
            string details=$"model:{car.model}\nyear_of_making:{car.year_of_making}";
            try
            {
                FileDemo fd = new FileDemo();
                //writing a file Sample3. if it does not exists it will create new one 
                fd.Write("D:/Sample3.txt",details);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }

}
