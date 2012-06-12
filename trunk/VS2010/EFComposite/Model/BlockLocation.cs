using System.ComponentModel.DataAnnotations;

namespace EFComposite.Model
{
    [Table("BlockLocation")]
    public class BlockLocation : Location
    {
        public int CoordB { get; set; }
    }
}
