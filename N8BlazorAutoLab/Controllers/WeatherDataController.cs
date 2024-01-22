using Microsoft.AspNetCore.Mvc;
using N8BlazorAutoLab.Client.DTO;
using N8BlazorAutoLab.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace N8BlazorAutoLab.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WeatherDataController(WeatherDataService bizSvc)
  : ControllerBase
{
  // GET: api/<WeatherDataController>
  [HttpGet]
  public async Task<IEnumerable<WeatherForecast>> GetAsync()
  {
    var dataList = await bizSvc.QueryDataListAsync();
    return dataList;
  }

  // GET api/<WeatherDataController>/5
  [HttpGet("{id}")]
  public string Get(int id)
  {
    return "value";
  }

  // POST api/<WeatherDataController>
  [HttpPost]
  public void Post([FromBody] string value)
  {
  }

  // PUT api/<WeatherDataController>/5
  [HttpPut("{id}")]
  public void Put(int id, [FromBody] string value)
  {
  }

  // DELETE api/<WeatherDataController>/5
  [HttpDelete("{id}")]
  public void Delete(int id)
  {
  }
}
