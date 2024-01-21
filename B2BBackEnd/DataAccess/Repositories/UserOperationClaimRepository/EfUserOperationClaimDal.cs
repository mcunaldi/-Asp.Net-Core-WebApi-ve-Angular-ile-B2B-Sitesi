using Core.DataAccess.EntityFramework;
using DataAccess.Context;
using Entities.Concrete;

namespace DataAccess.Repositories.UserOperationClaimRepository;
public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, SimpleContextDb>, IUserOperationClaimDal
{
}
