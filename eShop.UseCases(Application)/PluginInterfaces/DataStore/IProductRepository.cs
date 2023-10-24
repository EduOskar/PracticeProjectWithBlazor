using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.CoreBusiness_Domain_.Models;

namespace eShop.UseCases_Application_.PluginInterfaces.DataStore;
public interface IProductRepository
{
    IEnumerable<Product> GetProducts(string filter);
    Product GetProduct(int id);
}
