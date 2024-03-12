using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebSiteMaker.Common.Enums
{
    public enum DefinitionTypeEnum
    {

        [Display(Name = "Test")]
        Test,
        [Display(Name = "Active")]
        Active,
        [Display(Name = "Previous")]
        Previous,
    }
}
