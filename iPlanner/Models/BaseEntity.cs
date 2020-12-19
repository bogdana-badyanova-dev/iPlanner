using System;
using System.ComponentModel.DataAnnotations;

namespace iPlanner.Models
{
    /// <summary>
    /// Базовый класс сущности
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        [Key]
        public int Id { get; set; }

    }
}
