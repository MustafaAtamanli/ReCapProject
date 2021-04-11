using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IResult Add(User user);
        IDataResult<User> GetByMail(string email);
        IResult Delete(User user);
        IDataResult<User> Update(UserForRegisterDto userUpdateDto, string password);
        IDataResult<List<User>> GetAll();

        IDataResult<User> GetUserById(int id);


    }
}
