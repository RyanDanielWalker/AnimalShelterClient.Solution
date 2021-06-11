using System.Threading.Tasks;
using RestSharp;

namespace AnimalShelterClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll(string component)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"{component}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task<string> Get(string component, int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"{component}/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    public static async Task Post(string component, string newObject)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"{component}", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newObject);
      var response = await client.ExecuteTaskAsync(request);
    }
    public static async Task Put(string component, int id, string newObject)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"{component}/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newObject);
      var response = await client.ExecuteTaskAsync(request);
    }
    public static async Task Delete(string component, int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"{component}/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}