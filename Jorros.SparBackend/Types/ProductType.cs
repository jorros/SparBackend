using GraphQL.Types;
using Jorros.SparBackend.Entities.Store;

namespace Jorros.SparBackend.Types
{
	public class ProductType : ObjectGraphType<DProduct>
	{
		public ProductType()
		{
			Field<CategoryType>("category", "The Category of the product");
			Field(x => x.Description).Description("A short description");
			Field<StringGraphType>("id", "Unique product id", resolve: x => x.Source.ProductId.ToString());
			Field(x => x.Title).Description("Name of the product");
		}
	}
}