using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalShelterClient.Models
{
  public class Cat
  {
    public int CatId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Description { get; set; }
    private static string _component = "component";

    public static List<Cat> GetCats()
    {
      var apiCallTask = ApiHelper.GetAll(_component);
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Cat> catList = JsonConvert.DeserializeObject<List<Cat>>(jsonResponse.ToString());

      return catList;
    }
    public static Cat GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(_component, id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Cat review = JsonConvert.DeserializeObject<Cat>(jsonResponse.ToString());

      return review;
    }
  }
}

