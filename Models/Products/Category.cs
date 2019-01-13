using System.ComponentModel.DataAnnotations;


namespace Project_Bier.Models
{
    public class Category
    {
        [Key] public string CategoryId { get; set; }
        public string Description { get; set; }
    }
}