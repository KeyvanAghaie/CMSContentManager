using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace DTT.CMS.ContentManager.CMSContents
{
    public class CMSContentDto : AuditedEntityDto<Guid>
    {
        [Required]
        [StringLength(128)]
        public string Title { get; set; }

        [Required]
        [StringLength(2000)]
        public string Content { get; set; }
    }
}
