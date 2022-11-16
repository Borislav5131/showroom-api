﻿namespace Showroom.Core.ViewModels.Cars
{
    public class EditCarModel
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public Guid ShowroomId { get; set; }
    }
}
