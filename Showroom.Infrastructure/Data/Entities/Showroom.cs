﻿using System.ComponentModel.DataAnnotations;

namespace Showroom.Infrastructure.Data.Entities
{
    public class Showroom
    {
        public Showroom()
        {
            Id = Guid.NewGuid();
            Cars = new List<Car>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<Car> Cars { get; set; }
    }
}
