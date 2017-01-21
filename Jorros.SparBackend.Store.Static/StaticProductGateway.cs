using System;
using System.Collections.Generic;
using System.Linq;
using Jorros.SparBackend.Store.Entities;
using Jorros.SparBackend.Store.Requests;
using Jorros.SparBackend.Store.Responses;

namespace Jorros.SparBackend.Store.Static
{
	public class StaticProductGateway : IProductGateway
	{
		private List<Product> _products;

		public StaticProductGateway()
		{
			_products = new List<Product>();
			for (var i = 0; i < 5; i++)
			{
				AddBogusProduct();
			}
		}

		public GetProductByIdGatewayResponse GetProductById(GetProductByIdGatewayRequest request)
		{
			if (request == null)
				throw new ArgumentNullException(nameof(request));

			var product = _products.FirstOrDefault(x => x.ProductId.ToString() == request.Id);

			if (product == null)
			{
				return new GetProductByIdGatewayResponse
				{
					Succeeded = false,
					ErrorMessage = $"Product with Id {request.Id} could not be found by {nameof(StaticProductGateway)}"
				};
			}

			return new GetProductByIdGatewayResponse
			{
				Product = product,
				Succeeded = true
			};
		}

		public GetProductsGatewayResponse GetProducts()
		{
			return new GetProductsGatewayResponse
			{
				Succeeded = true,
				Products = _products
			};
		}

		private void AddBogusProduct()
		{
			var product = new Product
			{
				Category = new Category { CategoryId = Guid.NewGuid(), Title = "Random Category" },
				Title = "Random Product Name",
				ProductId = Guid.NewGuid()
			};

			_products.Add(product);
		}
	}
}