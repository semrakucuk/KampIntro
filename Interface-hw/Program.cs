using System;

namespace Interface_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntarfacesIntro();



        }

        private static void IntarfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Semra", LastName = "Küçük", Address = "İstanbul" });

            Student student = new Student
            {
                LastName = "kucuk",
            };
            personManager.Add(student);
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get  ; set ; }
            public string FirstName { get; set; }
            public string LastName { get; set; } 
            public string Address { get; set; }
        }

        class Worker: IPerson
        { 
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Student: IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departman { get; set; }
        }
        class PersonManager
        {
            public void Add( IPerson person)
            {
                Console.WriteLine(person.LastName);
            }
        }
    }
}
