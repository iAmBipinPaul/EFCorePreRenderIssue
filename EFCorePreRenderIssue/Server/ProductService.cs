using EFCorePreRenderIssue.Shared;
using EFCorePreRenderIssue.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePreRenderIssue.Server
{
    public class ProductService : IProductService
    {
        private readonly EFCorePreRenderIssueDbContext _eFCorePreRenderIssueDbContext;

        public ProductService(EFCorePreRenderIssueDbContext eFCorePreRenderIssueDbContext)
        {
            _eFCorePreRenderIssueDbContext = eFCorePreRenderIssueDbContext;
        }
        public Task<List<ProductDto>> GetAsync()
        {

            return _eFCorePreRenderIssueDbContext.Products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                UnitId = p.UnitId,
                Unit = new UnitDto
                {
                    Name = p.Unit.Name,
                    Id = p.Unit.Id
                }
            }).ToListAsync();
        }
    }
}
