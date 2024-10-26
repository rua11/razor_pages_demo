using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required(ErrorMessage = "Hãy nhập tên đi.")]
        public string Name { get; set; } = null!;

        [Column("category_type1", TypeName = "varchar")]
        [Comment("Category Type")]
        public string? CategoryType { get; set; }

        [Column("sequence")]
        [Comment("Sequence")]
        [Required(ErrorMessage = "Hãy nhập Sequence đi.")]

        public int Sequence { get; set; }

        [Column("parent_path", TypeName = "varchar")]
        [Comment("Parent Path")]
        public string? ParentPath { get; set; }

        [Column("depth")]
        [Comment("Depth")]

        public int? Depth { get; set; }

        [Column("is_active")]
        [Comment("Actived")]
        public bool IsActive { get; set; } = true;

        [Column("description", TypeName = "varchar")]
        [Comment("Description")]
        public string? Description { get; set; }

           

        [Column("parent_id")]
        [Comment("Parent")]
        public int? ParentId { get; set; }
        public OfitCategory? CategoryParent { get; set; }


        [Column("company_id")]
        [Comment("Company")]
        public int? CompanyId { get; set; }
        public OfitCompany? OfitCompany { get; set; }

        public ICollection<OfitCategory> CategoryChildrens { get; set; } = new List<OfitCategory>();
        public ICollection<OfitMaterial> OfitMaterials { get; set; } = new List<OfitMaterial>();
        public ICollection<OfitTool> OfitTools { get; set; } = new List<OfitTool>();
        public ICollection<OfitProduct> OfitProducts { get; set; } = new List<OfitProduct>();
        public ICollection<OfitUnit> OfitUnits { get; set; } = new List<OfitUnit>();
        public ICollection<OfitCrop> OfitCrops { get; set; } = new List<OfitCrop>();
        public ICollection<OfitPartner> OfitPartners { get; set; } = new List<OfitPartner>();

        // Selection field for Category Type
        public CategoryType1 Type { get; set; }
    }

    public enum CategoryType1
    {
        Material,   // 0
        Tool,   // 1
        Unit,      // 2
        Crop,
        Product,
        Activity,
        Other
    }

}
