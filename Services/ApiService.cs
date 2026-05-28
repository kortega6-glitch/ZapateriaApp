using System.Net.Http.Json;
using ZapateriaApp.Models;

namespace ZapateriaApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _http;

        private const string BaseUrl = "https://api-udec-pweb-aedec9hxbugye0am.westus3-01.azurewebsites.net";

        public ApiService(HttpClient http)
        {
            _http = http;
        }

        // TODOS los productos
        public async Task<List<ProductoApi>> ObtenerProductos()
        {
            var productos = await _http.GetFromJsonAsync<List<ProductoApi>>(
                $"{BaseUrl}/api/comercio/productos");

            // Solo categoría Calzado (id 3)
            return productos?
                .Where(p => p.CategoriaId == 3)
                .ToList()
                ?? new List<ProductoApi>();
        }

        // Categorías
        public async Task<List<CategoriaApi>> ObtenerCategorias()
        {
            return await _http.GetFromJsonAsync<List<CategoriaApi>>(
                $"{BaseUrl}/api/comercio/categorias")
                ?? new List<CategoriaApi>();
        }
    }
}