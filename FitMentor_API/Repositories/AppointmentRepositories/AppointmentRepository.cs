using Dapper;
using FitMentor_API.Dtos.AppointmentDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace FitMentor_API.Repositories.AppointmentRepositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly Context _context;
        public AppointmentRepository(Context context)
        {
            _context = context;
        }
        public async Task DeleteAppointment(int id)
        {
            string query = "Delete From Appointment Where DateID=@DateID";
            var parameters = new DynamicParameters();
            parameters.Add("@DateID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultAppointmentDto>> GetAllAppointmentAsync()
        {
            string query = "Select * From Appointment";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultAppointmentDto>(query);
                return values.ToList();
            }
        }

        public async Task UpdateAppointment(UpdateAppointmentDto appointmentDto)
        {
            string query = "Update Appointment Set tarih=@tarih, saat=@saat where DateID=@DateID";
            var parameters = new DynamicParameters();
            parameters.Add("@tarih", appointmentDto.tarih);
            parameters.Add("@saat", appointmentDto.saat);
            parameters.Add("@DateID", appointmentDto.DateID); 

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

    }
}
