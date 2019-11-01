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
    public class UnitService : IUnitService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "api/Unit";
        public UnitService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<UnitDto>> GetAsync()
        {
            return await _httpClient.GetJsonAsync<List<UnitDto>>(_baseUrl);
        }
    }
}
