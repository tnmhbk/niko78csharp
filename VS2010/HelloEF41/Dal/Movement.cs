using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal
{
    public class Movement
    {
        public int Id { get; set; }

        public DateTime CreationTime { get; set; }

        public User User { get; set; }
    }
}
