using EFCorePreRenderIssue.Shared;
using EFCorePreRenderIssue.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePreRenderIssue.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {

        private readonly IUnitService _unitService;

        public UnitController(
            IUnitService unitService
        )
        {
            _unitService = unitService;

        }
        [HttpGet]
        public async Task<ActionResult<List<UnitDto>>> GetAsync()
        {
            List<UnitDto> result = await _unitService.GetAsync();
            if (result != null)
                return Ok(result);
            return NotFound();
        }

    }
}
