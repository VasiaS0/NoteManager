namespace MyPracticeProject.Models
{
    public class Note
    {
        public int Id { get; set; } // Унікальний ідентифікатор

        public string Title { get; set; } = string.Empty; // Заголовок нотатки

        public string Content { get; set; } = string.Empty; // Основний текст

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Дата створення

        public DateTime? UpdatedAt { get; set; } // Дата останнього редагування
        public string UserId { get; set; } = string.Empty;
    }

}
