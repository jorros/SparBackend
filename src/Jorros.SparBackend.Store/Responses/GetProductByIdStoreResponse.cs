using Jorros.SparBackend.Store.Entities;
using Jorros.SparBackend.Entities;

namespace Jorros.SparBackend.Store
{
	public class GetProductByIdStoreResponse : SparResponse
	{
		public Product Product { get; set; }
	}
}