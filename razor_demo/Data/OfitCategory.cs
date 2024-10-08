using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace razor_demo.Data
{

    [Table("ofit_category")]
    [Comment("Category Management")]
    public class OfitCategory : BaseModel
    {
        //public int CompanyId { get; set; }
        //public bool IsFixed { get; set; }

        [Column("name", TypeName = "varchar")]
        [Comment("Name")]
        [Required(ErrorMessage = "Bạn chưa nhập tên Danh Mục.")]
        public required string Name { get; set; } = null!;

        [Column("parent_path", TypeName = "varchar")]
        [Comment("Parent Path")]
        public string? ParentPath { get; set; }

        [Column("depth")]
        [Comment("Depth")]
        public int? Depth { get; set; }

        [Column("is_active")]
        [Comment("Actived")]
        public bool IsActive { get; set; }

        [Column("description", TypeName = "varchar")]
        [Comment("Description")]
        public string? Description { get; set; }

      

        [Column("parent_id")]
        [Comment("Parent")]
        public int? ParentId { get; set; }
        public OfitCategory? CategoryParent { get; set; }
        public ICollection<OfitCategory> CategoryChildrens { get; set; } = new List<OfitCategory>();
        public ICollection<OfitMaterial> OfitMaterials { get; set; } = new List<OfitMaterial>();
        public ICollection<OfitTool> OfitTools { get; set; } = new List<OfitTool>();
        public ICollection<OfitProduct> OfitProducts { get; set; } = new List<OfitProduct>();
        public ICollection<OfitUnit> OfitUnits { get; set; } = new List<OfitUnit>();
        public ICollection<OfitCrop> OfitCrops { get; set; } = new List<OfitCrop>();
        public ICollection<OfitPartner> OfitPartners { get; set; } = new List<OfitPartner>();

        // Selection field for Category Type
        [Column("category_type")]
        [Comment("Category Type")]
        public CategoryType1 CategoryType { get; set; }
    }

    public enum CategoryType1
    {
        Material,   // 0
        Actiity,    // 1
        Product,   // 2
        Tool,   // 3
        Crop,// 4
        Unit,// 5
    }

}
