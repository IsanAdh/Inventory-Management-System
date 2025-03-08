using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTMPos.Common.Dto
{
    public class  DataOutputDto<T>:OutputDto
    {
        public List<T> Data { get; set; }
        public DataOutputDto()
        {
            Data ??= new List<T>();
        }
    }
}
