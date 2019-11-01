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
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductController(
            IProductService productService
        )
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetAsync()
        {
            List<ProductDto> result = await _productService.GetAsync();
            if (result != null)
                return Ok(result);
            return NotFound();
        }
    }
}
