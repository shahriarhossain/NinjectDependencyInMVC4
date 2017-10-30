using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjectTest.Interface;
using NinjectTest.Models;

namespace NinjectTest.Concrete
{
    public class MyEvent : IEvent
    {
        public List<EventModel> GetAll()
        {
            return new List<EventModel>()
            {
                new EventModel() {EventID = 1, EventName = "TEST"}
            };
        }
    }
}