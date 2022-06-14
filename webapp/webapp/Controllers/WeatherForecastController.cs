using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace webapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Shipwreck> Get()
        {
            var client = new MongoClient("mongodb+srv://root:<masterkey>@cluster0.oaocbkx.mongodb.net/?retryWrites=true&w=majority");
            var database = client.GetDatabase("sample_geospatial");
            var collection = database.GetCollection<Shipwreck>("shipwrecks");
            return collection.Find(s => s.FeatureType == "Wrecks - Visible").ToList();

        }
    }
}