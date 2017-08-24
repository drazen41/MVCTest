using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVC_Test.Models;

namespace MVC_Test.Controllers
{
    public class PeopleController : ApiController
    {
        People[] people = new People[]
        {
             new People() { Name = "Test", Location = "Test"},
             new People() {Name = "Test 1", Location = "Test1"}, 
             new People () { Name = "Test 2", Location = "Test 2"}
        };
        List<People> peopleList = null;
        public PeopleController()
        {
            peopleList = new List<People>();
            People person1 = new People() { Name = "Test", Location = "Test"};
            People person2 = new People() { Name = "Test1", Location = "Test1"};
            People person3 = new People() { Name = "Test2", Location = "Test2"};
            peopleList.Add(person1);
            peopleList.Add(person2);
            peopleList.Add(person3);
            
        
        }
        // GET: api/People
        

        // GET: api/People/5
        public string Get(int id)
        {
            return "value";
        }
        public IEnumerable<People>  GetAllPeople()
        {
            
            return this.peopleList;
        }
        public IEnumerable<People> AddPerson([FromBody] People person)
        {
            
            peopleList.Add(person);
            return people;
        }
        public void Post([FromBody]People   user)
        {
            this.peopleList.Add(user);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
