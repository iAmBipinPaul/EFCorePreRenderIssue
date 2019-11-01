using EFCorePreRenderIssue.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePreRenderIssue.Shared
{
    public class UnitService : IUnitService
    {
        public UnitService(Efcore)
        {

        }
        public Task<List<UnitDto>> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
