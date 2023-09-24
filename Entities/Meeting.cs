using calendar_deneme.Abstract;
using calendar_deneme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar_deneme.Entities
{
    internal class Meeting:Event, INotification
    {
        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (var guest in Guests)
            {
                Console.WriteLine($"Inviting: {guest}");
            }
        }
    }
}
