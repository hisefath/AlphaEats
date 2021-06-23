﻿using Microsoft.EntityFrameworkCore;

namespace AlphaEats.DataAccess.Models
{
    [Keyless]
    public class Restaurant
    {
        public string Name { get; set; }
        public int CustomerRating { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }
        public int CuisineId { get; set; }
    }
}