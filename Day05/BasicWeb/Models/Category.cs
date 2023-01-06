using System.ComponentModel.DataAnnotations;

namespace BasicWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required] // 필수 (null 허용안함)
        public string Name { get; set; }
        public string DisplayOrder { get; set; }
        public DateTime PostDate { get; set; } = DateTime.Now;
    }

}
