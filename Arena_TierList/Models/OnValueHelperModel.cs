using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arena_TierList.Models
{
    public class OnValueHelperModel
    {
        public List<Card> VeryGood { get; set; }
        public List<Card> Good { get; set; }
        public List<Card> VeryMiddle { get; set; }
        public List<Card> Middle { get; set; }
        public List<Card> LessMiddle { get; set; }
        public List<Card> Bad { get; set; }
        public List<Card> LessBad { get; set; }
        
        public OnValueHelperModel()
        {
            VeryGood = new List<Card>();
            Good =  new List<Card>();
            VeryMiddle = new List<Card>();
            Middle = new List<Card>();
            LessMiddle = new List<Card>();
            Bad = new List<Card>();
            LessBad = new List<Card>();
        }
    }
}
