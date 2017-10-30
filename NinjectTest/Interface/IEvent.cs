using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinjectTest.Models;

namespace NinjectTest.Interface
{
    public interface IEvent
    {
        List<EventModel> GetAll();  // Gets All Event details    
    }    
}
