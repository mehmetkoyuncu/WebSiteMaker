using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteMaker.Domain.Models.BaseModel;

namespace WebSiteMaker.Domain.Models.Parameters
{
    /// <summary>
    /// Represents a system parameter.
    /// </summary>
    public class SystemParameter : BaseEntity
    {
        /// <summary>
        /// Gets or sets the code of the system parameter.
        /// </summary>
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]+$")] //String expressions that do not contain spaces and Turkish characters
        [MaxLength(200)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the description of the system parameter.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the value of the system parameter.
        /// </summary>
        [Required]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the definition code of the system parameter.
        /// </summary>
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]+$")] // String expressions that do not contain spaces and Turkish characters
        [MaxLength(200)]
        public string DefinitionCode { get; set; }
    }
}
