using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arena_TierList.ArenaTierList.Repository.Context;
namespace Arena_TierList.ArenaTierList.Repository.Abstractions
{
    public abstract class AbstractRepository
    {
        protected readonly ApplicationDbContext appDbContext;

        protected AbstractRepository(ApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
    }
}
