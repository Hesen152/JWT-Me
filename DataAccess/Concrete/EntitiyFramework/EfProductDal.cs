using Core.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        
        
     
   
    }
}
