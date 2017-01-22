using GraphQL.Types;
using Jorros.SparBackend.Entities.Store;

namespace Jorros.SparBackend.Types
{
	public class CategoryType : ObjectGraphType<DCategory>
	{
		public CategoryType()
		{
			Field<StringGraphType>("id", "Unique category id", resolve: x => x.Source.CategoryId.ToString());
			Field(x => x.Title).Description("The title of the category");
		}
	}
}