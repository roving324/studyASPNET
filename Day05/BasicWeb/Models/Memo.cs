using System.ComponentModel.DataAnnotations;

namespace BasicWeb.Models
{
    public class Memo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public DateTime Date { get; set; } = DateTime.MinValue;

    }
}
