using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia76721.Domain.Common
{
    public interface IBaseEntity<K>
    {
        public K Id { get; set; }
    }
}
