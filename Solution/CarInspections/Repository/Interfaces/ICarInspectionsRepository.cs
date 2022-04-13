using CarInspections.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarInspections.Api.Repository.Interfaces
{
    public interface ICarInspectionsRepository
    {
        List<Car> GetAllCars();
        List<Car> GetCarsByRegistrationNumber(string? registrationNumber);
    }
}
