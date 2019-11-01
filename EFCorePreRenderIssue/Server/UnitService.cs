using EFCorePreRenderIssue.Shared;
using EFCorePreRenderIssue.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePreRenderIssue.Server
{
    public class UnitService : IUnitService
    {
        private readonly EFCorePreRenderIssueDbContext _eFCorePreRenderIssueDbContext;

        public UnitService(EFCorePreRenderIssueDbContext eFCorePreRenderIssueDbContext)
        {
            _eFCorePreRenderIssueDbContext = eFCorePreRenderIssueDbContext;
        }
        public async Task<List<UnitDto>> GetAsync()
        {
            return await _eFCorePreRenderIssueDbContext.Units.Select(c => new UnitDto { 
          
            
            Id=c.Id,
            Name=c.Name            
            }).ToListAsync();
        }
    }
}
