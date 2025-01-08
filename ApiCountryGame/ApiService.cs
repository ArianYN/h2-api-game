namespace ApiCountryGame;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<CountryClass>> GetDataAsync()
    {
        string apiUrl = "https://opgaver.mercantec.tech/api/Countries";
        string apiResponse = await _httpClient.GetStringAsync(apiUrl);
        List<CountryClass> countryClasses = JsonConvert.DeserializeObject<List<CountryClass>>(apiResponse);
        return countryClasses;
    }
}