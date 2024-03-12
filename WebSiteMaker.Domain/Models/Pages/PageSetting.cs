using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebSiteMaker.Domain.Models.BaseModel;

namespace WebSiteMaker.Domain.Models.Pages
{
    /// <summary>
    /// Represents settings for a page, such as whether it should be shown in the menu, is the home page, etc.
    /// </summary>
    [Table("PageSettings")]
    public class PageSetting : BaseEntity
    {
        /// <summary>
        /// Gets or sets a value indicating whether the page should be shown in the menu.
        /// </summary>
        public bool? ShowInMenu { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the page is the home page.
        /// </summary>
        public bool? IsHomePage { get; set; }

        /// <summary>
        /// Gets or sets the order of the page in the menu.
        /// </summary>
        public int? Order { get; set; }

        /// <summary>
        /// Gets or sets the template to be used for the page.
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// Gets or sets the layout of the page.
        /// </summary>
        public string Layout { get; set; }

        /// <summary>
        /// Gets or sets the breadcrumb for the page.
        /// </summary>
        public string Breadcrumb { get; set; }

        /// <summary>
        /// Gets or sets the URL to redirect to for the page.
        /// </summary>
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Gets or sets the URL of the icon for the page.
        /// </summary>
        public string IconURl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the page has an expiration date.
        /// </summary>
        public bool? IsExpiration { get; set; }

        /// <summary>
        /// Gets or sets the expiration date of the page.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        [ForeignKey(nameof(Page))]
        public int PageId { get; set; }
        public Page Page { get; set; }
    }
}
