using System;
using System.Collections.Generic;

namespace EmployeeAdminPortal.Models;

public partial class Task
{
    public int Id { get; set; }

    public int? LableId { get; set; }

    public string? TaskName { get; set; }

    public string? TaskDesc { get; set; }

    public DateTime? DateAdded { get; set; }

    public virtual Label? Lable { get; set; }
}
