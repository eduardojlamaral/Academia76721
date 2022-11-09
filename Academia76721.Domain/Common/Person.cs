using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Common
{
    public abstract class Person : BaseEntity<int>
    {
        // int Id
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Country { get; set; }

    }
}
