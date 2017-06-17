using System.Collections.Generic;
using MyWebApp.Models.ViewModels;

namespace MyWebApp.Services
{
    public interface IPeopleService
    {
        List<Person> GetPeople();
        int PostPerson(Person model);
    }
}