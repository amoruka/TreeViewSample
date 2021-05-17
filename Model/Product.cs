using System.ComponentModel.DataAnnotations;

namespace TreeViewSample
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
