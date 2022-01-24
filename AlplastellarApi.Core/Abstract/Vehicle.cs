using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlplastellarApi.Core.Abstract
{
    public abstract class Vehicle : IEntity
    {
        public int Id { get; set; }
        public string Color { get; set; }
    }
}
