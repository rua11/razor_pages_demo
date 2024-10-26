using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razor_demo.Data
{
    public class OfitCompany : BaseModel
    {
        [Column("name", TypeName = "varchar(10)")]
        [Comment("Name")]
        [Required]
        public string Name { get; set; }
        public ICollection<OfitCategory> OfitCategories { get; set; } = new List<OfitCategory>();

    }
}
