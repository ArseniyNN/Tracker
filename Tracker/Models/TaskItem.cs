using System.ComponentModel.DataAnnotations;

namespace Tracker.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Название обязательно")]
        [MinLength(3 , ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100 , ErrorMessage = "Максимум 100 символов")]
        [Display(Name = "Название")]
        public string Title { get; set; } = "";
        [Display(Name = "Описание")]
        [MaxLength(1000 , ErrorMessage = "Максимум 1000 символов")]
        public string? Description { get; set; }
        [Display(Name = "Статус выполненности")]
        public bool IsDone { get; set; } = false;
        [Display(Name = "Дата создания")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
