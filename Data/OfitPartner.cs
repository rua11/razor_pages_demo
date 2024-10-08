using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace razor_demo.Data
{
    [Table("ofit_partner")]
    [Comment("Partner Management")]
    public class OfitPartner : BaseModel
    {

        //public int CompanyId { get; set; }

        [Column("name", TypeName = "varchar")]
        [Comment("Name")]
        [Required]
        public string Name { get; set; }

        [Column("internal_code", TypeName = "varchar")]
        [Comment("Internal Code")]
        [Required]
        public string InternalCode { get; set; }

        [Column("contact", TypeName = "varchar")]
        [Comment("Contact")]
        public string? Contact { get; set; }


        [Column("phone", TypeName = "varchar")]
        [Comment("Phone")]
        public string? Phone { get; set; }

        [Column("email", TypeName = "varchar")]
        [Comment("Email")]
        public string? Email { get; set; }

        [Column("website", TypeName = "varchar")]
        [Comment("Website")]
        public string? Website { get; set; }

        [Column("address", TypeName = "varchar")]
        [Comment("Address")]
        public string? Address { get; set; }

        [Column("comment", TypeName = "varchar")]
        [Comment("Comment")]
        public string? Comment { get; set; }

        //[Column("check_category")]
        //[Comment("CheckCategory")]
        //public bool CheckCategory { get; set; }

        [Column("category_id")]
        [Comment("Category")]
        public int? CategoryId { get; set; } // Required foreign key property
        public OfitCategory? OfitCategory { get; set; } // Required reference navigation to principal

    }
}
