using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDto> GetRentalDetails()
        {
            using (RentACarContext context=new RentACarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.Id
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join c2 in context.Colors on c.ColorId equals c2.ColorId
                             join c3 in context.Customers on r.CustomerId equals c3.UserId
                             join u in context.Users on c3.UserId equals u.Id
                             select new RentalDto { Id = r.Id, BrandName = b.BrandName, ColorName = c2.ColorName, ModelYear = c.ModelYear.ToString(), DailyPrice =Convert.ToInt32( c.DailyPrice), Description = c.Description, FirstName = u.FirstName, LastName = u.LastName, RentDate = r.RentDate, ReturnDate = r.ReturnDate, CompanyName = c3.CompanyName };
                return result.ToList();
            }
        }
    }
}
