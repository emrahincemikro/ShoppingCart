using ShoppingCart.Services.ShoppingCartAPI.Models.Dto;

namespace ShoppingCart.Services.ShoppingCartAPI.Service.Abstract
{
    public interface IProductService
    {
        public Task<IEnumerable<ProductDto>> GetProductsAsync();
    }
}
