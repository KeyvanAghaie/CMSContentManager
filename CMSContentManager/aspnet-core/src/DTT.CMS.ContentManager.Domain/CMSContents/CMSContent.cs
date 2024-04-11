using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace DTT.CMS.ContentManager.CMSContents
{
    public class CMSContent : AuditedAggregateRoot<Guid>
    {
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
