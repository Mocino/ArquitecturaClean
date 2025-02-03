using Application.DTOs;

namespace Application.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllAsync();
        Task<ProductDto> GetByIdAsync(int id);
        Task AddAsync(CreateProductDto product);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateProducDto product);
    }
}
