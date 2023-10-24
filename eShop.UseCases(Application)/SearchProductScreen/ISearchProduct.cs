﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.CoreBusiness_Domain_.Models;

namespace eShop.UseCases_Application_.SearchProductScreen;
public interface ISearchProduct
{
    IEnumerable<Product> Execute(string filter = null);
}
