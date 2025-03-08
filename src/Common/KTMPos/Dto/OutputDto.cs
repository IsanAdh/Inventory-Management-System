using KTMPos.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTMPos.Common.Dto
{
    public class OutputDto //insert update delete specific
    {
        public Status Status { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }

        public OutputDto()
        {
            Errors ??= new List<string>();
        }
    }
}
