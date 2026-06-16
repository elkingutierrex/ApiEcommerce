using System;
using System.ComponentModel.DataAnnotations;
namespace ApiEcommerce.Models.Dtos;

public class CreateCategoryDto
{

    [Required(ErrorMessage = "Name is required")]
    [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
    [MinLength(3, ErrorMessage = "Name cannot be less than 3 characters")]
    public string Name { get; set; } = string.Empty;

}