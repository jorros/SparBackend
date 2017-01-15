using System;
namespace Jorros.SparBackend.Store.Entities
{
	public class Product
	{
		public Guid ProductId { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public Category Category { get; set; }
	}
}
