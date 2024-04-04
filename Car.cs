using System;
//using System.Collections.Generuc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PabDealership.Models
{
    //Gets the information for a car
    public class Car
        {
        public string Make { get; set; }
        //These are the properties of a car
        public string Model { get; set; }
        public int Year { get; set; }
       
      

    //The following are the constructors
    public Car()
    {
        //Default constructor
        Make = string.Empty;
    }

        public Car(int year, string model, string make)
        { 
            //These are the non default 
            Make = make;
            Model = model;
            Year = year;
        }

            //These are the methods
           
            public override string ToString()
            {
            return $"Year: {Year}, Make: {Make}, Model: {Model}"; 
            }
        }
    }