using EFCorePreRenderIssue.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePreRenderIssue.Shared
{
    public class ProductService : IProductService
    {
        public Task<List<ProductDto>> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
