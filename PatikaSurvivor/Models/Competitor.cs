﻿using PatikaSurvivor.Entity;

namespace PatikaSurvivor.Models
{
    public class Competitor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
