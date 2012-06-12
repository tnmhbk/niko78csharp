using System.ComponentModel.DataAnnotations;

namespace EFComposite.Model
{
    [Table("Locations")]
    public class Location : Position
    {
        public int Capacity { get; set; }
    }
}
