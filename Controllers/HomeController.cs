using Project3.Models;
using Project3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace FacultyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// This is a async method that gets the async data
        /// </summary>
        /// <returns>
        /// it returns the async data back to the view 
        /// </returns>
        public async Task<IActionResult> About()
        {
            var about = await ISTClient.GetAboutAsync();
            return View(about);
        }
        /// <summary>
        /// This is a async method that gets the async data
        /// </summary>
        /// <returns>
        /// it returns the async data back to the view 
        /// </returns>
        public async Task<IActionResult> Undergraduate()
        {
            var undergraduateViewModel = await ISTClient.GetUndergraduateAsync();
            return View(undergraduateViewModel);
        }
        /// <summary>
        /// This is a async method that gets the async data
        /// </summary>
        /// <returns>
        /// it returns the async data back to the view 
        /// </returns>
        public async Task<IActionResult> Graduate()
        {
            var graduateViewModel = await ISTClient.GetGraduateAsync();
            return View(graduateViewModel);
        }
        /// <summary>
        /// This is a async method that gets the async data
        /// </summary>
        /// <returns>
        /// it returns the async data back to the view 
        /// </returns>
        public async Task<IActionResult> CoopTable()
        {
            var coopTable = await ISTClient.GetCoopTableAsync();
            return View(coopTable);
        }
        /// <summary>
        /// This is a async method that gets the async data
        /// </summary>
        /// <returns>
        /// it returns the async data back to the view 
        /// </returns>
        public async Task<IActionResult> EmploymentTable()
        {
            var employmentTable = await ISTClient.GetEmploymentTableAsync();
            return View(employmentTable);
        }
        /// <summary>
        /// This is a async method that gets the async data
        /// </summary>
        /// <returns>
        /// it returns the async data back to the view 
        /// </returns>
        public async Task<IActionResult> Faculty()
        {
            var facultyViewModel = await ISTClient.GetFacultyAsync();
            return View(facultyViewModel);
        }
        /// <summary>
        /// This is a async method that gets the async data
        /// </summary>
        /// <returns>
        /// it returns the async data back to the view 
        /// </returns>
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
