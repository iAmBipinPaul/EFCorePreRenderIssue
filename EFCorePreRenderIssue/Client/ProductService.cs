using EFCorePreRenderIssue.Shared;
using EFCorePreRenderIssue.Shared.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePreRenderIssue.Client
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "api/Product";
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<ProductDto>> GetAsync()
        {
            return await _httpClient.GetJsonAsync<List<ProductDto>>(_baseUrl);
        }
    }
}
