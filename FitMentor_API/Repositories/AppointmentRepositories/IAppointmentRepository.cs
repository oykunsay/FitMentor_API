using FitMentor_API.Dtos.AppointmentDtos;

namespace FitMentor_API.Repositories.AppointmentRepositories
{
    public interface IAppointmentRepository
    {
        Task<List<ResultAppointmentDto>> GetAllAppointmentAsync();
        Task DeleteAppointment(int id);
        Task UpdateAppointment(UpdateAppointmentDto appointmentDto);
    }
}
