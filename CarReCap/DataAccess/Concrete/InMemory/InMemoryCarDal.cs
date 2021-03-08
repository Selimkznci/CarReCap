using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carDal; 
        public InMemoryCarDal()
        {
            _carDal = new List<Car> { new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 70, ModelYear="1998",CarName="Audi"} };
            _carDal = new List<Car> { new Car { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 90, ModelYear = "2000", CarName = "Opel" } };
            _carDal = new List<Car> { new Car { CarId = 3, BrandId = 3, ColorId = 3, DailyPrice = 150, ModelYear = "2018", CarName = "Mercedes" } };
            _carDal = new List<Car> { new Car { CarId = 4, BrandId = 4, ColorId = 4, DailyPrice = 200, ModelYear = "2020", CarName = "Honda" } };
            _carDal = new List<Car> { new Car { CarId = 5, BrandId = 5, ColorId = 5, DailyPrice = 100, ModelYear = "2005", CarName = "Bmw" } };
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = null;
            //foreach (var c in _carDal)
            //{
            //    if (car.CarId==c.CarId())
            //    {
            //        CarToDelete = c;                     Linq Kullanılmadan Uzun Simüle
            //    }
            //    _carDal.Remove(CarToDelete);
            //}                                    " c => " = Döngü Görevi görür
            CarToDelete = _carDal.SingleOrDefault(c => c.CarId == c.CarId); //Id Araması
            _carDal.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDal;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllBrand(int brandId)
        {           //Şart İle Yeni Bir Tabloya Aktarıyoruz
            return _carDal.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = null;
            CarToUpdate = _carDal.SingleOrDefault(c => c.CarId == c.CarId);
            CarToUpdate.CarName = car.CarName;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
