using System;
using System.Collections.Generic;
using Microsoft.AspNet.OData;
using SampleService.Models;

namespace SampleService.Controllers
{
    public class PeopleController : ODataController
    {
        [EnableQuery]
        public List<Person> Get()
        {
            return new List<Person>()
            {
                new Person() { ID = 1, Name = "John" },
                new Person() { ID = 2, Name = "James" }
            };
        }
    }
}