using System.Collections.Generic;
using Jorros.SparBackend.Entities;
using Jorros.SparBackend.Store.Entities;

namespace Jorros.SparBackend.Services
{
	public class GetProductsServiceResponse : SparResponse
	{
		public IEnumerable<Product> Products { get; set; }
	}
}
