using Dapper;
using FitMentor_API.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace FitMentor_API.Repositories
{
    public class ServiceRepository:IServiceRepository
    {
        private readonly Context _context;
        public ServiceRepository(Context context)
        {
            _context = context;
        }
        public async Task CreateService(CreateServiceDto createServiceDto)
        {
            string query = "insert into Service (Name, ImageUrl) values (@Name, @ImageUrl)";
            var parameters = new DynamicParameters();
            parameters.Add("@Name", createServiceDto.Name);
            parameters.Add("@ImageUrl", createServiceDto.ImageUrl);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteService(int id)
        {
            string query = "Delete From Service Where ServiceID=@ServiceID";
            var parameters = new DynamicParameters();
            parameters.Add("@ServiceID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = "Select * From Service";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public async Task UpdateService(UpdateServiceDto serviceDto)
        {
            string query = "Update Service Set Name=@Name, ImageUrl=@ImageUrl where ServiceID=@ServiceID";
            var parameters = new DynamicParameters();
            parameters.Add("@Name", serviceDto.Name);
            parameters.Add("@ImageUrl", serviceDto.ImageUrl);
            parameters.Add("@ServiceID", serviceDto.ServiceID);
            using (var connectiont = _context.CreateConnection())
            {
                await connectiont.ExecuteAsync(query, parameters);
            }
        }
    }
}
