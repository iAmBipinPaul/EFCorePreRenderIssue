using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCorePreRenderIssue.Shared.Interfaces
{
    public interface IUnitService
    {
        Task<List<UnitDto>> GetAsync();
    }
}
