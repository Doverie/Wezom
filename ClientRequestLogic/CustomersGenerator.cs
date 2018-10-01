using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClientRequestLogic.Model;
using Bogus;
using Bogus.DataSets;

namespace ClientRequestLogic
{
    public class CustomersGenerator
    {

        public List<Customer> GenerateCustomers(int countOfCustomers)
        {

            List<Customer> customers = new List<Customer>();
            Random rand = new Random();


            var generator = new Faker<Customer>()
                .StrictMode(false)
                .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.Email, f => f.Person.Email)
                .RuleFor(x => x.CountOfTasks, f => f.Random.Number(1, 20))
                .RuleFor(x => x.DurationHours, f => f.Random.Number(1, 500))
                .RuleFor(x => x.ExcecutedTasks, (f, u) => f.Random.Number(1, u.CountOfTasks));
            


            for (int i = 1; i <= countOfCustomers; i++)
            {
                customers.Add(generator.Generate());
            }
            return  customers;
        }

    }
}
