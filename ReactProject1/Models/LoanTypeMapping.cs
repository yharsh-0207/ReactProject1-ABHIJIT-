using System;
using System.Collections.Generic;

namespace ReactProject1.Models;

public partial class LoanTypeMapping
{
    public int Id { get; set; }

    public string? LoanTypeName { get; set; }

    public string? ProductName { get; set; }

    public string? EntityType { get; set; }

    public string? InstanceId { get; set; }

    public bool? IsEnabled { get; set; }

    public string? LoanTypeCode { get; set; }

    public int? LoanTypeId { get; set; }
}
