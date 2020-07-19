using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace AutomobileManagement.Resources
{
    public class MakeResource
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public Collection<ModelResource> Models { get; set; }

        public MakeResource()
        {
            Models = new Collection<ModelResource>();
        }
    }
}
