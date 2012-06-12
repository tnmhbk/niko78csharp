using System.ComponentModel.DataAnnotations;

namespace EFComposite.Model
{
    [Table("Aisle")]
    public class Aisle : Island
    {
        public int AisleNumber { get; set; }
    }
}
