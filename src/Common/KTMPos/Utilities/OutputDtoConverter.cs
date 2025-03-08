using KTMPos.Common.Dto;
using KTMPos.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTMPos.Common.Utilities
{
    public static class OutputDtoConverter
    {
        public static OutputDto SetOutputDto(Status status, string message, List<string> error = default)
        {
            return new OutputDto
            {
                Status = status,
                Message = message,
                Errors = error
            };
        }//insert update delete 
        public static DataOutputDto<T> SetDataOutputDto<T>(Status status, string message,List<T> data, List<string> error = default)
        {
            return new DataOutputDto<T>
            {
                Status = status,
                Message = message,
                Data = data,
                Errors = error
            };
        }//data get
    }
}
