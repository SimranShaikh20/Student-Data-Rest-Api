using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentData : ControllerBase
    {
        static List<Student> students=new List<Student>();
        // GET: api/<StudentData>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/<StudentData>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(s=>s.Id==id);
        }

        // POST api/<StudentData>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            students.Add(value);
        }

        // PUT api/<StudentData>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            int i= students.FindIndex(s => s.Id == id);
            if (i > 0)
            {
                students[i] = value;
            }
        }

        // DELETE api/<StudentData>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            students.RemoveAll(s => s.Id==id);
        }
    }
}
