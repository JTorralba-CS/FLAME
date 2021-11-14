using Microsoft.AspNetCore.Mvc;

using FLAME.WASM.Shared;

namespace FLAME.WASM.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Table : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] X_First = new[]
        {
            "Jamie", "Yehudit", "Cherice", "Fabien", "Bill", "Tomi", "Vale", "Olivie", "Kevan", "Bruno", "Vito", "Ricca", "Seth", "Sharlene", "Pattie", "Abby", "Marcello"
        };

        private static readonly string[] X_Last = new[]
        {
            "Maccaig", "Stagge", "Zupa", "Tillard", "Jankowski", "Forsdike", "Grant", "Rollinson", "Seckom", "Suthren", "Sonschein", "Dunridge", "Mustoe", "Rowley", "Gladman", "Gowry", "Eouzan"
        };

        private static readonly string[] X_Domain = new[]
        {
            "@bigcartel.com", "@go.com", "@de.vu", "@delicious.com", "@gnu.org", "@adobe.com", "@netlog.com", "@utexas.edu", "@cpanel.net", "@icio.us", "@reuters.com", "@webs.com", "@live.com", "@opensource.org", "@weather.com", "@deviantart.com", "@apache.org"
        };

        private static readonly string[] X_Phone_Area_Code = new[]
        {
            "285", "676", "201", "522", "243", "588", "870", "626", "999", "702", "837", "139", "172", "631", "916", "752", "481"
        };

        private static readonly string[] X_Phone_3_Digit = new[]
        {
            "206", "679", "869", "690", "815", "561", "742", "334", "842", "254", "426", "183", "528", "563", "514", "195", "131"
        };

        private static readonly string[] X_Phone_4_Digit = new[]
        {
            "1675", "9096", "8268", "4435", "9667", "6425", "9918", "9730", "1647", "9147", "8585", "8302", "4029", "3890", "9948", "2581", "7739"
        };

        private static readonly string[] X_Title = new[]
        {
            "Paralegal", "Environmental Tech", "Chemical Engineer", "Speech Pathologist", "Compensation Analyst", "VP Sales", "Web Developer IV", "Pharmacist", "Structural Analysis Engineer", "Quality Engineer", "Safety Technician III", "Paralegal", "VP Product Management", "Director of Sales", "Account Coordinator", "Senior Sales Associate", "Registered Nurse"
        };

        private readonly ILogger<Table> _logger;

        public Table(ILogger<Table> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Record> Get()
        {
            var rng = new Random();

            return Enumerable.Range(1, 10).Select(index => new Record
            {
                ID = index,
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
                First = X_First[rng.Next(X_First.Length)],
                Last = X_Last[rng.Next(X_Last.Length)],
                Domain = X_Domain[rng.Next(X_Domain.Length)].ToLower(),     
                Title = X_Title[rng.Next(X_Title.Length)],
                Phone = "(" + X_Phone_Area_Code[rng.Next(X_Phone_Area_Code.Length)] + ") " + X_Phone_3_Digit[rng.Next(X_Phone_3_Digit.Length)] + "-" + X_Phone_4_Digit[rng.Next(X_Phone_4_Digit.Length)]
            })
            .ToArray();
        }
    }
}
