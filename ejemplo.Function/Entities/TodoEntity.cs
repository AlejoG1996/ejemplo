using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace ejemplo.Function.Entities
{
    public class TodoEntity : TableEntity
    {
        public DateTime CreateTime { get; set; }

        public string TaskDescription { get; set; }

        public bool IsComplated { get; set; }
    }
}
