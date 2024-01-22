using N8BlazorAutoLab.Client.DTO;

namespace N8BlazorAutoLab.Services;

public class WeatherDataService
{
  public async Task<WeatherForecast[]> QueryDataListAsync()
  {
    // Simulate asynchronous loading to demonstrate streaming rendering
    await Task.Delay(500);

    var startDate = DateOnly.FromDateTime(DateTime.Now);
    var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
    var forecasts = Enumerable.Range(1, 10).Select(index => new WeatherForecast
    {
      Date = startDate.AddDays(index),
      TemperatureC = Random.Shared.Next(-20, 55),
      Summary = summaries[Random.Shared.Next(summaries.Length)]
    }).ToArray();

    return forecasts;
  }
}
