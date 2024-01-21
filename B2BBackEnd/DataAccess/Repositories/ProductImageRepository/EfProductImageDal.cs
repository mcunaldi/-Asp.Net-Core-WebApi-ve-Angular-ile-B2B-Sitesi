using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.ProductImageRepository;
using DataAccess.Context;

namespace DataAccess.Repositories.ProductImageRepository
{
    public class EfProductImageDal : EfEntityRepositoryBase<ProductImage, SimpleContextDb>, IProductImageDal
    {
    }
}
