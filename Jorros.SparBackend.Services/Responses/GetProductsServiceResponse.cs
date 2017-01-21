using System.Collections.Generic;
using Jorros.SparBackend.Entities;
using Jorros.SparBackend.Entities.Store;

namespace Jorros.SparBackend.Services.Responses
{
	public class GetProductsServiceResponse : ResponseBase
	{
		public IEnumerable<DProduct> Products { get; set; }
	}
}