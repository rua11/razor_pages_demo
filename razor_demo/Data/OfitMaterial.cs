using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razor_demo.Data
{
    [Table("ofit_material")]
    [Comment("Material Management")]

    public class OfitMaterial : BaseModel
    {
        //public int CompanyId { get; set; }
        //public int? UnitId { get; set; }
        //public string? Guid { get; set; }
        //public int? PartnerId { get; set; }

        [Column("name", TypeName = "varchar")]
        [Comment("Name")]
        [Required]
        public string Name { get; set; } = null!;

        [Column("material_code", TypeName = "varchar")]
        [Comment("Material Code")]
        [Required]
        public string MaterialCode { get; set; } = null!;

        [Column("internal_code", TypeName = "varchar")]
        [Comment("Internal Code")]
        [Required]
        public string InternalCode { get; set; } = null!;

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

        [Column("image_data", TypeName = "bytea")]
        [Comment("Image Data")]
        public byte[]? ImageData { get; set; }

        [Column("qr_code_data", TypeName = "bytea")]
        [Comment("QR Code Data")]
        public byte[]? QrCodeData { get; set; }

        [Column("file", TypeName = "varchar")]
        [Comment("File")]
        public byte[]? File { get; set; }
    }


}
