using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Common
{
    public abstract class BaseEntity<K>
    {
        public K Id { get; set; }
        
    }
}
