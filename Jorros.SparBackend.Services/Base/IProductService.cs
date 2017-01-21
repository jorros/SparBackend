using Jorros.SparBackend.Services.Requests;
using Jorros.SparBackend.Services.Responses;

namespace Jorros.SparBackend.Services.Base
{
	public interface IProductService
	{
		GetProductByIdServiceResponse GetProductById(GetProductByIdServiceRequest request);

		GetProductsServiceResponse GetProducts();
	}
}