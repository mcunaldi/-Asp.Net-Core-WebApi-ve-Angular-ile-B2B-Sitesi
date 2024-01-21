using Core.DataAccess.EntityFramework;
using DataAccess.Context;
using Entities.Concrete;

namespace DataAccess.Repositories.OperationClaimRepository;
public class EfOperationClaimDal : EfEntityRepositoryBase<OperationClaim, SimpleContextDb>, IOperationClaimDal
{

}
