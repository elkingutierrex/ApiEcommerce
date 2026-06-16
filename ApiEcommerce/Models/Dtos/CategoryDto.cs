using System;
using System.ComponentModel.DataAnnotations;
namespace ApiEcommerce.Models.Dtos;

public class CategoryDto
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public DateTime CreatedDate { get; set; }
}