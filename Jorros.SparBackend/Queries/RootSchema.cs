using GraphQL.Types;
using Jorros.SparBackend.Services.Base;

namespace Jorros.SparBackend.Queries
{
	public class RootSchema : Schema
	{
		public RootSchema(IProductService productService)
		{
			Query = new RootQuery(productService);
		}
	}
}