﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models.Database
{
    public partial class ContFile
    {
        public ContFile()
        {
            InverseParentFile = new HashSet<ContFile>();
        }

        public int Id { get; set; }
        public int? ParentFileId { get; set; }
        public bool IsDirectory { get; set; }
        public DateTime CreationUtcTimestamp { get; set; }
        public string Name { get; set; }
        public Guid AccessGuid { get; set; }

        public virtual ContFile ParentFile { get; set; }
        public virtual ICollection<ContFile> InverseParentFile { get; set; }
    }
}
