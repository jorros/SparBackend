using Jorros.SparBackend.Store;

namespace Jorros.SparBackend.Services
{
	public class ProductGatewayService : IProductService
	{
		private readonly IProductGateway _productGateway;

		public ProductGatewayService(IProductGateway productGateway)
		{
			_productGateway = productGateway;
		}

		public GetProductByIdServiceResponse GetProductById(GetProductByIdServiceRequest request)
		{
			var response = _productGateway.GetProductById(new GetProductByIdGatewayRequest { Id = request.Id });

			// ToDo: Use Automapper here
			return new GetProductByIdServiceResponse
			{
				ErrorMessage = response.ErrorMessage,
				Product = response.Product,
				Succeeded = response.Succeeded
			};
		}

		public GetProductsServiceResponse GetProducts()
		{
			var response = _productGateway.GetProducts();

			// ToDo: Use Automapper here
			return new GetProductsServiceResponse
			{
				ErrorMessage = response.ErrorMessage,
				Products = response.Products,
				Succeeded = response.Succeeded
			};
		}
	}
}
