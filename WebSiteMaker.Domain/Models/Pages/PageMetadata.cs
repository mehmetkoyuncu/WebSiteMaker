using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteMaker.Domain.Models.BaseModel;

namespace WebSiteMaker.Domain.Models.Pages
{
    /// <summary>
    /// Represents metadata for a page, such as meta description, meta keywords, canonical URL, etc.
    /// </summary>
    [Table("PageMetadatas")]
    public class PageMetadata : BaseEntity
    {
        /// <summary>
        /// Gets or sets the title of the page.
        /// </summary>
        public string MetaDataTitle { get; set; }

        /// <summary>
        /// Gets or sets the meta description of the page.
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// Gets or sets the meta keywords of the page.
        /// </summary>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Gets or sets the canonical URL of the page.
        /// </summary>
        public string CanonicalUrl { get; set; }

        /// <summary>
        /// Gets or sets the social media tags of the page.
        /// </summary>
        public string SocialMediaTags { get; set; }

        /// <summary>
        /// Gets or sets the Open Graph settings of the page.
        /// </summary>
        public string OpenGraphSettings { get; set; }

        /// <summary>
        /// Gets or sets the Twitter Card settings of the page.
        /// </summary>
        public string TwitterCardSettings { get; set; }

        /// <summary>
        /// Gets or sets the author of the page.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the tags associated with the page.
        /// </summary>
        public ICollection<string> Tags { get; set; }

        [ForeignKey(nameof(Page))]
        public int PageId { get; set; }
        public Page Page { get; set; }
    }
}
