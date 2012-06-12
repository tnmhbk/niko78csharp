using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFComposite.Model
{
    [Table("Island")]
    public class Island : Position
    {
        public ICollection<Position> ChildPositions { get; set; }
    }
}
