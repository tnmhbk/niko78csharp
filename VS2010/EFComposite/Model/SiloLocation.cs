using System.ComponentModel.DataAnnotations;

namespace EFComposite.Model
{
    [Table("SiloLocation")]
    public class SiloLocation : Location
    {
        public int CoordX { get; set; }

        public int CoordY { get; set; }

        public int CoordP { get; set; }
    }
}
