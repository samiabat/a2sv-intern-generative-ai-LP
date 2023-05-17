using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Common;

namespace TaskManagement.Domain
{
    internal class Checklist: BaseDomainEntity
    {
        public Task Task { get; set; }
        public int TaskId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
