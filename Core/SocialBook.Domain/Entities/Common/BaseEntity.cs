namespace SocialBook.Domain.Entities.Common
{
    public class BaseEntity
    {
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the created date
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the updated date
        /// </summary>
        public DateTime UpdatedDate { get; set; }
    }
}
