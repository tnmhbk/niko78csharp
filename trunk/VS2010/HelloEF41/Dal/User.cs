using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Dal
{
    public class User
    {
        public User()
        {
            Movements = new List<Movement>();
        }

        public int Id { get; set; }

        public string Nombre { get; set; }

        public ICollection<Movement> Movements { get; set; }
    }
}
