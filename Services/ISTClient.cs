using Project3.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Project3.Services
{
    public class ISTClient
    {
        /// <summary>
        /// Instantiating the HttpClient
        /// </summary>
        private static readonly HttpClient client = new HttpClient();
        /// <summary>
        /// Assigning all of the necesary information to the client
        /// </summary>
        static ISTClient()
        {
            client.BaseAddress = new Uri("http://ist.rit.edu");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        /// <summary>
        /// Async method that gets the Json from the api and converts it to a string
        /// </summary>
        /// <returns>
        /// Returns a string containing the information
        /// </returns>
        public static async Task<About> GetAboutAsync()
        {
            Task<string> aboutTask = client.GetStringAsync("/api/about");
            string response = await aboutTask;
            About about = JsonConvert.DeserializeObject<About>(response);
            return about;
        }
        /// <summary>
        /// Async method that gets the Json from the api and converts it to a string
        /// </summary>
        /// <returns>
        /// Returns a string containing the information
        /// </returns>
        public static async Task<UndergraduateViewModel> GetUndergraduateAsync()
        {
            try
            {
                HttpResponseMessage responseU = await client.GetAsync("/api/degrees/undergraduate",
                    HttpCompletionOption.ResponseHeadersRead);
                responseU.EnsureSuccessStatusCode();
                var data = await responseU.Content.ReadAsStringAsync();
                var undergraduatelist = JsonConvert.DeserializeObject<UndergraduateViewModel>(data);
                return undergraduatelist;
            }
            catch (HttpRequestException hre)
            {
                var msg = hre.Message;
                UndergraduateViewModel undergraduatelist = new UndergraduateViewModel();
                return undergraduatelist;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                UndergraduateViewModel undergraduatelist = new UndergraduateViewModel();
                return undergraduatelist;
            }

        }
        /// <summary>
        /// Async method that gets the Json from the api and converts it to a string
        /// </summary>
        /// <returns>
        /// Returns a string containing the information
        /// </returns>
        public static async Task<CoopTableView> GetCoopTableAsync()
        {
            try
            {
                HttpResponseMessage responseU = await client.GetAsync("/api/employment/coopTable",
                    HttpCompletionOption.ResponseHeadersRead);
                responseU.EnsureSuccessStatusCode();
                var data = await responseU.Content.ReadAsStringAsync();
                var coopTable = JsonConvert.DeserializeObject<CoopTableView>(data);
                return coopTable;
            }
            catch (HttpRequestException hre)
            {
                var msg = hre.Message;
                CoopTableView coopTable = new CoopTableView();
                return coopTable;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                CoopTableView coopTable = new CoopTableView();
                return coopTable;
            }

        }
        /// <summary>
        /// Async method that gets the Json from the api and converts it to a string
        /// </summary>
        /// <returns>
        /// Returns a string containing the information
        /// </returns>
        public static async Task<EmploymentTableViewModel> GetEmploymentTableAsync()
        {
            try
            {
                HttpResponseMessage responseU = await client.GetAsync("/api/employment/employmentTable",
                    HttpCompletionOption.ResponseHeadersRead);
                responseU.EnsureSuccessStatusCode();
                var data = await responseU.Content.ReadAsStringAsync();
                var empTable = JsonConvert.DeserializeObject<EmploymentTableViewModel>(data);
                return empTable;
            }
            catch (HttpRequestException hre)
            {
                var msg = hre.Message;
                EmploymentTableViewModel empTable = new EmploymentTableViewModel();
                return empTable;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                EmploymentTableViewModel empTable = new EmploymentTableViewModel();
                return empTable;
            }

        }
        /// <summary>
        /// Async method that gets the Json from the api and converts it to a string
        /// </summary>
        /// <returns>
        /// Returns a string containing the information
        /// </returns>
        public static async Task<GraduateViewModel> GetGraduateAsync()
        {
            try
            {
                HttpResponseMessage responseU = await client.GetAsync("/api/degrees/graduate",
                    HttpCompletionOption.ResponseHeadersRead);
                responseU.EnsureSuccessStatusCode();
                var data = await responseU.Content.ReadAsStringAsync();
                var graduateList = JsonConvert.DeserializeObject<GraduateViewModel>(data);
                return graduateList;
            }
            catch (HttpRequestException hre)
            {
                var msg = hre.Message;
                GraduateViewModel graduateList = new GraduateViewModel();
                return graduateList;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                GraduateViewModel graduateList = new GraduateViewModel();
                return graduateList;
            }

        }
        /// <summary>
        /// Async method that gets the Json from the api and converts it to a string
        /// </summary>
        /// <returns>
        /// Returns a string containing the information
        /// </returns>

        public static async Task<FacultyViewModel> GetFacultyAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("/api/people/faculty",
                    HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                var facultyList = JsonConvert.DeserializeObject<FacultyViewModel>(data);
                return facultyList;
            }
            catch (HttpRequestException hre)
            {
                var msg = hre.Message;
                FacultyViewModel facultyList = new FacultyViewModel();
                return facultyList;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                FacultyViewModel facultyList = new FacultyViewModel();
                return facultyList;
            }

        }

    }
}
