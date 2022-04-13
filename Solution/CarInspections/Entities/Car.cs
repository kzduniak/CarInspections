using System;
using System.Collections.Generic;

namespace CarInspections.Api.Entities
{
    public partial class Car
    {
        public Car()
        {
            CarInspections = new HashSet<CarInspection>();
        }

        public int Id { get; set; }
        public string RegistrationNumber { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;

        public virtual ICollection<CarInspection> CarInspections { get; set; }
    }
}
