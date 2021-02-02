using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1, BrandId=2, ColorId=3, DailyPrice=300, ModelYear= 2010, Description="Seat İbiza"},
                new Car{Id=2, BrandId=3, ColorId=5, DailyPrice=700, ModelYear= 2015, Description="WW Polo"},
                new Car{Id=3, BrandId=5, ColorId=6, DailyPrice=800, ModelYear= 2019, Description="KİA "},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
          
          Car carToDelete = _cars.SingleOrDefault(c=>c.Id ==car.Id);
            _cars.Remove(carToDelete);           
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

      

        public Car GetByCarId(int carId)
        {
        IEnumerable<object> _cars = null;
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
