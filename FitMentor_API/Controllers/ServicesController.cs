using FitMentor_API.Dtos.ServiceDtos;
using FitMentor_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FitMentor_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;
        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await _serviceRepository.GetAllServiceAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            await _serviceRepository.CreateService(createServiceDto);
            return Ok("Kategori Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            await _serviceRepository.DeleteService(id);
            return Ok("Kategori Başarılı Bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            await _serviceRepository.UpdateService(updateServiceDto);
            return Ok("Kategori Başarıyla Güncellendi");
        }
    }
}
