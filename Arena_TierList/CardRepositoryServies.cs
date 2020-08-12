using Arena_TierList.Data;
using Arena_TierList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arena_TierList
{
    public class CardRepositoryServies:ICardRepository
    {
        private readonly Context _context;
        public CardRepositoryServies(Context context)
        {
            _context = context;
        }
        public IEnumerable<Card> GetAll()
        {
            return _context.Cards;
        }
        public Card GetById(long id)
        {
            return _context.Cards.Find(id);
        }
        public void Update(Card card) //доработать
        {
            _context.Entry(card).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public async Task CreateAsync(Card card) //вопрос по попытке добавления уже сущ сущности.
        {
          
               await _context.Cards.AddAsync(card);
            await _context.SaveChangesAsync();


        }
        public async Task DeleteAsync(long id)
        {
            var card = _context.Cards.FindAsync(id);
            if(card!=null)
            {
                 _context.Cards.Remove(card.Result);
                await _context.SaveChangesAsync();
            }
        }
        public IEnumerable<Card> GetByHero(int heroid)
        {
            return _context.Cards.Where(x => x.HeroId == heroid).OrderByDescending(x=>x.Value).ToList();
        } 
    }
}
