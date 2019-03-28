using Core2Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2Project.Services
{
    public interface ITimeTravelServices
    {
        // public TimeTravelItems AddTimeTravelItems(TimeTravelItems items);

        TimeTravelItems AddTimeTravelItems(TimeTravelItems items);

        Dictionary<string,TimeTravelItems> GetTimeTravelItems();
    }
}
