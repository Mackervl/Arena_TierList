using Arena_TierList.Data;
using Arena_TierList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arena_TierList
{
    public class SortCardService : ISortService<List<Card>>
    {

        public OnValueHelperModel sortedCards { get; set; }
        public SortCardService(Context context)
        {

            sortedCards = new OnValueHelperModel();
           
        }
        public OnValueHelperModel SortOnValue(List<Card> cards)
        {
            foreach (var card in cards)
            {
                if (card.Value >= 132)
                {
                    sortedCards.VeryGood.Add(card);
                }
                else
                {
                    if (card.Value < 132 && card.Value >= 114)
                    {
                        sortedCards.Good.Add(card);
                    }
                    else
                    {
                        if (card.Value < 114 && card.Value >= 105)
                        {
                            sortedCards.VeryMiddle.Add(card);
                        }
                        else
                        {
                            if (card.Value < 105 && card.Value >= 96)
                            {
                                sortedCards.Middle.Add(card);
                            }
                            else
                            {
                                if (card.Value < 96 && card.Value >= 87)
                                {
                                    sortedCards.LessMiddle.Add(card);
                                }
                                else
                                {
                                    if (card.Value < 87 && card.Value >= 69)
                                    {
                                        sortedCards.Bad.Add(card);
                                    }

                                    else
                                    {
                                        if (card.Value < 69 && card.Value >= 0)
                                        {
                                            sortedCards.LessBad.Add(card);
                                        }
                                    }

                                }
                            }
                        }
                    }
                }

            }
            
            return sortedCards;
        }
    }
}
