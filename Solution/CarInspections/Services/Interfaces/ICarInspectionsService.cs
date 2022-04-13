using CarInspections.Api.DTOs;

namespace CarInspections.Api.Services.Interfaces
{
    public interface ICarInspectionsService
    {
        IEnumerable<CarInspectionsDto> GetCarInspections(string? registrationNumber);
    }
}
