using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.UseCases_Application_.PluginInterfaces.DataStore;
using EShop.CoreBusiness_Domain_.Models;

namespace eShop.UseCases_Application_.SearchProductScreen;

public class SearchPoduct : ISearchProduct
{
    private readonly IProductRepository _productRepository;

    public SearchPoduct(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public IEnumerable<Product> Execute(string filter)
    {
        return _productRepository.GetProducts(filter);
    }
}
