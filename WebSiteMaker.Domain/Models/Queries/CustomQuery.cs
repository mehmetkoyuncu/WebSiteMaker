using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteMaker.Domain.Models.BaseModel;

namespace WebSiteMaker.Domain.Models.Queries
{
    /// <summary>
    /// Represents a custom query.
    /// </summary>
    public class CustomQuery : BaseEntity
    {
        /// <summary>
        /// Gets or sets the code of the query.
        /// </summary>
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]+$")] //String expressions that do not contain spaces and Turkish characters
        [MaxLength(200)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the description of the query.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the title of the query.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the content of the query.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the definition code of the query.
        /// </summary>
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]+$")] // String expressions that do not contain spaces and Turkish characters
        [MaxLength(200)]
        public string DefinitionCode { get; set; }
    }
}
