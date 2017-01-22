using System.IO;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Http;
using Jorros.SparBackend.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Jorros.SparBackend.Controllers
{
	[Route("/")]
	public class GraphQlController : Controller
	{
		private readonly RootSchema _rootSchema;
		private readonly IDocumentExecuter _documentExecuter;
		private readonly IDocumentWriter _documentWriter;

		public GraphQlController(RootSchema rootSchema, IDocumentExecuter documentExecuter, IDocumentWriter documentWriter)
		{
			_rootSchema = rootSchema;
			_documentExecuter = documentExecuter;
			_documentWriter = documentWriter;
		}

		[HttpPost]
		public async Task<string> Interface()
		{
			var reader = new StreamReader(HttpContext.Request.Body);
			var query = await reader.ReadToEndAsync();

			var result = await _documentExecuter.ExecuteAsync(x =>
			{
				x.Schema = _rootSchema;
				x.Query = query;
			});

			return _documentWriter.Write(result);
		}
	}
}