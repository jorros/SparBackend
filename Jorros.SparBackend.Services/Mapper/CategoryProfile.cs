using AutoMapper;
using Jorros.SparBackend.Entities.Store;
using Jorros.SparBackend.Store.Entities;

namespace Jorros.SparBackend.Services.Mapper
{
	public class CategoryProfile : Profile
	{
		public CategoryProfile()
		{
			CreateMap<Category, DCategory>();
		}
	}
}