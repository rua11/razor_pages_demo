using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razor_demo.Data
{
    [Table("ofit_unit")]
    [Comment("Unit Management")]
    public class OfitUnit : BaseModel
    {
        //public int CompanyId { get; set; }

        [Column("name", TypeName = "varchar")]
        [Comment("Name")]
        [Required]
        public string Name { get; set; }

        [Column("notation", TypeName = "varchar")]
        [Comment("Notation")]
        public string? Notation { get; set; }

        [Column("description", TypeName = "varchar")]
        [Comment("Description")]
        public string? Description { get; set; }

        [Column("default_unit")]
        [Comment("Default Unit")]
        public bool DefaultUnit { get; set; }

        [Column("is_active")]
        [Comment("Actived")]
        public bool IsActive { get; set; }

        [Column("convert")]
        [Comment("Convert")]
        public double? Convert { get; set; }

        [Column("category_id")]
        [Comment("Category")]
        [Required]
        public int CategoryId { get; set; } // Required foreign key property
        public OfitCategory? OfitCategory { get; set; } // Required reference navigation to principal
    }
}
