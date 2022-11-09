using Academia76721.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Entities
{
    public class Director : BaseEntity<Guid>
    {
        public Director()
        {
            this.Id = Guid.Empty;
        }
        public string Name { get; set; }

    }
}
