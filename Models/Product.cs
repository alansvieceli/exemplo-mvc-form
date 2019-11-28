using System.ComponentModel.DataAnnotations;

namespace exemplo_mvc_form.Models
{
    public class Product
    {

      [Required(ErrorMessage = "id é obrigatório")]
      [Range(10,20, ErrorMessage = "O valor do campo ID deve estar entre 10 e 20.")]
      public int Id { get; set; }
      [Required]
      [MinLength(3)]
      [MaxLength(15)]
      public string Name { get; set; }
      [Required]
      [Range(10,int.MaxValue)]
      public int Price { get; set; }
        
    }
}