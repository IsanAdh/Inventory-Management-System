﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTMPos.Common.Dto
{
    public class CategoryReadDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }   
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

    }
}
