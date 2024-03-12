using System;

namespace WebSiteMaker.Domain.Models.BaseModel
{
    /// <summary>
    /// Base class for all entities in the system.
    /// Contains common properties such as Id, creation and update information.
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user ID of the creator of the entity.
        /// </summary>
        public int? CreatedUserId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the entity was created.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user ID of the last user who updated the entity.
        /// </summary>
        public int? UpdatedUserId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the entity was last updated.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is deleted.
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Gets or sets the date and time when the entity was deleted.
        /// </summary>
        public DateTime? IsDeletedDate { get; set; }
    }
}
