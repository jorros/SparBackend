using Jorros.SparBackend.Store.Requests;
using Jorros.SparBackend.Store.Responses;

namespace Jorros.SparBackend.Store
{
	public interface IProductGateway
	{
		GetProductByIdGatewayResponse GetProductById(GetProductByIdGatewayRequest request);

		GetProductsGatewayResponse GetProducts();
	}
}