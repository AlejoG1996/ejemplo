using System;

namespace ejemplo.Common.Models
{
    public class Todo
    {
        public DateTime CreateTime { get; set; }

        public string TaskDescription { get; set; }

        public bool IsComplated { get; set; }
    }
}
