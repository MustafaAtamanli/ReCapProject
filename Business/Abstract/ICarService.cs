using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetCarsByBrandId(int id);

        IDataResult<List<Car>> GetCarsByColorId(int id);

        IResult Add(Car car);

        IDataResult<List<CarDetailDto>> GetCarDetails(int id);

        IDataResult<List<CarDetailDto>> GetCarsDetails();

        IDataResult<List<Car>> GetCarsByBrandIdAndColorId(int brandId,int colorId);



        IResult AddTransactionalTest(Car car);
    }
}
