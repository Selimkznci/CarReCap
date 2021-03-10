using Core.DataAcces;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<CarDetailDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null);
    }
}
