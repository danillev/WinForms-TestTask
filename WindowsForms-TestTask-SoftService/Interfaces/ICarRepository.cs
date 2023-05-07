using System;
using System.Collections.Generic;
using WindowsForms_TestTask_SoftService.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_TestTask_SoftService.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarById(int id);
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int id);
    }
}
