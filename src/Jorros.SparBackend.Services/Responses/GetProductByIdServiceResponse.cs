using Jorros.SparBackend.Entities;
using Jorros.SparBackend.Store.Entities;

namespace Jorros.SparBackend.Services
{
	public class GetProductByIdServiceResponse : SparResponse
	{
		public Product Product { get; set; }
	}
}
