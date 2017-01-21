using System.Collections.Generic;
using Jorros.SparBackend.Entities;
using Jorros.SparBackend.Store.Entities;

namespace Jorros.SparBackend.Store.Responses
{
	public class GetProductsGatewayResponse : ResponseBase
	{
		public IEnumerable<Product> Products { get; set; }
	}
}