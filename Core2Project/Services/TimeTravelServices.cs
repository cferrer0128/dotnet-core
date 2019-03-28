using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core2Project.Models;

namespace Core2Project.Services
{
    public class TimeTravelServices : ITimeTravelServices
    {

        private readonly Dictionary<string, TimeTravelItems> _timetravelItems;

        public TimeTravelServices()
        {
            _timetravelItems = new Dictionary<string, TimeTravelItems>();
        }
        public TimeTravelItems AddTimeTravelItems(TimeTravelItems items)
        {
            _timetravelItems.Add(items.ItemName, items);

            return items;
        }

       
        Dictionary<string, TimeTravelItems> ITimeTravelServices.GetTimeTravelItems()
        {
            return _timetravelItems;
        }
    }
}
