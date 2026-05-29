using System.Net.Http.Json;
using ZapateriaApp.Models;

namespace ZapateriaApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _http;

        private const string BaseUrl =
            "https://api-udec-pweb-aedec9hxbugye0am.westus3-01.azurewebsites.net";

        public ApiService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<ProductoApi>> ObtenerProductos()
        {
            try
            {
                var productos =
                    await _http.GetFromJsonAsync<List<ProductoApi>>(
                        $"{BaseUrl}/api/comercio/productos");

                return productos?
                    .Where(p => p.CategoriaId == 3)
                    .ToList()
                    ?? new List<ProductoApi>();
            }
            catch
            {
                return new List<ProductoApi>();
            }
        }

        public async Task<List<CategoriaApi>> ObtenerCategorias()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<CategoriaApi>>(
                    $"{BaseUrl}/api/comercio/categorias")
                    ?? new List<CategoriaApi>();
            }
            catch
            {
                return new List<CategoriaApi>();
            }
        }
    }
}