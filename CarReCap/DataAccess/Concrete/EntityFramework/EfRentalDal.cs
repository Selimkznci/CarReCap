using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        //public List<CarDetailDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
        //{
        //    using (RentACarContext context = new RentACarContext())
        //    {
        //        var result = from rnt in filter is null ? context.rentals : context.rentals.Where(filter)
        //                     join cr in context.cars on rnt.CarId equals cr.CarId
        //                     join col in context.colors on cr.ColorId equals col.ColorId
        //                     join brd in context.cars on cr.BrandId equals brd.BrandId
        //                     join cus in context.customers on rnt.CustomerId equals cus.Id
        //                     join usr in context.users on cus.UserId equals usr.Id
        //                     select new CarRentalDetailDto
        //                     {
        //                         RentalId = rnt.Id,
        //                         CustomerName = usr.FirstName,
        //                         CustomerLastName = usr.LastName,
        //                         CustomerCompanyName = cus.CompanyName,
        //                         CarName = cr.CarName,
        //                         ColorName = col.ColorName,
        //                         DailyPrice = cr.DailyPrice,
        //                         RentDate = rnt.RentDate,
        //                         ReturnDate = rnt.ReturnDate
        //                     };
        //        return result.ToList();
        //    }
        //}
        public List<CarDetailDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
