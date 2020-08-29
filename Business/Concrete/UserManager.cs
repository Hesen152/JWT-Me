using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userdal)
        {
            _userDal = userdal;
        }
        public void Add(User user)
        {
            _userDal.Add(user);

        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
              }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
            
//            'Sequence contains more than one element';
//(user);
        }
    }
}
