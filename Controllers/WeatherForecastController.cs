using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpGet("school")]
        public async Task<IActionResult> GetAllSchool()
        {
            using (var context = new StudentDBContext())
            {
                var schoolLists_ = from s in context.School
                                   select new SchoolName(s.SchName, s.Advisor.Count());

                var schoolLists = from s in context.School
                                  select new { name = s.SchName, list = s.Advisor.Select(adv => adv.AdvFname) };

                var selectAdvisorBasedOnSchool = (context.School.Select(s => s.Advisor.Select(a => a.AdvFname))).ToList();
                //var schoolAdvisorLists = from s in context.School
                //                         select new SchDM(s.SchName, s.Advisor.Select(adv => adv.AdvFname).ToList());
                var schoolAdvisorLists = from s in context.School
                                         select new
                                         {
                                             Schoolname = s.SchName,
                                             adv = s.Advisor.Select(adv => adv.AdvFname).ToList()
                                         };

                var schList = context.School.Select(s => s.Advisor.Select(a => a.AdvFname));

                return Ok(await (schoolAdvisorLists.ToListAsync()));
            }
        }

        [HttpGet("schoolSimilarPhone")]
        public async Task<IActionResult> GetAllSchoolPhone()
        {
            using (var context = new StudentDBContext())
            {
                var result = context.School.Where(s => s.SchPhone.EndsWith("3600"));
                return Ok(await result.ToListAsync());
            }
        }

        [HttpGet("advisor/{schoolCode}")]
        public async Task<IActionResult> AdvisorQueries(string schoolCode)
        {
            using (var context = new StudentDBContext())
            {
                var query = context.Advisor.Where(adv => adv.SchCode == schoolCode).
                            Select(r => r.AdvFname);

                return Ok(await query.ToListAsync());
            }
        }

        [HttpGet("grade")]
        public async Task<IActionResult> gradeQueries()
        {
            using (var context = new StudentDBContext())
            {
                var maxGr_t2 = await context.Grade.MaxAsync(grt2 => grt2.GrT2);

                return Ok(maxGr_t2);
            }
        }

        [HttpGet("student")]
        public async Task<IActionResult> studentQueries()
        {
            using (var context = new StudentDBContext())
            {
                var include = await context.Student.Include(n => n.MajCodeNavigation)
                    .ToListAsync();
                return Ok(include);
            }
        }

        class SchoolName
        {
            public string schoolName { get; set; }
            public int AdvisorCount { get; set; }
            public SchoolName(string name, int count)
            {
                this.schoolName = name;
                this.AdvisorCount = count;
            }
        }

        class SchDM
        {
            public string schoolName { get; set; }
            public ICollection<string> AdvisorNameList { get; set; }

            public SchDM(string name, ICollection<string> _AdvName)
            {
                this.schoolName = name;
                this.AdvisorNameList = _AdvName;
            }
        }
    }
}
