using Arena_TierList.ArenaTierList.Repository.Abstractions;
using Arena_TierList.ArenaTierList.Repository.Context;
using Arena_TierList.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arena_TierList.ArenaTierList.Repository.Implementations
{
    public class CardRepository : AbstractRepository, ICardRepository
    {

        public CardRepository(ApplicationDbContext appDbContext) : base(appDbContext)
        {

        }
        #region IRepositoryMembers

        public IEnumerable<Card> GetAll()
        {
            return appDbContext.Cards.ToList();
        }

        public async Task CreateAsync(Card entity)
        {

            appDbContext.Cards.Add(entity);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<Card> GetByIdAsync(long id)
        {
            return await appDbContext.Cards.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task UpdateAsync(Card entity)
        {
            await appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Card entity)
        {
            appDbContext.Cards.Remove(entity);
            await appDbContext.SaveChangesAsync();
        }
        #endregion
        #region ICardRepositoryMembers

        public IEnumerable<Card> GetByHeroId(int heroId)
        {
            return appDbContext.Cards.Where(e => e.HeroId == heroId).ToList();
        }
        #endregion
    }
}
