﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Arena_TierList.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rarity { get; set; }
        public int Manacost { get; set; }
        public byte[] Image { get; set; }
        public int HeroId { get; set; }
        public int Value { get; set; }
        public Hero CardHero { get; set; }

    }
}
