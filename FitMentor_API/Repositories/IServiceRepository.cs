using FitMentor_API.Dtos.ServiceDtos;

namespace FitMentor_API.Repositories
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        Task CreateService(CreateServiceDto createServiceDto);
        Task DeleteService(int id);
        Task UpdateService(UpdateServiceDto serviceDto);
    }
}
