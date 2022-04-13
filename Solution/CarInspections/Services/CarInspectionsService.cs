using AutoMapper;
using CarInspections.Api.DTOs;
using CarInspections.Api.Entities;
using CarInspections.Api.Repository.Interfaces;
using CarInspections.Api.Services.Interfaces;

namespace CarInspections.Api.Services
{
    public class CarInspectionsService : ICarInspectionsService
    {
        private readonly ICarInspectionsRepository _carInspectionsRepository;
        private readonly IMapper _autoMapper;
        public CarInspectionsService(ICarInspectionsRepository carInspectionsRepository, IMapper autoMapper)
        {
            _carInspectionsRepository = carInspectionsRepository;
            _autoMapper = autoMapper;
        }
        public IEnumerable<CarInspectionsDto> GetCarInspections(string? registrationNumber)
        {
            List<CarInspectionsDto> carInspectionsDtoList = new List<CarInspectionsDto>();         
            List<Car> carsFromDatabase;
            if (string.IsNullOrEmpty(registrationNumber))
                carsFromDatabase = _carInspectionsRepository.GetAllCars();
            else
                carsFromDatabase = _carInspectionsRepository.GetCarsByRegistrationNumber(registrationNumber);
            
            foreach (var car in carsFromDatabase)
            {
                CarInspectionsDto carInspectionsDto = _autoMapper.Map<CarInspectionsDto>(car);
                if (car.CarInspections.Any())
                {
                    var inspectionsForCarOrderedByInspectionDate = car.CarInspections.OrderBy(i => i.InspectionDate);
                    var firstInspection = inspectionsForCarOrderedByInspectionDate.First();
                    var lastInspection = inspectionsForCarOrderedByInspectionDate.Last();   
                    carInspectionsDto.FirstInspectionDate = firstInspection.InspectionDate.ToShortDateString();
                    carInspectionsDto.LastInspectionDate = lastInspection.InspectionDate.ToShortDateString();
                    carInspectionsDto.NextInspectionDate = lastInspection.NextInspectionDate.ToShortDateString();
                    carInspectionsDto.IsRoadWorthy = lastInspection.IsRoadWorthy;
                    carInspectionsDto.CurrentInspectionIsExpired = lastInspection.NextInspectionDate <= DateOnly.FromDateTime(DateTime.Now);
                }
                carInspectionsDtoList.Add(carInspectionsDto);
            }

            return carInspectionsDtoList;
        }
    }
}
