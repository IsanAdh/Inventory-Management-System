using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTMPos.Common.Dto
{
    public class CategoryUpdateDto:CategoryInsertDto
    {
        public int Id { get; set; }
    }
}
