using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Domin
{
    public class BaseDto
    {
        public Guid Id { get; set;}
        public Guid CreateBy { get; set; }

        public DateTime CreateTime { get; set; }
        public Guid LastModify { get; set; }
        public DateTime LastModifyTime { get; set; }

        public bool IsDelete { get; set; }
    }
}
