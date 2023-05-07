using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using WindowsForms_TestTask_SoftService.Interfaces;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_TestTask_SoftService.Models
{
    public class CarRepository : ICarRepository
    {
        public IEnumerable<Car> GetCars()
        {
            using (var db = new CarDbContext())
            {
                return db.Cars.ToList();
            }
        }

        public void AddCar(Car car)
        {
            using(var db = new CarDbContext())
            {
                db.Cars.Add(car);
                db.SaveChanges();
            }
        }

        public void UpdateCar(Car car)
        {
            using(var db = new CarDbContext())
            {
                var existingCar = db.Cars.FirstOrDefault(c => c.ID == car.ID);
                if (existingCar != null)
                {
                    existingCar.Number = car.Number;
                    existingCar.Brand = car.Brand;
                    existingCar.Color = car.Color;
                    existingCar.Mileage = car.Mileage;
                    existingCar.Speed = car.Speed;
                    db.SaveChanges();
                }
            }
        }


        public Car GetCarById(int id)
        {
            using(var db = new CarDbContext())
            {
                return db.Cars.FirstOrDefault(c => c.ID == id);
            }
        }

        public void DeleteCar(int id)
        {
            using(var db = new CarDbContext())
            {
                var deleteCar = db.Cars.FirstOrDefault(c => c.ID == id);
                if (deleteCar != null)
                {
                    db.Cars.Remove(deleteCar);
                    db.SaveChanges();
                }
            }
        }
    }
}
