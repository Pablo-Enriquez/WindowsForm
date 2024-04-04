using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using PabDealership.Models;

namespace PabDealership.Controllers
{
    public class PabDealershipController
    {
        private List<Car> cars;
        public PabDealershipController()
        {
            cars = new List<Car>();
        }
        public bool AddCar(int year, string make, string model)
        {
            Car? existing = cars.Find(c => c.Make == make);
            if (existing != null)
            {
                DialogResult result = MessageBox.Show("Do you want to edit the existing car model?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    existing.Year = year;
                    existing.Make = make;
                    existing.Model = model;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Car newOne = new Car(year, make, model);
                cars.Add(newOne);
                return true;
            }
        }
        public List<string> GetTextOfAllCar()
        {
            List<string> result = new List<string>();
            foreach (Car car in cars)
            {
                result.Add($"Year: {car.Year}");
                result.Add($"Make: {car.Make}");
                result.Add($"Model: {car.Model}");
                result.Add("");
            }
            return result;
        }

        public List<string> GetCarNames()
        {
            List<string> result = new List<string>();
            foreach (Car car in cars)
            {
                result.Add(car.Make);
            }
            return result;
        }

        public Dictionary<string, string> GetCarDetails(string make)
        {
            Car found;
            Dictionary<string, string> result;
            if (make != null)
            {
                found = cars.Find(g => g.Make == make);
                if (found == null)
                {
                    return null;
                }
                else
                {
                    result = new Dictionary<string, string>();
                    result.Add("year", $"{found.Year}");
                    result.Add("make", found.Make);
                    result.Add("model", found.Model);

                }
            }
            else
            {
                result = null;
            }
            return result;
        }
    }
}

