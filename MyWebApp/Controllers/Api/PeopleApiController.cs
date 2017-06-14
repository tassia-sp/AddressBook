using MyWebApp.Models.ViewModels;
using MyWebApp.Services;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.Web.Controllers.Api
{
    [RoutePrefix("api/people")]
    public class PeopleApiController : ApiController
    {
        [Route(""), HttpGet]
        public HttpResponseMessage GetPeople()
        {
            PeopleService peopleSvc = new PeopleService();
            List<Person> peopleList = peopleSvc.GetPeople();
            return Request.CreateResponse(HttpStatusCode.OK, peopleList);
        }

        [Route("{id:int}"), HttpPut]
        public HttpResponseMessage EditPeople()
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}