using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTT.CMS.ContentManager.CMSContents
{
    public class CreateUpdateCMSContentDto
    {

        public Guid? Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Title { get; set; }

        [Required]
        [StringLength(2000)]
        public string Content { get; set; }
    }
}
