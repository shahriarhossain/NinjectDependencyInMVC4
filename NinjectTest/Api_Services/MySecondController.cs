using System.Collections.Generic;
using System.Web.Http;
using NinjectTest.Interface;
using NinjectTest.Models;

namespace NinjectTest.API_Services
{
    public class MySecondController : ApiController
    {
        readonly IEvent someEvent;

        public MySecondController(IEvent someEvent)
        {
            this.someEvent = someEvent;
        }

        [HttpGet]
        [ActionName("GetSomeVal")]
        public List<EventModel> GetSomeVal()
        {
            var x = someEvent.GetAll();
            return x;
        }
    }
}
