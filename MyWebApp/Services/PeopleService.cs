using MyWebApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Services
{
    public class PeopleService
    {
        public List<Person> GetPeople()
        {
            List<Person> peopleList = new List<Person>();
            peopleList.Add(new Person() { Id = 1, FirstName = "Victor", LastName = "Campos" });
            peopleList.Add(new Person() { Id = 1, FirstName = "craig", LastName = "Spreeman" });
            peopleList.Add(new Person() { Id = 1, FirstName = "Tassia", LastName = "Paschoal" });
            peopleList.Add(new Person() { Id = 1, FirstName = "Tassia", LastName = "Paschoal" });
            return peopleList;
        }
    }
}