namespace CarInspections.Api.DTOs
{
    public class CarInspectionsDto
    {
        public string? RegistrationNumber { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? FirstInspectionDate { get; set; }
        public string? LastInspectionDate { get; set; }  
        public string? NextInspectionDate { get; set; }
        public bool? CurrentInspectionIsExpired { get; set; }
        public bool? IsRoadWorthy { get; set; }
    }
}
