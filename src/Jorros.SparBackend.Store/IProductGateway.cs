using System;
namespace Jorros.SparBackend.Store
{
	public interface IProductGateway
	{
		GetProductByIdStoreResponse GetProductById(GetProductByIdGatewayRequest request);

		GetProductsGatewayResponse GetProducts();
	}
}
