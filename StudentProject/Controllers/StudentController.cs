using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentProject.Models;

namespace StudentProject.Controllers
{
    public class StudentController : Controller
    {
        Uri baseAddress = new Uri("http://localhost:7134/api");
        private readonly HttpClient _httpClient; 
        public StudentController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseAddress;

        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Student> studentlist= new List<Student>();
            HttpResponseMessage response=_httpClient.GetAsync(_httpClient.BaseAddress+"/StudentData/Get").Result;
            if (response != null) { 
            string data = response.Content.ReadAsStringAsync().Result;
              studentlist = JsonConvert.DeserializeObject<List<Student>>(data);

            }

            return View(studentlist);
        }
    }
}
