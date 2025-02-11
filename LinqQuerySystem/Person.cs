    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace LinqQuerySystem
    {

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            // Correct placement of ToString() method
            //public override string ToString()
            //{
            //    return $"ID: {Id}, Name: {Name}, Age: {Age}";
            //}


            public void showdata()
            {
                List<Person> people = new List<Person>
                {
                    new Person { Id = 1, Name = "Simran", Age = 25 },
                    new Person { Id = 2, Name = "Harsh", Age = 30 },
                    new Person { Id = 3, Name = "Ravi", Age = 22 },
                    new Person { Id = 4, Name = "Priya", Age = 28 }
                };

                // LINQ Query to filter people aged 25 or older
                var filteredPeople = from person in people
                                     where person.Age >= 25
                                     select person;

                var maxage = people.OrderByDescending(p => p.Age).FirstOrDefault();

                Console.WriteLine($"Max Age is: {maxage.Age}");



                Console.WriteLine("---------------------");

                // Displaying the results
                Console.WriteLine("People aged 25 or older:");
                foreach (var person in filteredPeople)
                {
                    Console.WriteLine(person.Name, person.Age, person.Id);
                }
            }
        }

 
    }
