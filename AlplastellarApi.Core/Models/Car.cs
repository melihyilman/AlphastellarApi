using AlplastellarApi.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlplastellarApi.Core.Models
{
    public class Car:Vehicle
    {
        public string Wheels { get; set; }
        public bool HeadLightsStatus { get; set; }
    }
}
