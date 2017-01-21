using Jorros.SparBackend.Entities;
using Jorros.SparBackend.Store.Entities;

namespace Jorros.SparBackend.Store.Responses
{
	public class GetProductByIdGatewayResponse : ResponseBase
	{
		public Product Product { get; set; }
	}
}