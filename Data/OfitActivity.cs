using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace razor_demo.Data
{
    [Table("ofit_activity")]
    [Comment("Activity Management")]
    public class OfitActivity : BaseModel
    {
        //public int CompanyId { get; set; }

        [Column("name", TypeName = "varchar(10)")]
        [Comment("Name")]
        [Required]
        public string Name { get; set; }

        [Column("description", TypeName = "varchar")]
        [Comment("Description")]
        public string? Description { get; set; }

        [Column("is_active")]
        [Comment("Actived")]
        public bool IsActive { get; set; } = true;

        [Column("is_farmer_activity")]
        [Comment("Is Farmer Activity")]
        public bool IsFarmerActivity { get; set; }

        [Column("is_harvesting")]
        [Comment("Is Harvesting")]
        public bool IsHarvesting { get; set; }

        [Column("sequence")]
        [Comment("Sequence")]
        public int? Sequence { get; set; }

        [Column("display_type")]
        [Comment("Display Type")]
        public int? DisplayType { get; set; } 

    }
}

