using CarInspections.Api.Entities;
using CarInspections.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarInspections.Api.Repository
{
    public class CarInspectionsRepository : ICarInspectionsRepository
    {
        private readonly CarInspectionsContext _context;
        public CarInspectionsRepository(CarInspectionsContext context)
        {
            _context = context;
        }
        public List<Car> GetAllCars()
        {
            return _context.Cars.Include(c => c.CarInspections).ToList();
        }
        public List<Car> GetCarsByRegistrationNumber(string? registrationNumber)
        {
            return _context.Cars.Include(c => c.CarInspections).Where(c => c.RegistrationNumber.Equals(registrationNumber)).ToList();
        }
    }
}
