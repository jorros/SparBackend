using System.Collections.Generic;
using Jorros.SparBackend.Entities;
using Jorros.SparBackend.Store.Entities;

namespace Jorros.SparBackend.Store
{
	public class GetProductsGatewayResponse : SparResponse
	{
		public IEnumerable<Product> Products { get; set; }
	}
}