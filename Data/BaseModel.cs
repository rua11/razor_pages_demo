using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace razor_demo.Data
{
    public abstract class BaseModel
    {
        public BaseModel() {
            CreateDate = DateTime.Now;
            WriteDate = DateTime.Now;
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        //public int? CreateUid { get; set; }
        //public int? WriteUid { get; set; }

        [Column("create_date", TypeName = "timestamp without time zone")]
        public DateTime? CreateDate { get; set; }

        [Column("write_date", TypeName = "timestamp without time zone")]
        public DateTime? WriteDate { get; set; }
    }
}
