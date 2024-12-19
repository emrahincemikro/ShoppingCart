using AutoMapper;
using ShoppingCart.Services.ProductAPI.Models;
using ShoppingCart.Services.ProductAPI.Models.Dto;

namespace ShoppingCart.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
