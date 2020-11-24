using System;
using System.Collections.Generic;
using System.Text;

namespace Tasker.Domain.Models
{
    public class TaskItem : Entity
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Author { get; set; }
    }
}
