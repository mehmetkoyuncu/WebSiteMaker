using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebSiteMaker.Common.Enums
{
    public enum LanguageEnum
    {
        [Display(Name = "Türkçe")]
        tr,
        [Display(Name = "English")]
        en
    }
}
