using FitMentor_API.Dtos.AppointmentDtos;
using FitMentor_API.Repositories.AppointmentRepositories;
using Microsoft.AspNetCore.Mvc;

namespace FitMentor_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentRepository _appointmentRepository;
        public AppointmentsController(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> AppointmentList()
        {
            var values = await _appointmentRepository.GetAllAppointmentAsync();
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            await _appointmentRepository.DeleteAppointment(id);
            return Ok("Randevu Başarılı Bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateAppointmentDto updateAppointmentDto)
        {
            await _appointmentRepository.UpdateAppointment(updateAppointmentDto);
            return Ok("Randevu Başarıyla Güncellendi");
        }
    }
}
