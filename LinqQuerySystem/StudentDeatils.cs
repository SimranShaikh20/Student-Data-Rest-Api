using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqQuerySystem
{
    public class StudentDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Sem { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Sem: {Sem}, Year: {Year}";
        }

        public void ShowData()
        {
            List<StudentDetails> s = new List<StudentDetails>
            {
                new StudentDetails { Id = 1, Name = "Simran", Age = 25, Sem = 7, Year = 3 },
                new StudentDetails { Id = 2, Name = "Harsh", Age = 30, Sem = 3, Year = 2 },
                new StudentDetails { Id = 3, Name = "Ravi", Age = 22, Sem = 4, Year = 2 },
                new StudentDetails { Id = 4, Name = "Priya", Age = 28, Sem = 1, Year = 1 }
            };

            var filteredPeople = from student in s
                                 where student.Age >= 25
                                 select student;

            var maxAge = s.OrderByDescending(p => p.Age).ThenByDescending(p => p.Sem).FirstOrDefault();

            Console.WriteLine("---------------------");

            // Displaying the results
            Console.WriteLine("People aged 25 or older:");
            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, ID: {person.Id}");
            }

            // Displaying max age student
            if (maxAge != null)
            {
                Console.WriteLine("\nStudent with Maximum Age and then Semester:");
                Console.WriteLine(maxAge.ToString());
            }
        }
    }
}
