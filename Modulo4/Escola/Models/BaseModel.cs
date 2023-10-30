using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo4.Escola.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        private static int _id;

        public BaseModel()
        {
            this.Id = ++_id;
        }
    }
}