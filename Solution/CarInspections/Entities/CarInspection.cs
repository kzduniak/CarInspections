using System;
using System.Collections.Generic;

namespace CarInspections.Api.Entities
{
    public partial class CarInspection
    {
        public int Id { get; set; }
        public DateOnly InspectionDate { get; set; }
        public DateOnly NextInspectionDate { get; set; }
        public bool IsRoadWorthy { get; set; }
        public int CarId { get; set; }

        public virtual Car Car { get; set; } = null!;
    }
}
