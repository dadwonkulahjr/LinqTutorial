using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTutorial
{
    public class Individual
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public decimal Salary { get; set; }

        public static List<Individual> GetIndividuals()
        {
            return new List<Individual>()
            {
                new Individual(){Id =101, FirstName="Mike", LastName="Simson", Gender = Gender.Male, Salary = 5000},
                new Individual(){Id =102, FirstName="Mary", LastName="Thomas", Gender = Gender.Female, Salary = 6500},
                new Individual(){Id =103, FirstName="Josephine", LastName="Johnson", Gender = Gender.Female, Salary =  2500},
                new Individual(){Id =104, FirstName="Ben", LastName="Wilson", Gender = Gender.Male, Salary = 3000},
                new Individual(){Id =105, FirstName="Beatrice", LastName="Williams", Gender = Gender.Female, Salary = 8000},
                new Individual(){Id =106, FirstName="Peter", LastName="Goldon", Gender = Gender.Male, Salary = 15000}
            };
        }
    }
}
