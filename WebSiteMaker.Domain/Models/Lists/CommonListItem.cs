using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteMaker.Domain.Models.BaseModel;

namespace WebSiteMaker.Domain.Models.Lists
{
    /// <summary>
    /// Represents a common list item.
    /// </summary>
    [Table("CommonListItems")]
    public class CommonListItem : BaseEntity
    {
        /// <summary>
        /// Gets or sets the code of the common list item.
        /// </summary>
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]+$")] // String expressions that do not contain spaces and Turkish characters
        [MaxLength(200)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the description of the common list item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the order of the page within a menu.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the page is the default page for a menu.
        /// </summary>
        public bool IsDefault { get; set; }


        /// <summary>
        /// Gets or sets the icon for the list item.
        /// </summary>
        public string ListItemIconURL { get; set; }

        /// <summary>
        /// Gets or sets the list code of the common list item.
        /// </summary>
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]+$")] // String expressions that do not contain spaces and Turkish characters
        [MaxLength(200)]
        public string ListCode { get; set; }

        /// <summary>
        /// Gets or sets the parent list item id of the common list item.
        /// </summary>
        [ForeignKey(nameof(CommonListItem))]
        public int ParentListItemId { get; set; }

        /// <summary>
        /// Gets or sets the parent list item of the common list item.
        /// </summary>
        public CommonListItem ParentListItem { get; set; }

        /// <summary>
        /// Gets or sets the parent list id of the common list item.
        /// </summary>
        [ForeignKey(nameof(CommonList))]
        public int ParentListId { get; set; }

        /// <summary>
        /// Gets or sets the parent list of the common list item.
        /// </summary>
        public CommonList ParentList { get; set; }
    }
}
