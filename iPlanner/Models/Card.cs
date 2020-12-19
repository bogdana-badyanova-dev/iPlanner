namespace iPlanner.Models
{
    /// <summary>
    /// Представление задачи
    /// </summary>
    public class Card: BaseEntity
    {
        /// <summary>
        /// Закоголовок задачи
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Текст задачи
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Код доски
        /// </summary>
        public int Board_id { get; set; }
    }
}
