using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace razor_demo.Data
{
    [Table("ofit_product")]
    [Comment("Product Management")]

    public class OfitProduct : BaseModel
    {
        //public int CompanyId { get; set; }
        //public int? CropId { get; set; }


        [Column("name", TypeName = "varchar")]
        [Comment("Name")]
        [Required]
        public string Name { get; set; }

        [Column("internal_code", TypeName = "varchar")]
        [Comment("Internal Code")]
        [Required]
        public string InternalCode { get; set; }

        [Column("description", TypeName = "varchar")]
        [Comment("Description")]
        public string? Description { get; set; }

        [Column("is_active")]
        [Comment("Actived")]
        public bool IsActive { get; set; }

        [Column("category_id")]
        [Comment("Category")]
        [Required]
        public int CategoryId { get; set; } // Required foreign key property
        public OfitCategory? OfitCategory { get; set; } // Required reference navigation to principal
    }
}
