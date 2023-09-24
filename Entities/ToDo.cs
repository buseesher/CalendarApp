using calendar_deneme.Abstract;
using calendar_deneme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar_deneme.Entities
{
    internal class ToDo:Event, INotification
    {
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time to make this to-do: {Title}");
        }
    }
}
