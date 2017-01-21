using AutoMapper;
using Jorros.SparBackend.Services.Base;
using Jorros.SparBackend.Services.Requests;
using Jorros.SparBackend.Services.Responses;
using Jorros.SparBackend.Store;
using Jorros.SparBackend.Store.Requests;

namespace Jorros.SparBackend.Services
{
	public class GatewayProductService : IProductService
	{
		private readonly IProductGateway _productGateway;
		private readonly IMapper _mapper;

		public GatewayProductService(IProductGateway productGateway, IMapper mapper)
		{
			_productGateway = productGateway;
			_mapper = mapper;
		}

		public GetProductByIdServiceResponse GetProductById(GetProductByIdServiceRequest request)
		{
			var response = _productGateway.GetProductById(new GetProductByIdGatewayRequest { Id = request.Id });

			return _mapper.Map<GetProductByIdServiceResponse>(response);
		}

		public GetProductsServiceResponse GetProducts()
		{
			var response = _productGateway.GetProducts();

			return _mapper.Map<GetProductsServiceResponse>(response);
		}
	}
}