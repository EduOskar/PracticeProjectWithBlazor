using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.UseCases_Application_.PluginInterfaces.DataStore;
using EShop.CoreBusiness_Domain_.Models;

namespace eShop.UseCases_Application_.SearchProductScreen;
public class ViewProduct : IViewProduct
{
    private readonly IProductRepository _productRepository;

    public ViewProduct(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public Product Execute(int id)
    {
        return _productRepository.GetProduct(id);
    }
}
