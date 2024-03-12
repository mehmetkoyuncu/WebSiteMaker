using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteMaker.Common.Enums;
using WebSiteMaker.Domain.Models.BaseModel;
using WebSiteMaker.Domain.Models.WebSiteBasicInformation;

namespace WebSiteMaker.Domain.Models.Languages
{
    /// <summary>
    /// Represents a language used in a website.
    /// </summary>
    [Table("Languages")]
    public class Language:BaseEntity
    {
        /// <summary>
        /// Gets or sets the language code.
        /// </summary>
        [Required]
        public LanguageEnum Code { get; set; }

        /// <summary>
        /// Gets or sets the ID of the website to which this language belongs.
        /// </summary>
        [ForeignKey(nameof(WebSite))]
        public int WebSiteId { get; set; }
        public WebSiteDefinition WebSite { get; set; }

    }
}
