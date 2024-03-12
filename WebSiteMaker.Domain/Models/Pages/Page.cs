using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebSiteMaker.Common.Enums;
using WebSiteMaker.Domain.Models.BaseModel;

namespace WebSiteMaker.Domain.Models.Pages
{
    /// <summary>
    /// Represents a page on the website.
    /// </summary>
    [Table("Pages")]
    public class Page : BaseEntity
    {
        /// <summary>
        /// Gets or sets the title of the page.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the definition code of the page.
        /// </summary>
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]+$")] //String expressions that do not contain spaces and Turkish characters
        [MaxLength(200)]
        public string DefinitionCode { get; set; }

        /// <summary>
        /// Gets or sets the version of the page.
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Gets or sets the type of definition for the page.
        /// </summary>
        public DefinitionTypeEnum DefinitionType { get; set; }

        /// <summary>
        /// Gets or sets the content of the page.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the URL of the page.
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// Gets or sets the published date of the page.
        /// </summary>
        public DateTime PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the access control list for the page.
        /// </summary>
        public ICollection<string> AccessControlList { get; set; }

        [ForeignKey(nameof(PageCustomization))]
        public int PageCustomizationId { get; set; }
        public PageCustomization PageCustomization { get; set; }

        [ForeignKey(nameof(PageMetadata))]
        public int PageMetadataId { get; set; }
        public PageMetadata PageMetadata { get; set; }

        [ForeignKey(nameof(PageSetting))]
        public int PageSettingId { get; set; }
        public PageSetting PageSetting { get; set; }
    }
}
