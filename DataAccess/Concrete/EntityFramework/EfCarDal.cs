using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {

            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join clr in context.Colors
                             on c.ColorId equals clr.ColorId

                             select new CarDetailDto { BrandId = c.BrandId, BrandName = b.BrandName, DailyPrice = c.DailyPrice, Description = c.Description, Id = c.Id, ModelYear = c.ModelYear,ColorId=c.ColorId,ColorName=clr.ColorName };
                                             
                return result.ToList();
            }
        }
    }
}
