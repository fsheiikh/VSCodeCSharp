using System.ComponentModel.DataAnnotations;
namespace quotingdojo.Models
{
 public abstract class BaseEntity {}
 public class Quote : BaseEntity
 {
  [Key]
  public long Id { get; set; }
  [Required]
  [MinLength(3)]
  public string name { get; set; }
  [Required]
  [MinLength(10)]
  public string comment { get; set; }
  
  public string created_at { get; set; }

  public int likes { get; set; }
 }
}