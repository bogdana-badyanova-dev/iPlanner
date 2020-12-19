namespace iPlanner.Models
{
    /// <summary>
    /// Доски задач
    /// </summary>
    public class Board: BaseEntity
    {
        /// <summary>
        /// Заголок доски задач
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Подзаголовок доски задач
        /// </summary>
        public string SubTitle { get; set; }
        /// <summary>
        /// Тег доски задач
        /// </summary>
        public string Tag { get; set; }
    }
}
