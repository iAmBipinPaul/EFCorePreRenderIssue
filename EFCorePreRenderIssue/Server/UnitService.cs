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
    public class UnitService : IUnitService
    {
        private readonly EFCorePreRenderIssueDbContext _eFCorePreRenderIssueDbContext;

        public UnitService(EFCorePreRenderIssueDbContext eFCorePreRenderIssueDbContext)
        {
            _eFCorePreRenderIssueDbContext = eFCorePreRenderIssueDbContext;
        }
        public Task<List<UnitDto>> GetAsync()
        {
            return _eFCorePreRenderIssueDbContext.Units.Select(c => new UnitDto { 
          
            
            Id=c.Id,
            Name=c.Name            
            }).ToListAsync();
        }
    }
}
