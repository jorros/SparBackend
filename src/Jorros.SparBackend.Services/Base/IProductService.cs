namespace Jorros.SparBackend.Services
{
	public interface IProductService
	{
		GetProductByIdServiceResponse GetProductById(GetProductByIdServiceRequest request);

		GetProductsServiceResponse GetProducts();
	}
}
