using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ef_repo_sqlite_NET
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
