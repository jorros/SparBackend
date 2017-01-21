using AutoMapper;
using Jorros.SparBackend.Entities.Store;
using Jorros.SparBackend.Services.Responses;
using Jorros.SparBackend.Store.Entities;
using Jorros.SparBackend.Store.Responses;

namespace Jorros.SparBackend.Services.Mapper
{
	public class ProductProfile : Profile
	{
		public ProductProfile()
		{
			CreateMap<GetProductByIdGatewayResponse, GetProductByIdServiceResponse>();
			CreateMap<Product, DProduct>();

			CreateMap<GetProductsGatewayResponse, GetProductsServiceResponse>();
		}
	}
}