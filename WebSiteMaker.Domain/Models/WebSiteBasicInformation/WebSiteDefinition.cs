using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebSiteMaker.Domain.Models.BaseModel;
using WebSiteMaker.Domain.Models.Languages;
using WebSiteMaker.Domain.Models.Pages;

namespace WebSiteMaker.Domain.Models.WebSiteBasicInformation
{
    /// <summary>
    /// Represents basic information about a website.
    /// </summary>
    [Table("WebSites")]
    public class WebSiteDefinition:BaseEntity
    {
        /// <summary>
        /// Gets or sets the unique code of the website.
        /// </summary>
        [Required]
        [RegularExpression(@"^[A-Za-z0-9]+$")] //String expressions that do not contain spaces and Turkish characters
        [MaxLength(200)]
        public string DefinitionCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the website.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the URL of the website.
        /// </summary>
        [Required]
        public string HomePageURL { get; set; }

        /// <summary>
        /// Gets or sets the URL of the logo of the website.
        /// </summary>
        public string LogoURL { get; set; }

        /// <summary>
        /// Gets or sets the description of the website.
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the website is active.
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or sets the languages supported by the website.
        /// </summary>
        public ICollection<Language> Languages { get; set; }
        public ICollection<Page> Pages { get; set; }

        [ForeignKey(nameof(PageMetadata))]
        public int PageMetadataId { get; set; }
        public PageMetadata PageMetadata { get; set; }
    }
}