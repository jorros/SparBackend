using Jorros.SparBackend.Entities;
using Jorros.SparBackend.Entities.Store;

namespace Jorros.SparBackend.Services.Responses
{
	public class GetProductByIdServiceResponse : ResponseBase
	{
		public DProduct DProduct { get; set; }
	}
}