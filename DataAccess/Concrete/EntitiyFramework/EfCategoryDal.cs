using Core.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext> ,ICategoryDal
    {
    }
}
