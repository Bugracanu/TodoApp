using System.ComponentModel.DataAnnotations;
namespace TodoApp.Models;

public class TodoItem
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Başlık zorunludur")]
    [StringLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir")]
    public string Title { get; set; } = string.Empty;
    
    [StringLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olabilir")]
    public string Description { get; set; } = string.Empty;
    
    public bool IsCompleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? CompletedAt { get; set; }
    
    [Required]
    public string Priority { get; set; } = "Medium"; // Low, Medium, High
}