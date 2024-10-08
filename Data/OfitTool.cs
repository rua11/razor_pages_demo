using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace razor_demo.Data
{
    [Table("ofit_tool")]
    [Comment("Tool Management")]
    public class OfitTool : BaseModel
    {
        //public int CompanyId { get; set; }
        //public int? UnitId { get; set; }
        //public string? Guid { get; set; }
        //public int? PartnerId { get; set; }

        [Column("name", TypeName = "varchar")]
        [Comment("Name")]
        [Required]
        public string Name { get; set; }

        [Column("tool_code", TypeName = "varchar")]
        [Comment("Tool Code")]
        [Required]
        public string ToolCode { get; set; }

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
