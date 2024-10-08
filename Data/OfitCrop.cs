using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace razor_demo.Data
{
        [Table("ofit_crop")]
        [Comment("Crop Management")]
        public class OfitCrop : BaseModel
        {
            //public int? PartnerId { get; set; }
            //public int CompanyId { get; set; }

            [Column("name", TypeName = "varchar")]
            [Comment("Name")]
            [Required]
            public string Name { get; set; }

            [Column("crop_code", TypeName = "varchar")]
            [Comment("Crop Code")]
            [Required]
            public string CropCode { get; set; }

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
