using GraphQL.Types;
using Jorros.SparBackend.Services.Base;
using Jorros.SparBackend.Types;

namespace Jorros.SparBackend.Queries
{
	public class RootQuery : ObjectGraphType
	{
		public RootQuery(IProductService productService)
		{
			Field<ListGraphType<ProductType>>(
				"products",
				resolve: context =>
				{
					var result = productService.GetProducts();

					if(result.Succeeded)
						return result.Products;
					else
						return null;
				});
		}
	}
}