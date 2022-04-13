using CarInspections.Api.Repository;
using CarInspections.Api.DTOs;
using CarInspections.Api.Entities;
using CarInspections.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarInspections.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CarInspectionsController : ControllerBase
    {
        private readonly ICarInspectionsService _carInspectionsService;

        public CarInspectionsController(ICarInspectionsService carInspectionsService)
        {
            _carInspectionsService = carInspectionsService;
        }

        [HttpGet(Name = "GetCarInspections")]
        public ActionResult<IEnumerable<CarInspectionsDto>> GetCarInspections(string? registrationNumber)
        {
            try
            {
                var carInspections = _carInspectionsService.GetCarInspections(registrationNumber);
                return Ok(carInspections);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost(Name = "GetCarInspections")]
        public ActionResult<IEnumerable<CarInspectionsDto>> GetCarInspections([FromBody] GetCarInspectionsFilterDto getCarInspectionsFilterDto)
        {
            try
            {
                var carInspections = _carInspectionsService.GetCarInspections(getCarInspectionsFilterDto.RegistrationNumber);
                return Ok(carInspections);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}