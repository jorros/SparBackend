using System;

namespace Jorros.SparBackend.Entities.Store
{
	public class DProduct
	{
		public Guid ProductId { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public DCategory Category { get; set; }
	}
}