using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsackNewton.Data
{
    public abstract class Base
    {
        public  int Id { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}";
        }
    }
}
