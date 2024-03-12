using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteMaker.Domain.Models.BaseModel;
using WebSiteMaker.Domain.Models.Pages;

namespace WebSiteMaker.Domain.Models.Lists
{
    /// <summary>
    /// Represents a list .
    /// </summary>
    [Table("CommonLists")]
    public class CommonList : BaseEntity
    {
        /// <summary>
        /// Gets or sets the code of the list .
        /// </summary>
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]+$")] //String expressions that do not contain spaces and Turkish characters
        [MaxLength(200)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the description of the list .
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the icon for the list .
        /// </summary>
        public string ListIconURL { get; set; }
        /// <summary>
        /// Gets or sets the definition code of the list .
        /// </summary>
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]+$")] // String expressions that do not contain spaces and Turkish characters
        [MaxLength(200)]
        public string DefinitionCode { get; set; }

        /// <summary>
        /// Gets or sets the parent list id of the list .
        /// </summary>
        [ForeignKey(nameof(CommonList))]
        public int ParentListId { get; set; }

        /// <summary>
        /// Gets or sets the parent list of the list .
        /// </summary>
        public CommonList ParentList { get; set; }
    }
}
