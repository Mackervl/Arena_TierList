using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arena_TierList.Data;
using Arena_TierList.Models;
using Microsoft.AspNetCore.Mvc;

namespace Arena_TierList.Controllers
{
    public class ArenaController : Controller
    {
        
        private  readonly ICardRepository _repService;
        private readonly ISortService<List<Card>> _sortService;
        public ArenaController (ICardRepository repService, ISortService<List<Card>> sortService)
        {

            _repService = repService;
            _sortService = sortService;
        }
        [Route("TierList")]
        public IActionResult TierList()
        {
            var cards = _repService.GetByHero(1).ToList();
            var sorted = _sortService.SortOnValue(cards);
            return View(sorted);
        }
    }
}