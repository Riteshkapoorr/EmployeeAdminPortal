using System;
using System.Collections.Generic;

namespace EmployeeAdminPortal.Models;

public partial class Label
{
    public int LabelId { get; set; }

    public string? LableName { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
