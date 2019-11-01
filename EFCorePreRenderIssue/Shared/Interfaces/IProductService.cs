using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCorePreRenderIssue.Shared.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAsync();
    }
}
