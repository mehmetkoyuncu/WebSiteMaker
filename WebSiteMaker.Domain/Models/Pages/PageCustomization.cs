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
    /// Represents customization settings for a page, such as custom CSS, custom JavaScript, and layout settings.
    /// </summary>
    [Table("PageCustomizations")]
    public class PageCustomization : BaseEntity
    {
        /// <summary>
        /// Gets or sets the custom CSS for the page.
        /// </summary>
        public string CustomCSS { get; set; }

        /// <summary>
        /// Gets or sets the custom JavaScript for the page.
        /// </summary>
        public string CustomJS { get; set; }

        /// <summary>
        /// Gets or sets the layout settings for the page.
        /// </summary>
        public string LayoutSettings { get; set; }

        [ForeignKey(nameof(Page))]
        public int PageId { get; set; }
        public Page Page { get; set; }
    }
}
