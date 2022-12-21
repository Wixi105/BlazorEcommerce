namespace BlazorEcommerce.Client.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private readonly HttpClient _http;

    public CategoryService(HttpClient httpClient)
    {
        _http = httpClient;
    }

    public List<Category> Categories { get ; set ; }

    public async Task GetCategories()
    {
        var results = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");
        if(results != null && results.Data != null)
            Categories = results.Data;
    }
}
