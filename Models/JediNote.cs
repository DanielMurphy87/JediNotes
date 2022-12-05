namespace JediNotes.Models
{

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("JediNotes")]
    public class JediNote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string? Title { get; set; }

        public string? Body { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public string Owner { get; set; }

        public string? JediRank { get; set; }

    }
}