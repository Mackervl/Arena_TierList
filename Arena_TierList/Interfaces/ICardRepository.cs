using Arena_TierList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arena_TierList
{
    public interface ICardRepository : IRepository<Card> 
    {
        IEnumerable<Card> GetByHero(int heroid);
      
    }
}
